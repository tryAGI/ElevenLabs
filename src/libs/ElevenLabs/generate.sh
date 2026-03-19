set -e
dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error https://api.elevenlabs.io/openapi.json | jq . > openapi.json

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
