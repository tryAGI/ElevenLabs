# Speech to Text from a File

Transcribe a WAV file from disk and print the returned transcript text.

This example assumes `using ElevenLabs;` is in scope and `apiKey` contains your ElevenLabs API key.

```csharp
using var client = new ElevenLabsClient(apiKey);

// Load an audio file to transcribe.
byte[] audioFile = await File.ReadAllBytesAsync(
    Path.Combine(AppContext.BaseDirectory, "Resources", "hello-in-russian-24k-pcm16.wav"));

// Submit the file for transcription.
var transcription = await client.SpeechToText.CreateSpeechToTextAsync(
    modelId: BodySpeechToTextV1SpeechToTextPostModelId.ScribeV1,
    file: audioFile,
    filename: "hello-in-russian-24k-pcm16.wav",
    languageCode: "ru");

// Print the transcript text when it is available.
var transcriptText = transcription.Value1 is { } chunk
    ? chunk.Text
    : null;

if (!string.IsNullOrWhiteSpace(transcriptText))
{
    Console.WriteLine(transcriptText);
}
```