dotnet tool install --global autosdk.cli --prerelease

autosdk init \
  ElevenLabs \
  ElevenLabsClient \
  https://api.elevenlabs.io/openapi.json \
  tryAGI \
  --output .
