<div class="docs-hero">
  <h1>ElevenLabs</h1>
  <p class="docs-hero-lead">.NET SDK for ElevenLabs text to speech, speech to text, voice cloning, sound generation, and realtime transcription.</p>
  <div class="docs-badge-row">
    <a href="https://www.nuget.org/packages/ElevenLabs/"><img alt="Nuget package" src="https://img.shields.io/nuget/vpre/ElevenLabs"></a>
    <a href="https://github.com/tryAGI/ElevenLabs/actions/workflows/dotnet.yml"><img alt="dotnet" src="https://github.com/tryAGI/ElevenLabs/actions/workflows/dotnet.yml/badge.svg?branch=main"></a>
    <a href="https://github.com/tryAGI/ElevenLabs/blob/main/LICENSE.txt"><img alt="License: MIT" src="https://img.shields.io/github/license/tryAGI/ElevenLabs"></a>
    <a href="https://discord.gg/Ca2xhfBf3v"><img alt="Discord" src="https://img.shields.io/discord/1115206893015662663?label=Discord&amp;logo=discord&amp;logoColor=white&amp;color=d82679"></a>
  </div>
  <div class="docs-hero-actions">
    <a href="#usage">Get started</a>
    <a href="#list-available-voices">Open examples</a>
  </div>
</div>

<div class="docs-feature-grid">
  <div class="docs-feature-card">
    <h3>Speech and audio coverage</h3>
    <p>Use one client for text to speech, speech to text, sound generation, and voice cloning workflows.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Realtime transcription</h3>
    <p>Stream PCM audio over WebSocket and consume transcript events as they arrive from the realtime API.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Modern .NET</h3>
    <p>Generated with AutoSDK and shaped for current .NET practices including nullability, trimming, and NativeAOT awareness.</p>
  </div>
  <div class="docs-feature-card">
    <h3>MEAI integration</h3>
    <p>Implements <code>ISpeechToTextClient</code> so the SDK plugs into <code>Microsoft.Extensions.AI</code> abstractions directly.</p>
  </div>
</div>

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

<div class="docs-callout">
  <strong>Examples stay source-of-truth driven.</strong> The examples below are generated from the integration test suite, so the README, docs site, and executable samples stay aligned.
</div>

<!-- EXAMPLES:START -->
### List Available Voices
Fetch all voices available to the authenticated account and print each voice name and ID so you can pick one for text-to-speech requests.

```csharp
using var client = new ElevenLabsClient(apiKey);

// Fetch all voices for the authenticated workspace.
GetVoicesResponseModel response = await client.Voices.GetAllAsync();

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
var voices = await client.Voices.GetAllAsync();
var voice = voices.Voices[0];
const string text = "Hello, world! This is a test of the ElevenLabs text-to-speech API.";

Console.WriteLine($"Using voice: {voice.Name} ({voice.VoiceId})");
Console.WriteLine($"Input text: {text}");

// Generate speech audio.
byte[] audioBytes = await client.TextToSpeech.ConvertAsync(
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
var voices = await client.Voices.GetAllAsync();
var voice = voices.Voices[0];
const string text = "This audio is streamed for low-latency playback.";

Console.WriteLine($"Using voice: {voice.Name} ({voice.VoiceId})");
Console.WriteLine($"Input text: {text}");

// Request streaming speech audio.
using var streamedAudio = await client.TextToSpeech.StreamAsync(
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
var voices = await client.Voices.GetAllAsync();
var voice = voices.Voices[0];
const string text = "Hello, this has timestamps.";

Console.WriteLine($"Using voice: {voice.Name} ({voice.VoiceId})");
Console.WriteLine($"Input text: {text}");

// Request streamed speech audio with timing metadata.
StreamingAudioChunkWithTimestampsResponseModel? firstChunk = null;
int chunkCount = 0;

await foreach (var chunk in client.TextToSpeech.StreamWithTimestampsAsync(
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
byte[] soundBytes = await client.TextToSoundEffects.ConvertAsync(
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
var transcription = await client.SpeechToText2.ConvertAsync(
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

### Voice Cloning
Create an instant voice clone from an audio sample, print the new voice ID, and delete the test voice afterwards.

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
```

### Realtime STT (Generated Client)
Use the auto-generated ElevenLabsRealtimeClient to stream audio and receive typed ServerEvent events via the discriminated union pattern.

```csharp
var apiKey =
    Environment.GetEnvironmentVariable("ELEVENLABS_API_KEY") is { Length: > 0 } apiKeyValue
        ? apiKeyValue
        : throw new AssertInconclusiveException("ELEVENLABS_API_KEY environment variable is not found.");

// Create the generated realtime client and connect with the API key in the URL.
using var client = new ElevenLabsRealtimeClient();
await client.ConnectAsync(
    new Uri($"wss://api.elevenlabs.io/v1/speech-to-text/realtime?xi_api_key={apiKey}"));

// Load a WAV file and extract raw PCM16 audio bytes.
byte[] wavBytes = await File.ReadAllBytesAsync(
    Path.Combine(AppContext.BaseDirectory, "Resources", "hello-in-russian-24k-pcm16.wav"));
var (pcmSamples, sampleRate, _) = ReadWavPcm16(wavBytes);

// Send audio chunks using the typed SendInputAudioChunkAsync method.
const int samplesPerChunk = 12000;
for (var offset = 0; offset < pcmSamples.Length; offset += samplesPerChunk)
{
    var count = Math.Min(samplesPerChunk, pcmSamples.Length - offset);
    var bytes = new byte[count * 2];
    Buffer.BlockCopy(pcmSamples, offset * 2, bytes, 0, bytes.Length);

    var isLastChunk = offset + count >= pcmSamples.Length;
    await client.SendInputAudioChunkAsync(new InputAudioChunkPayload
    {
        AudioBase64 = Convert.ToBase64String(bytes),
        SampleRate = sampleRate,
        Commit = isLastChunk,
    });
}

// Receive typed server events via the discriminated ServerEvent union.
using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));
var receivedSessionStarted = false;
string? sessionId = null;
string? transcript = null;

await foreach (var serverEvent in client.ReceiveUpdatesAsync(cts.Token))
{
    if (serverEvent.IsSessionStarted)
    {
        receivedSessionStarted = true;
        sessionId = serverEvent.SessionStarted?.SessionId;
        Console.WriteLine($"Session started: {sessionId}");
    }
    else if (serverEvent.IsPartialTranscript)
    {
        Console.WriteLine($"Partial: {serverEvent.PartialTranscript?.Text}");
    }
    else if (serverEvent.IsCommittedTranscript)
    {
        transcript = serverEvent.CommittedTranscript?.Text;
        Console.WriteLine($"Final: {transcript}");
        break;
    }
    else if (serverEvent.IsCommittedTranscriptWithTimestamps)
    {
        transcript = serverEvent.CommittedTranscriptWithTimestamps?.Text;
        Console.WriteLine($"Final (with timestamps): {transcript}");
        break;
    }
    else if (serverEvent.IsError)
    {
    }
}
```
<!-- EXAMPLES:END -->

## Support

<div class="docs-card-grid">
  <div class="docs-card">
    <h3>Bugs</h3>
    <p>Open an issue in <a href="https://github.com/tryAGI/ElevenLabs/issues">tryAGI/ElevenLabs</a>.</p>
  </div>
  <div class="docs-card">
    <h3>Ideas and questions</h3>
    <p>Use <a href="https://github.com/tryAGI/ElevenLabs/discussions">GitHub Discussions</a> for usage questions and design discussion.</p>
  </div>
  <div class="docs-card">
    <h3>Community</h3>
    <p>Join the <a href="https://discord.gg/Ca2xhfBf3v">tryAGI Discord</a> for broader SDK discussion.</p>
  </div>
</div>

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
