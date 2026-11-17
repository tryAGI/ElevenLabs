# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

C# SDK for the [ElevenLabs](https://elevenlabs.io/) text-to-speech and audio AI platform, auto-generated from the official ElevenLabs OpenAPI + AsyncAPI specifications using [AutoSDK](https://github.com/HavenDV/AutoSDK). Published as a NuGet package under the `ElevenLabs` package name.

## Build Commands

```bash
# Build the solution
dotnet build ElevenLabs.slnx

# Build for release (also produces NuGet package)
dotnet build ElevenLabs.slnx -c Release

# Run integration tests (requires ELEVENLABS_API_KEY env var)
dotnet test src/tests/IntegrationTests/ElevenLabs.IntegrationTests.csproj

# Regenerate SDK from OpenAPI spec
cd src/libs/ElevenLabs && ./generate.sh
```

## The hand-written realtime STT session is not superseded — do not deprecate it

`Extensions/RealtimeSpeechToTextSession.cs` and `SpeechToText2Client.Realtime.cs` open their own
`ClientWebSocket`, and they predate the generated realtime clients by five months (2026-05-25 and
2026-08-30 against 2026-10-19). By age that looks exactly like a leftover.

It is not. The three AsyncAPI contracts here — `asyncapi.json`,
`text-to-dialogue-asyncapi.json`, `text-to-dialogue-multi-context-asyncapi.json`, all three wired
into `generate.sh` — declare the channels `realtime`, `dialogue` and `dialogueMulti`. **None of them
is speech-to-text**, and the upstream OpenAPI declares no STT WebSocket path either. So that session
is the only implementation of the channel it serves, and nothing exists to generate a replacement
from.

Checked with `scripts/audit_generation_inputs.py --sdk ElevenLabs` in the workspace repo, which
reads the `autosdk generate` invocations rather than guessing from filenames. Cartesia's equivalent
hand-written client *was* deprecated, because its contracts do cover both STT channels — the
difference is the contract, not the dates.

Giving the STT WebSocket a handcrafted contract, the way Inworld and SmallestAI have, would let it be
generated. That is new work, not a cleanup.

## If you write the STT AsyncAPI contract, these are the two sources

Authoring one is feasible — ~10 message types — but **neither the docs nor our models are
sufficient alone**, and transcribing either one would bake its gaps into a contract that then
generates a client, which is worse than having no contract.

From ElevenLabs' docs (the API reference pages 403 for automated clients; the guides and event
reference are readable):

- `wss://api.elevenlabs.io/v1/speech-to-text/realtime`, API key in the `xi-api-key` header on the
  upgrade request. Client-side uses a single-use token whose transport on a raw socket is undocumented.
- Query parameters with enums: `model_id` (`scribe_v3_live`), `audio_format` (`pcm_8000` …
  `pcm_48000`, `ulaw_8000`), `commit_strategy` (`manual` default, `vad`, `turn_prediction`),
  `vad_silence_threshold_secs` (0.192–3.0), `include_timestamps`, `include_language_detection`,
  `diarize`, `filter_background_audio`, `keepalive_interval_ms` (500–10000).
- One client message, `input_audio_chunk`, discriminated by `message_type`, carrying
  `audio_base_64`, `commit`, `sample_rate`. A commit is the same message with empty audio.
- Server messages: `session_started`, `partial_transcript`, `committed_transcript`,
  `committed_transcript_with_timestamps`, plus `diarized_transcript`, `speakers_merged` and the
  entity/redaction/edit variants.
- The docs **do not** define the error envelope's shape or its `message_type` literal, the realtime
  word schema, `session_started`'s fields beyond `config`, or the wire name of `previous_text`.

From `Realtime/RealtimeSpeechToTextEvents.cs`, which fills exactly those gaps:
`ErrorEvent(ErrorType, Error)`, `SessionStartedEvent(SessionId, Config)`, `TranscriptionWord`, and
`previous_text` written out as a wire name. Those came from working against the service, not from the
docs, so they are the better source for the parts the docs omit — and the parts most worth verifying
against live traffic before they go into a contract.

### The error envelope is confirmed from live traffic

Connecting with a deliberately invalid `xi-api-key` — no real key needed, and nothing secret is
sent — returns one message and closes with 1000:

```json
{"message_type":"auth_error","error":"You must be authenticated to use this endpoint."}
```

So the error is discriminated by `message_type` like every other message, and the literal **is the
error type** (`auth_error`, `quota_exceeded`, `invalid_request`, …) rather than a generic `error`
with a separate type field. The text is in `error`.

`RealtimeEventParser` already does exactly this — its default branch builds
`ErrorEvent(type, error)` — so the hand-written models match the wire, and the one blocker on
writing the contract is gone. What remains undocumented and unprobed is the realtime word schema and
the entity/redaction/edit event shapes.

## Architecture

### Code Generation Pipeline

The SDK code in `src/libs/ElevenLabs/Generated/` is **entirely auto-generated** -- do not manually edit files there.

1. `src/libs/ElevenLabs/openapi.yaml` -- the ElevenLabs OpenAPI spec (fetched from `https://api.elevenlabs.io/openapi.json`)
2. `src/libs/ElevenLabs/asyncapi.json` -- AsyncAPI 3.0.0 spec for realtime speech-to-text WebSocket API
3. `src/libs/ElevenLabs/generate.sh` -- downloads spec and runs AutoSDK CLI for OpenAPI + AsyncAPI, output to `Generated/`
4. CI auto-updates the spec every 3 hours and creates PRs if changes are detected

`generate.sh` contents:

```bash
dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://api.elevenlabs.io/openapi.json
autosdk generate openapi.yaml \
  --namespace ElevenLabs \
  --clientClassName ElevenLabsClient \
  --targetFramework net8.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --methodNamingConvention MethodAndPath \
  --security-scheme ApiKey:Header:xi-api-key \
  --base-url https://api.elevenlabs.io
```

### Project Layout

| Project | Purpose |
|---------|---------|
| `src/libs/ElevenLabs/` | Main SDK library (`ElevenLabsClient` + `ElevenLabsRealtimeClient`) |
| `src/tests/IntegrationTests/` | Integration tests against real ElevenLabs API |

### Documentation Generation

Tests in `src/tests/IntegrationTests/Examples` are the single source of truth for both test coverage and documentation:
- Each file has a JSDoc header (`order`, `title`, `slug`) consumed by `autosdk docs sync .`
- Comments prefixed with `////` become prose paragraphs in generated docs
- CI workflow (`.github/workflows/mkdocs.yml`) auto-generates `docs/examples/` and populates `EXAMPLES:START/END` markers in README.md, docs/index.md, and mkdocs.yml
- Config: `autosdk.docs.json` points to `src/tests/IntegrationTests/Examples`
### Realtime Speech-to-Text (Two-Layer Architecture)

The realtime STT API has two layers:

1. **Generated low-level client** — `ElevenLabsRealtimeClient` (in `ElevenLabs.Realtime` namespace), auto-generated from `asyncapi.json`:
   - `SendInputAudioChunkAsync()` with `InputAudioChunkPayload` (base64 audio, sample rate, commit flag)
   - `ReceiveUpdatesAsync()` returning a discriminated `ServerEvent` union (`IsSessionStarted`, `IsPartialTranscript`, `IsCommittedTranscript`, `IsCommittedTranscriptWithTimestamps`, `IsError`)
   - See test: `Examples/RealtimeSpeechToTextGenerated.cs`

2. **Hand-written high-level wrapper** — `RealtimeSpeechToTextSession` (in `ElevenLabs` namespace):
   - `SendAudioChunkAsync()` accepts raw bytes or PCM16 sample arrays (automatic base64 encoding)
   - `ReadEventsAsync()` yields typed event records (`SessionStartedEvent`, `PartialTranscriptEvent`, etc.)
   - Created via `client.ConnectRealtimeAsync()` with `RealtimeSpeechToTextOptions`
   - See test: `Examples/RealtimeSpeechToText.cs`

### Hand-Written Extensions

| File | Purpose |
|------|---------|
| `Extensions/SpeechToText2Client.ExtensionsAI.cs` | Microsoft.Extensions.AI speech-to-text integration (`ISpeechToTextClient` on `SpeechToText2Client`) |
| `Extensions/SpeechToText2Client.Realtime.cs` | `ConnectRealtimeAsync()` — opens a realtime STT WebSocket session |
| `Extensions/TextToSpeechClient.ResponseHeaders.cs` | Captures response headers (e.g. `request-id`) from TTS requests |
| `Extensions/ElevenLabsClient.Realtime.cs` | Convenience delegate to `SpeechToText2.ConnectRealtimeAsync()` |
| `Realtime/RealtimeAudioFormat.cs` | Enum for supported PCM/μ-law audio formats |
| `Realtime/RealtimeCommitStrategy.cs` | Enum for Manual/VAD commit strategies |
| `Realtime/RealtimeSpeechToTextOptions.cs` | Options record for realtime session configuration |
| `Realtime/RealtimeSpeechToTextEvents.cs` | Typed event records and JSON parser for WebSocket messages |
| `Realtime/RealtimeSpeechToTextSession.cs` | WebSocket session: send audio chunks, receive typed events |
| `Realtime/RealtimeJsonContext.cs` | Source-generated `JsonSerializerContext` for AOT/trimming compatibility |

### Build Configuration

- **Target:** `net10.0` (single target)
- **Language:** C# preview with nullable reference types
- **Signing:** Strong-named assemblies via `src/key.snk`
- **Versioning:** Semantic versioning from git tags (`v` prefix) via MinVer
- **Analysis:** All .NET analyzers enabled, AOT/trimming compatibility enforced
- **Testing:** MSTest + AwesomeAssertions
- **Dependencies:** Microsoft.Extensions.AI.Abstractions

### Key Conventions

- The client class is named `ElevenLabsClient`
- The namespace is `ElevenLabs`
- Method names are generated from HTTP method and path (`--methodNamingConvention MethodAndPath`)

### CI/CD

- Uses shared workflows from `HavenDV/workflows` repo
- Dependabot updates NuGet packages weekly (auto-merged)
- Documentation deployed to GitHub Pages via MkDocs Material
