# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

C# SDK for the [ElevenLabs](https://elevenlabs.io/) text-to-speech and audio AI platform, auto-generated from the official ElevenLabs OpenAPI specification using [AutoSDK](https://github.com/HavenDV/AutoSDK). Published as a NuGet package under the `ElevenLabs` package name.

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
2. `src/libs/ElevenLabs/generate.sh` -- downloads spec and runs AutoSDK CLI to generate the SDK
3. CI auto-updates the spec every 3 hours and creates PRs if changes are detected

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
| `src/libs/ElevenLabs/` | Main SDK library (`ElevenLabsClient`) |
| `src/tests/IntegrationTests/` | Integration tests against real ElevenLabs API |

### Hand-Written Extensions

| File | Purpose |
|------|---------|
| `Extensions/SpeechToTextClient.ExtensionsAI.cs` | Microsoft.Extensions.AI speech-to-text integration |
| `Extensions/SpeechToTextClient.Realtime.cs` | `ConnectRealtimeAsync()` — opens a realtime STT WebSocket session |
| `Extensions/ElevenLabsClient.Realtime.cs` | Convenience delegate to `SpeechToText.ConnectRealtimeAsync()` |
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
