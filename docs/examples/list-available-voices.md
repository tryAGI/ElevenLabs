# List Available Voices

Fetch all voices available to the authenticated account and print each voice name and ID so you can pick one for text-to-speech requests.

This example assumes `using ElevenLabs;` is in scope and `apiKey` contains your ElevenLabs API key.

```csharp
using var client = new ElevenLabsClient(apiKey);

// Fetch all voices for the authenticated workspace.
GetVoicesResponseModel response = await client.Voices.GetVoicesAsync();

// Print the voice names and IDs so you can reuse a voice in text-to-speech.
foreach (var voice in response.Voices)
{
    Console.WriteLine($"{voice.Name} ({voice.VoiceId})");
}
```