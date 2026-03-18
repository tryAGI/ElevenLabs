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

### Microsoft.Extensions.AI

The SDK implements [`ISpeechToTextClient`](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.ai.ispeechtotextclient):
```csharp
using ElevenLabs;
using Microsoft.Extensions.AI;

ISpeechToTextClient speechClient = new ElevenLabsClient(apiKey);

await using var audioStream = File.OpenRead("recording.wav");
var response = await speechClient.GetTextAsync(audioStream);

Console.WriteLine(response.Text);
```

<!-- EXAMPLES:START -->
### List Available Voices
Fetch all voices available to the authenticated account and print each voice name and ID so you can pick one for text-to-speech requests.

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

### Text to Speech
Pick a voice from the available catalog, synthesize text with it, and save the generated audio to disk.

```csharp
using var client = new ElevenLabsClient(apiKey);

// Choose a voice to synthesize with.
var voices = await client.Voices.GetVoicesAsync();
var voice = voices.Voices[0];
const string text = "Hello, world! This is a test of the ElevenLabs text-to-speech API.";

Console.WriteLine($"Using voice: {voice.Name} ({voice.VoiceId})");
Console.WriteLine($"Input text: {text}");

// Generate speech audio.
byte[] audioBytes = await client.TextToSpeech.CreateTextToSpeechByVoiceIdAsync(
    voiceId: voice.VoiceId,
    text: text);

// Persist the result to a local file.
await File.WriteAllBytesAsync("output.mp3", audioBytes);
Console.WriteLine($"Saved {audioBytes.Length} bytes to output.mp3");
```

### Streaming Text to Speech
Pick a voice from the available catalog, request a streaming text-to-speech response for low-latency playback, and save the returned audio stream.

```csharp
using var client = new ElevenLabsClient(apiKey);

// Choose a voice to synthesize with.
var voices = await client.Voices.GetVoicesAsync();
var voice = voices.Voices[0];
const string text = "This audio is streamed for low-latency playback.";

Console.WriteLine($"Using voice: {voice.Name} ({voice.VoiceId})");
Console.WriteLine($"Input text: {text}");

// Request streaming speech audio.
using var streamedAudio = await client.TextToSpeech.CreateTextToSpeechByVoiceIdStreamAsync(
    voiceId: voice.VoiceId,
    text: text,
    modelId: "eleven_multilingual_v2",
    outputFormat: TextToSpeechStreamOutputFormat.Mp32205032);

// Persist the result to a local file.
await using var output = File.Create("streamed-output.mp3");
await streamedAudio.CopyToAsync(output);
Console.WriteLine($"Saved {output.Length} bytes to streamed-output.mp3");
```

### Streaming Text to Speech with Timestamps
Pick a voice from the available catalog, then stream synthesized audio together with character-level timing information for subtitles, captions, or lip-sync.

```csharp
using var client = new ElevenLabsClient(apiKey);

// Choose a voice to synthesize with.
var voices = await client.Voices.GetVoicesAsync();
var voice = voices.Voices[0];
const string text = "Hello, this has timestamps.";

Console.WriteLine($"Using voice: {voice.Name} ({voice.VoiceId})");
Console.WriteLine($"Input text: {text}");

// Request streamed speech audio with timing metadata.
StreamingAudioChunkWithTimestampsResponseModel? firstChunk = null;
int chunkCount = 0;

await foreach (var chunk in client.TextToSpeech.CreateTextToSpeechByVoiceIdStreamWithTimestampsAsync(
                   voiceId: voice.VoiceId,
                   text: text,
                   modelId: "eleven_multilingual_v2",
                   outputFormat: TextToSpeechStreamWithTimestampsOutputFormat.Mp32205032))
{
    firstChunk ??= chunk;
    chunkCount++;

    // Inspect the alignment information when it is present.
    if (chunkCount == 1 && chunk.Alignment is { } alignment)
    {
        for (int i = 0; i < alignment.Characters?.Count; i++)
        {
            Console.WriteLine($"'{alignment.Characters[i]}' " +
                              $"{alignment.CharacterStartTimesSeconds?[i]:F3}s - " +
                              $"{alignment.CharacterEndTimesSeconds?[i]:F3}s");
        }
    }
}
```

### Sound Generation
Generate a short sound effect from a text prompt and save the returned audio bytes.

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

### Speech to Text from a File
Transcribe a WAV file from disk and print the returned transcript text.

```csharp
using var client = new ElevenLabsClient(apiKey);

// Load an audio file to transcribe.
byte[] audioFile = await File.ReadAllBytesAsync(
    Path.Combine(AppContext.BaseDirectory, "Resources", "hello-in-russian-24k-pcm16.wav"));

// Submit the file for transcription.
var transcription = await client.SpeechToText.CreateSpeechToTextAsync(
    modelId: BodySpeechToTextV1SpeechToTextPostModelId.ScribeV1,
    file: audioFile,
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

### Voice Cloning
Create an instant voice clone from an audio sample, print the new voice ID, and delete the test voice afterwards.

```csharp
using var client = new ElevenLabsClient(apiKey);

// Load a voice sample from disk.
byte[] voiceSample = await File.ReadAllBytesAsync(
    Path.Combine(AppContext.BaseDirectory, "Resources", "hello-in-russian-24k-pcm16.wav"));

// Create the cloned voice.
AddVoiceIVCResponseModel response = await client.Voices.CreateVoicesAddAsync(
    name: $"Test Cloned Voice {Guid.NewGuid():N}",
    files: [voiceSample],
    description: "A cloned voice from my audio sample",
    removeBackgroundNoise: true);

Console.WriteLine($"Cloned voice ID: {response.VoiceId}");

// Clean up the test voice once the example has succeeded.
await client.Voices.DeleteVoicesByVoiceIdAsync(response.VoiceId);
```

### Realtime Speech to Text
Open a realtime transcription session, stream PCM audio in chunks, and read transcript events until a final transcript arrives.

```csharp
using var client = new ElevenLabsClient(apiKey);
using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));

// Open a realtime speech-to-text session.
await using var session = await client.ConnectRealtimeAsync(
    new RealtimeSpeechToTextOptions
    {
        AudioFormat = RealtimeAudioFormat.Pcm24000,
        CommitStrategy = RealtimeCommitStrategy.Manual,
    },
    cancellationToken: cts.Token);

// Load a WAV file and convert it to PCM16 samples.
byte[] wavBytes = await File.ReadAllBytesAsync(
    Path.Combine(AppContext.BaseDirectory, "Resources", "hello-in-russian-24k-pcm16.wav"),
    cts.Token);
var (pcm, sampleRate, channels) = ReadWavPcm16(wavBytes);

// Send the audio in 0.5 second chunks and commit the final chunk.
const int samplesPerChunk = 12000;
for (var offset = 0; offset < pcm.Length; offset += samplesPerChunk)
{
    var count = Math.Min(samplesPerChunk, pcm.Length - offset);
    var bytes = new byte[count * 2];
    Buffer.BlockCopy(pcm, offset * 2, bytes, 0, bytes.Length);

    var commit = offset + count >= pcm.Length;
    await session.SendAudioChunkAsync(bytes, sampleRate, commit, cancellationToken: cts.Token);
}

// Read events until the service returns a final transcript.
string? transcript = null;
await foreach (var evt in session.ReadEventsAsync(cts.Token))
{
    switch (evt)
    {
        case SessionStartedEvent started:
            Console.WriteLine($"Session started: {started.SessionId}");
            break;
        case PartialTranscriptEvent partial:
            Console.WriteLine($"Partial: {partial.Text}");
            break;
        case CommittedTranscriptEvent committed:
            transcript = committed.Text;
            Console.WriteLine($"Final: {committed.Text}");
            break;
        case CommittedTranscriptWithTimestampsEvent committedWithTimestamps:
            transcript = committedWithTimestamps.Text;
            Console.WriteLine($"Final: {committedWithTimestamps.Text}");
            break;
        case ErrorEvent error:
            throw new InvalidOperationException($"ElevenLabs error: {error.ErrorType} - {error.Error}");
    }

    if (!string.IsNullOrWhiteSpace(transcript))
    {
        break;
    }
}

static (short[] samples, int sampleRate, int channels) ReadWavPcm16(ReadOnlySpan<byte> data)
{
    using var ms = new MemoryStream(data.ToArray(), writable: false);
    using var br = new BinaryReader(ms, Encoding.UTF8, leaveOpen: true);

    var riff = new string(br.ReadChars(4));
    if (riff != "RIFF")
    {
        throw new InvalidDataException("Not RIFF");
    }

    br.ReadInt32();
    var wave = new string(br.ReadChars(4));
    if (wave != "WAVE")
    {
        throw new InvalidDataException("Not WAVE");
    }

    ushort audioFormat = 1;
    ushort localChannels = 1;
    int localSampleRate = 16000;
    ushort bitsPerSample = 16;

    while (ms.Position < ms.Length)
    {
        if (ms.Length - ms.Position < 8)
        {
            break;
        }

        var id = new string(br.ReadChars(4));
        int size = br.ReadInt32();
        long next = ms.Position + size;

        if (id == "fmt ")
        {
            if (size < 16)
            {
                throw new InvalidDataException("Bad fmt chunk");
            }

            audioFormat = br.ReadUInt16();
            localChannels = br.ReadUInt16();
            localSampleRate = br.ReadInt32();
            br.ReadInt32();
            br.ReadUInt16();
            bitsPerSample = br.ReadUInt16();

            if (next > ms.Position)
            {
                br.ReadBytes((int)(next - ms.Position));
            }
        }
        else if (id == "data")
        {
            if (audioFormat != 1 || bitsPerSample != 16)
            {
                throw new InvalidDataException("Expected PCM16");
            }

            var dataSize = size == 0 ? (int)(ms.Length - ms.Position) : size;
            var dataBytes = br.ReadBytes(dataSize);
            var samples = new short[dataBytes.Length / 2];
            Buffer.BlockCopy(dataBytes, 0, samples, 0, dataBytes.Length);
            return (samples, localSampleRate, localChannels);
        }
        else if (size > 0)
        {
            br.ReadBytes(size);
        }
    }

    throw new InvalidDataException("WAV data chunk not found");
}
```
<!-- EXAMPLES:END -->

## Support

Priority place for bugs: https://github.com/tryAGI/ElevenLabs/issues
Priority place for ideas and general questions: https://github.com/tryAGI/ElevenLabs/discussions
Discord: https://discord.gg/Ca2xhfBf3v

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).

![CodeRabbit logo](https://opengraph.githubassets.com/1c51002d7d0bbe0c4fd72ff8f2e58192702f73a7037102f77e4dbb98ac00ea8f/marketplace/coderabbitai)

This project is supported by CodeRabbit through the [Open Source Support Program](https://github.com/marketplace/coderabbitai).
