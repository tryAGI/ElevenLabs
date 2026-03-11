# Streaming Text to Speech

Request a streaming text-to-speech response for low-latency playback and save the returned audio bytes.

This example assumes `using ElevenLabs;` is in scope and `apiKey` contains your ElevenLabs API key.

```csharp
using var client = new ElevenLabsClient(apiKey);

// Choose a voice to synthesize with.
var voices = await client.Voices.GetVoicesAsync();
var voiceId = voices.Voices[0].VoiceId;

// Request streaming speech audio.
byte[] streamedAudio = await client.TextToSpeech.CreateTextToSpeechByVoiceIdStreamAsync(
    voiceId: voiceId,
    text: "This audio is streamed for low-latency playback.",
    modelId: "eleven_multilingual_v2",
    outputFormat: TextToSpeechStreamOutputFormat.Mp32205032);

// Persist the result to a local file.
await File.WriteAllBytesAsync("streamed-output.mp3", streamedAudio);
Console.WriteLine($"Saved {streamedAudio.Length} bytes to streamed-output.mp3");
```