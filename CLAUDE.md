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
2. `src/helpers/FixOpenApiSpec/` -- converts OpenAPI 3.1 to 3.0 format for compatibility
3. `src/libs/ElevenLabs/generate.sh` -- orchestrates: download spec, fix spec, run AutoSDK CLI with `--methodNamingConvention MethodAndPath`, output to `Generated/`
4. CI auto-updates the spec and creates PRs if changes are detected

### Project Layout

| Project | Purpose |
|---------|---------|
| `src/libs/ElevenLabs/` | Main SDK library (`ElevenLabsClient`) |
| `src/tests/IntegrationTests/` | Integration tests against real ElevenLabs API |
| `src/helpers/FixOpenApiSpec/` | OpenAPI spec fixer tool |
| `src/helpers/GenerateDocs/` | Documentation generator from integration tests |
| `src/helpers/TrimmingHelper/` | NativeAOT/trimming compatibility validator |

### Hand-Written Extensions

| File | Purpose |
|------|---------|
| `Extensions/SpeechToTextClient.ExtensionsAI.cs` | Microsoft.Extensions.AI speech-to-text integration |

### Build Configuration

- **Target:** `net10.0` (single target)
- **Language:** C# preview with nullable reference types
- **Signing:** Strong-named assemblies via `src/key.snk`
- **Versioning:** Semantic versioning from git tags (`v` prefix) via MinVer
- **Analysis:** All .NET analyzers enabled, AOT/trimming compatibility enforced
- **Testing:** MSTest + FluentAssertions
- **Dependencies:** Microsoft.Extensions.AI.Abstractions

### Key Conventions

- The client class is named `ElevenLabsClient`
- The namespace is `ElevenLabs`
- Method names are generated from HTTP method and path (`--methodNamingConvention MethodAndPath`)

### CI/CD

- Uses shared workflows from `HavenDV/workflows` repo
- Dependabot updates NuGet packages weekly (auto-merged)
- Documentation deployed to GitHub Pages via MkDocs Material
