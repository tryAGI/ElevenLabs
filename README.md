# ElevenLabs

[![Nuget package](https://img.shields.io/nuget/vpre/ElevenLabs)](https://www.nuget.org/packages/ElevenLabs/)
[![dotnet](https://github.com/tryAGI/ElevenLabs/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/ElevenLabs/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/ElevenLabs)](https://github.com/tryAGI/ElevenLabs/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on [official ElevenLabs OpenAPI specification](https://api.elevenlabs.io/openapi.json) using [AutoSDK](https://github.com/tryAGI/AutoSDK)
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- Support .Net Framework/.Net Standard 2.0
- Realtime speech-to-text via WebSocket

## Usage

### Installation
```bash
dotnet add package ElevenLabs
```

### Authentication
```csharp
using ElevenLabs;

using var client = new ElevenLabsClient(apiKey);
```

### List Available Voices
```csharp
//// List all available voices and print their names.
var response = await client.Voices.GetVoicesAsync();

foreach (var voice in response.Voices)
{
    Console.WriteLine(voice.Name);
}
```

### Text to Speech
```csharp
//// Convert text to speech using a specific voice and save the audio to a file.
var voices = await client.Voices.GetVoicesAsync();
var voiceId = voices.Voices[0].VoiceId;

byte[] audioBytes = await client.TextToSpeech.CreateTextToSpeechByVoiceIdAsync(
    voiceId: voiceId,
    text: "Hello, world! This is a test of the ElevenLabs text-to-speech API.");

await File.WriteAllBytesAsync("output.mp3", audioBytes);
```

### Streaming Text to Speech
```csharp
//// Stream text-to-speech audio using a specific voice, useful for real-time playback.
var voices = await client.Voices.GetVoicesAsync();
var voiceId = voices.Voices[0].VoiceId;

byte[] streamedAudio = await client.TextToSpeech.CreateTextToSpeechByVoiceIdStreamAsync(
    voiceId: voiceId,
    text: "This audio is streamed for low-latency playback.",
    modelId: "eleven_multilingual_v2",
    outputFormat: TextToSpeechStreamOutputFormat.Mp32205032);

await File.WriteAllBytesAsync("streamed-output.mp3", streamedAudio);
```

### Streaming Text to Speech with Timestamps
```csharp
//// Stream text-to-speech audio with character-level timing for lip-sync or subtitles.
var voices = await client.Voices.GetVoicesAsync();
var voiceId = voices.Voices[0].VoiceId;

StreamingAudioChunkWithTimestampsResponseModel response =
    await client.TextToSpeech.CreateTextToSpeechByVoiceIdStreamWithTimestampsAsync(
        voiceId: voiceId,
        text: "Hello, this has timestamps.",
        modelId: "eleven_multilingual_v2",
        outputFormat: TextToSpeechStreamWithTimestampsOutputFormat.Mp32205032);

// Access character-level alignment data
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

### Sound Generation
```csharp
//// Generate a sound effect from a text description.
byte[] soundBytes = await client.SoundGeneration.CreateSoundGenerationAsync(
    text: "A gentle ocean wave crashing on a sandy beach",
    durationSeconds: 3.0);

await File.WriteAllBytesAsync("ocean-wave.mp3", soundBytes);
```

### Speech to Text (File)
```csharp
//// Transcribe an audio file to text.
byte[] audioFile = await File.ReadAllBytesAsync("recording.mp3");

var transcription = await client.SpeechToText.CreateSpeechToTextAsync(
    modelId: BodySpeechToTextV1SpeechToTextPostModelId.ScribeV1,
    file: audioFile,
    languageCode: "en");

// Access the transcript text
if (transcription.Value1 is { } chunk)
{
    Console.WriteLine(chunk.Text);
}
```

### Voice Cloning
```csharp
//// Clone a voice from an audio sample using instant voice cloning.
byte[] voiceSample = await File.ReadAllBytesAsync("voice-sample.wav");

AddVoiceIVCResponseModel response = await client.Voices.CreateVoicesAddAsync(
    name: "My Cloned Voice",
    files: [voiceSample],
    description: "A cloned voice from my audio sample",
    removeBackgroundNoise: true);

Console.WriteLine($"Cloned voice ID: {response.VoiceId}");
```

### Realtime Speech-to-Text (WebSocket)
```csharp
//// Stream audio to ElevenLabs for realtime transcription via WebSocket.
await using var session = await client.ConnectRealtimeAsync(
    new RealtimeSpeechToTextOptions
    {
        AudioFormat = RealtimeAudioFormat.Pcm16000,
        CommitStrategy = RealtimeCommitStrategy.Vad,
    });

// Send audio chunks (e.g., from a microphone)
await session.SendAudioChunkAsync(
    audioBytes: pcmAudioChunk,
    sampleRate: 16000,
    commit: false);

// Read transcription events
await foreach (var evt in session.ReadEventsAsync())
{
    switch (evt)
    {
        case SessionStartedEvent started:
            Console.WriteLine($"Session started: {started.SessionId}");
            break;
        case PartialTranscriptEvent partial:
            Console.Write(partial.Text);
            break;
        case CommittedTranscriptEvent committed:
            Console.WriteLine($"\nFinal: {committed.Text}");
            break;
        case ErrorEvent error:
            Console.WriteLine($"Error: {error.ErrorType} - {error.Error}");
            break;
    }
}
```

## Support

Priority place for bugs: https://github.com/tryAGI/ElevenLabs/issues
Priority place for ideas and general questions: https://github.com/tryAGI/ElevenLabs/discussions
Discord: https://discord.gg/Ca2xhfBf3v

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).

![CodeRabbit logo](https://opengraph.githubassets.com/1c51002d7d0bbe0c4fd72ff8f2e58192702f73a7037102f77e4dbb98ac00ea8f/marketplace/coderabbitai)

This project is supported by CodeRabbit through the [Open Source Support Program](https://github.com/marketplace/coderabbitai).
