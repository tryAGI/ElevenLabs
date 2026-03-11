# Text to Speech

Convert text to speech with the first available voice and save the generated audio to disk.

This example assumes `using ElevenLabs;` is in scope and `apiKey` contains your ElevenLabs API key.

```csharp
using var client = new ElevenLabsClient(apiKey);

// Choose a voice to synthesize with.
var voices = await client.Voices.GetVoicesAsync();
var voiceId = voices.Voices[0].VoiceId;

// Generate speech audio.
byte[] audioBytes = await client.TextToSpeech.CreateTextToSpeechByVoiceIdAsync(
    voiceId: voiceId,
    text: "Hello, world! This is a test of the ElevenLabs text-to-speech API.");

// Persist the result to a local file.
await File.WriteAllBytesAsync("output.mp3", audioBytes);
Console.WriteLine($"Saved {audioBytes.Length} bytes to output.mp3");
```