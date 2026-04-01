# Realtime Speech to Text

Open a realtime transcription session, stream PCM audio in chunks, and read transcript events until a final transcript arrives.

This example assumes `using ElevenLabs;` is in scope and `apiKey` contains your ElevenLabs API key.

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