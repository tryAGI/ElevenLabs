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
| `Extensions/TextToSpeech2Client.ResponseHeaders.cs` | Captures response headers (e.g. `request-id`) from TTS requests |
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
