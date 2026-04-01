# Voice Cloning

Create an instant voice clone from an audio sample, print the new voice ID, and delete the test voice afterwards.

This example assumes `using ElevenLabs;` is in scope and `apiKey` contains your ElevenLabs API key.

```csharp
using var client = new ElevenLabsClient(apiKey);

// Load a voice sample from disk.
byte[] voiceSample = await File.ReadAllBytesAsync(
    Path.Combine(AppContext.BaseDirectory, "Resources", "hello-in-russian-24k-pcm16.wav"));

// Create the cloned voice.
AddVoiceIVCResponseModel response = await client.Voices.CreateAsync(
    name: $"Test Cloned Voice {Guid.NewGuid():N}",
    files: [voiceSample],
    description: "A cloned voice from my audio sample",
    removeBackgroundNoise: false);

Console.WriteLine($"Cloned voice ID: {response.VoiceId}");

// Clean up the test voice once the example has succeeded.
await client.Voices.DeleteAsync(response.VoiceId);
```