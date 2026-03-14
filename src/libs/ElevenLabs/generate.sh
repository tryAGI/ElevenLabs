dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://api.elevenlabs.io/openapi.json

# ElevenLabs returns millisecond epoch values like 1700000000000 for
# FineTuningResponseModel.next_max_verification_attempts_reset_unix_ms.
# Without forcing int64 here, AutoSDK generates int? and GetVoicesAsync()
# fails at runtime during voice deserialization. See ElevenLabs issue #209.
tmp_openapi="$(mktemp)"
jq -c '
  if .components.schemas.FineTuningResponseModel.properties.next_max_verification_attempts_reset_unix_ms.type? == "integer" then
    .components.schemas.FineTuningResponseModel.properties.next_max_verification_attempts_reset_unix_ms.format = "int64"
  else
    .components.schemas.FineTuningResponseModel.properties.next_max_verification_attempts_reset_unix_ms.anyOf |= map(
      if .type? == "integer" then . + {"format": "int64"} else . end
    )
  end
' openapi.yaml > "$tmp_openapi" && mv "$tmp_openapi" openapi.yaml

autosdk generate openapi.yaml \
  --namespace ElevenLabs \
  --clientClassName ElevenLabsClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --methodNamingConvention MethodAndPath \
  --security-scheme ApiKey:Header:xi-api-key \
  --base-url https://api.elevenlabs.io
