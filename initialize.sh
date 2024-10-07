dotnet tool install --global autosdk.cli --prerelease

autosdk init \
  ElevenLabs \
  ElevenLabsClient \
  https://raw.githubusercontent.com/elevenlabs/elevenlabs-docs/refs/heads/main/openapi.json \
  tryAGI \
  --output .
