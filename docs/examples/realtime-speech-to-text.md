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