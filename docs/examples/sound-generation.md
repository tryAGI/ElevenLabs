# Sound Generation

Generate a short sound effect from a text prompt and save the returned audio bytes.

This example assumes `using ElevenLabs;` is in scope and `apiKey` contains your ElevenLabs API key.

```csharp
using var client = new ElevenLabsClient(apiKey);

// Generate a sound effect from a text description.
byte[] soundBytes = await client.SoundGeneration.CreateSoundGenerationAsync(
    text: "A gentle ocean wave crashing on a sandy beach",
    durationSeconds: 3.0);

// Persist the result to a local file.
await File.WriteAllBytesAsync("ocean-wave.mp3", soundBytes);
Console.WriteLine($"Saved {soundBytes.Length} bytes to ocean-wave.mp3");
```