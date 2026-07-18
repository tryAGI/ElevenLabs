#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

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

install_autosdk_cli
rm -rf Generated
if [[ "$use_pinned_spec" == false ]]; then
  fetch_spec --fail --silent --show-error -L https://api.elevenlabs.io/openapi.json | jq '
    # ElevenLabs publishes the agent RAG query route in its public OpenAPI document,
    # but x-fern-ignore prevents non-Fern generators from exposing the operation.
    del(.paths["/v1/convai/agents/{agent_id}/knowledge-base/rag-query"].post["x-fern-ignore"])
    | (.paths["/v1/convai/agents/{agent_id}/knowledge-base/rag-query"].post["x-fern-sdk-method-name"]) = "query_knowledge_base_rag"
    |
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
