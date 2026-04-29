#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://api.elevenlabs.io/openapi.json (+ AsyncAPI)

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error -L https://api.elevenlabs.io/openapi.json | jq '
  # The upstream GenerationNode response spec lists every model-specific parameter
  # schema in one large anyOf. That generates a huge AnyOf<...> type which trips
  # Roslyn/System.Text.Json source generation, while the corresponding request
  # shapes already treat model_parameters as provider-specific JSON.
  (.components.schemas.GenerationNode.properties.model_parameters) = {
    "anyOf": [
      {
        "additionalProperties": true,
        "type": "object"
      },
      {
        "type": "null"
      }
    ],
    "title": "Model Parameters",
    "description": "Model-specific parameters."
  }
' > openapi.json

autosdk generate openapi.json \
  --namespace ElevenLabs \
  --clientClassName ElevenLabsClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --methodNamingConvention MethodAndPath \
  --security-scheme ApiKey:Header:xi-api-key \
  --base-url https://api.elevenlabs.io

autosdk generate asyncapi.json \
  --namespace ElevenLabs.Realtime \
  --websocket-class-name ElevenLabsRealtimeClient \
  --json-serializer-context RealtimeSourceGenerationContext \
  --targetFramework net10.0 \
  --output Generated \
  --security-scheme ApiKey:Header:xi-api-key \
  --base-url https://api.elevenlabs.io
