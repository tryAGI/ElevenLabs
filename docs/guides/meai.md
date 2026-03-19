# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The `ElevenLabs` SDK implements the `ISpeechToTextClient` interface from `Microsoft.Extensions.AI`, enabling you to use ElevenLabs speech-to-text through a standardized .NET AI abstraction.

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

Process transcription results as they arrive:

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

### Token Usage

Usage information is available on the response:

```csharp
var response = await sttClient.GetTextAsync(options);

Console.WriteLine($"Audio duration: {response.Usage?.InputTokenCount}");
Console.WriteLine($"Characters: {response.Usage?.OutputTokenCount}");
```
