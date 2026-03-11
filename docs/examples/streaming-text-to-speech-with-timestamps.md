# Streaming Text to Speech with Timestamps

Stream synthesized audio together with character-level timing information for subtitles, captions, or lip-sync.

This example assumes `using ElevenLabs;` is in scope and `apiKey` contains your ElevenLabs API key.

```csharp
using var client = new ElevenLabsClient(apiKey);

// Choose a voice to synthesize with.
var voices = await client.Voices.GetVoicesAsync();
var voiceId = voices.Voices[0].VoiceId;

// Request streamed speech audio with timing metadata.
StreamingAudioChunkWithTimestampsResponseModel response =
    await client.TextToSpeech.CreateTextToSpeechByVoiceIdStreamWithTimestampsAsync(
        voiceId: voiceId,
        text: "Hello, this has timestamps.",
        modelId: "eleven_multilingual_v2",
        outputFormat: TextToSpeechStreamWithTimestampsOutputFormat.Mp32205032);

// Inspect the alignment information when it is present.
if (response.Alignment is { } alignment)
{
    for (int i = 0; i < alignment.Characters?.Count; i++)
    {
        Console.WriteLine($"'{alignment.Characters[i]}' " +
                          $"{alignment.CharacterStartTimesSeconds?[i]:F3}s - " +
                          $"{alignment.CharacterEndTimesSeconds?[i]:F3}s");
    }
}
```