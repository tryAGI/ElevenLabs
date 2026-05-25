# Eleven Music

Create a short composition plan with Eleven Music, generate a minimum-length instrumental track from it, and save the returned audio bytes.

This example assumes `using ElevenLabs;` is in scope and `apiKey` contains your ElevenLabs API key.

```csharp
using var client = new ElevenLabsClient(apiKey);

const string prompt =
    "Create a short upbeat instrumental synthwave loop with bright arpeggios and a steady drum groove.";

// Create a structured composition plan from a natural-language prompt.
MusicPrompt compositionPlan = await client.MusicGeneration.CreateAsync(
    prompt: prompt,
    musicLengthMs: 3000);

Console.WriteLine($"Generated {compositionPlan.Sections.Count} music section(s).");

// Generate music from the composition plan.
byte[] musicBytes = await client.Music.ComposeAsync(
    outputFormat: AllowedOutputFormats.Mp32205032,
    compositionPlan: compositionPlan);

// Persist the result to a local file.
await File.WriteAllBytesAsync("eleven-music.mp3", musicBytes);
Console.WriteLine($"Saved {musicBytes.Length} bytes to eleven-music.mp3");
```