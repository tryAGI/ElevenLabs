# List Available Voices

Fetch all voices available to the authenticated account and print each voice name.

This example assumes `using ElevenLabs;` is in scope and `apiKey` contains your ElevenLabs API key.

```csharp
using var client = new ElevenLabsClient(apiKey);

// Fetch all voices for the authenticated workspace.
GetVoicesResponseModel response = await client.Voices.GetVoicesAsync();

// Print the voice names.
foreach (var voice in response.Voices)
{
    Console.WriteLine(voice.Name);
}
```