#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://api.elevenlabs.io/openapi.json (+ AsyncAPI)

use_pinned_spec=false
for arg in "$@"; do
  case "$arg" in
    --pinned-spec)
      use_pinned_spec=true
      ;;
    *)
      echo "Unknown argument: $arg" >&2
      exit 1
      ;;
  esac
done
if [[ "${TRYAGI_PINNED_SPEC:-0}" == "1" ]]; then
  use_pinned_spec=true
fi

if dotnet tool list --global | grep -q '^autosdk\.cli[[:space:]]'; then
  dotnet tool update --global autosdk.cli --prerelease
else
  dotnet tool install --global autosdk.cli --prerelease
fi
rm -rf Generated
if [[ "$use_pinned_spec" == false ]]; then
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
elif [[ ! -f openapi.json ]]; then
  echo "error: --pinned-spec requested but openapi.json does not exist." >&2
  exit 1
fi

autosdk generate openapi.json \
  --namespace ElevenLabs \
  --clientClassName ElevenLabsClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --generate-http-exception-hierarchy \
  --generate-retry-handler \
  --generate-pageable-helpers \
  --generate-multipart-upload-helpers \
  --methodNamingConvention MethodAndPath \
  --security-scheme ApiKey:Header:xi-api-key \
  --auth-env-var ELEVENLABS_API_KEY \
  --base-url https://api.elevenlabs.io

autosdk generate asyncapi.json \
  --namespace ElevenLabs.Realtime \
  --websocket-class-name ElevenLabsRealtimeClient \
  --json-serializer-context RealtimeSourceGenerationContext \
  --targetFramework net10.0 \
  --output Generated \
  --security-scheme ApiKey:Header:xi-api-key \
  --auth-env-var ELEVENLABS_API_KEY \
  --base-url https://api.elevenlabs.io
