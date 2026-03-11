dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://api.elevenlabs.io/openapi.json
autosdk generate openapi.yaml \
  --namespace ElevenLabs \
  --clientClassName ElevenLabsClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --methodNamingConvention MethodAndPath \
  --security-scheme ApiKey:Header:xi-api-key \
  --base-url https://api.elevenlabs.io
