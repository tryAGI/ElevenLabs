# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The ElevenLabs SDK implements `ISpeechToTextClient` from [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai).

## Supported Interfaces

| Interface | Support Level |
|-----------|--------------|
| `ISpeechToTextClient` | Full (file-based and streaming transcription) |

## ISpeechToTextClient

### Installation

```bash
dotnet add package ElevenLabs
```

### File-Based Transcription

Transcribe an audio file to text:

```csharp
using ElevenLabs;
using Microsoft.Extensions.AI;

using var client = new ElevenLabsClient(apiKey);
ISpeechToTextClient sttClient = client;

var audioBytes = await File.ReadAllBytesAsync("audio.mp3");

var response = await sttClient.GetTextAsync(
    new SpeechToTextOptions
    {
        AudioData = new DataContent(audioBytes, "audio/mpeg"),
        ModelId = "scribe_v1",
    });

Console.WriteLine(response.Text);
```

### Streaming Transcription

Process transcription results via the streaming interface:

```csharp
ISpeechToTextClient sttClient = client;
var audioBytes = await File.ReadAllBytesAsync("audio.mp3");

await foreach (var update in sttClient.GetStreamingTextAsync(
    new SpeechToTextOptions
    {
        AudioData = new DataContent(audioBytes, "audio/mpeg"),
        ModelId = "scribe_v1",
    }))
{
    Console.Write(update.Text);
}
```

### Streaming Behavior

`GetStreamingTextAsync` delegates to the non-streaming `GetTextAsync` method internally. The Scribe API processes the audio synchronously, and then the full result is converted to `SpeechToTextResponseUpdate` events using `ToSpeechToTextResponseUpdates()`.

This means you will not receive incremental transcription updates as audio is processed. The entire transcript is returned at once after processing completes. For most use cases, calling `GetTextAsync` directly is equivalent and simpler.

!!! note
    ElevenLabs does offer a real-time streaming WebSocket API for speech-to-text. Use `client.ConnectRealtimeAsync()` to access real-time streaming with interim and committed transcript events.

### Transcription with Language Hint

Specify a language for more accurate transcription:

```csharp
ISpeechToTextClient sttClient = client;
var audioBytes = await File.ReadAllBytesAsync("french-audio.mp3");

var response = await sttClient.GetTextAsync(
    new SpeechToTextOptions
    {
        AudioData = new DataContent(audioBytes, "audio/mpeg"),
        ModelId = "scribe_v1",
        AdditionalProperties = new AdditionalPropertiesDictionary
        {
            ["language_code"] = "fr",
        },
    });

Console.WriteLine(response.Text);
```

### Advanced Configuration with RawRepresentationFactory

Use `RawRepresentationFactory` to access ElevenLabs-specific features like speaker diarization, timestamps, and custom vocabulary:

```csharp
ISpeechToTextClient sttClient = client;
var audioBytes = await File.ReadAllBytesAsync("audio.mp3");

var response = await sttClient.GetTextAsync(
    new MemoryStream(audioBytes),
    new SpeechToTextOptions
    {
        RawRepresentationFactory = _ => new BodySpeechToTextV1SpeechToTextPost
        {
            File = audioBytes,
            ModelId = BodySpeechToTextV1SpeechToTextPostModelId.ScribeV1,
            LanguageCode = "en",
            Diarize = true,
            TagAudioEvents = true,
            TimestampsGranularity = BodySpeechToTextV1SpeechToTextPostTimestampsGranularity.Word,
        },
    });

Console.WriteLine(response.Text);
```

### Accessing the Raw Response

The full ElevenLabs response is available via `RawRepresentation` for word-level timestamps, speaker labels, and audio events:

```csharp
var response = await sttClient.GetTextAsync(
    new MemoryStream(audioBytes),
    new SpeechToTextOptions
    {
        ModelId = "scribe_v1",
    });

// Access the provider-specific response (discriminated union)
if (response.RawRepresentation is AnyOf<SpeechToTextChunkResponseModel,
    MultichannelSpeechToTextResponseModel,
    SpeechToTextWebhookResponseModel> result)
{
    if (result.IsValue1 && result.Value1 is { } chunk)
    {
        Console.WriteLine($"Language: {chunk.LanguageCode}");

        // Access word-level timestamps and speaker diarization
        foreach (var word in chunk.Words)
        {
            Console.WriteLine($"  [{word.Start:F2}s - {word.End:F2}s] {word.Text} " +
                $"(type: {word.Type}, speaker: {word.SpeakerId})");
        }
    }
}
```

### Token Usage

Usage information is available on the response:

```csharp
var response = await sttClient.GetTextAsync(options);

Console.WriteLine($"Audio duration: {response.Usage?.InputTokenCount}");
Console.WriteLine($"Characters: {response.Usage?.OutputTokenCount}");
```
