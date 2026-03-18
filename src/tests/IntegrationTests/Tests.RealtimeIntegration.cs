using System.Text;

namespace ElevenLabs.IntegrationTests;

public partial class Tests
{
    private static bool RunManualTests =>
        Environment.GetEnvironmentVariable("RUN_MANUAL_TESTS") == "1";

    [TestMethod]
    public async Task RealtimeSpeechToText_WithWavSample_ReturnsCommittedTranscript()
    {
        if (!RunManualTests)
        {
            Assert.Inconclusive("Set RUN_MANUAL_TESTS=1 to run realtime integration tests.");
        }

        using var client = GetAuthenticatedClient();
        using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));

        await using var session = await client.ConnectRealtimeAsync(
            new RealtimeSpeechToTextOptions
            {
                AudioFormat = RealtimeAudioFormat.Pcm24000,
                CommitStrategy = RealtimeCommitStrategy.Manual,
            },
            cancellationToken: cts.Token);

        var started = await WaitForSessionStartedAsync(session, cts.Token);
        started.Should().NotBeNull("Expected session_started event from ElevenLabs.");

        var wavBytes = await File.ReadAllBytesAsync(
            Path.Combine(AppContext.BaseDirectory, "Resources", "hello-in-russian-24k-pcm16.wav"),
            cts.Token);
        var (pcm, sampleRate, channels) = ReadWavPcm16(wavBytes);

        sampleRate.Should().Be(24000);
        channels.Should().Be(1);

        const int samplesPerChunk = 12000; // 0.5s at 24kHz
        for (var offset = 0; offset < pcm.Length; offset += samplesPerChunk)
        {
            var count = Math.Min(samplesPerChunk, pcm.Length - offset);
            var bytes = new byte[count * 2];
            Buffer.BlockCopy(pcm, offset * 2, bytes, 0, bytes.Length);

            var commit = offset + count >= pcm.Length;
            await session.SendAudioChunkAsync(bytes, sampleRate, commit, cancellationToken: cts.Token);
        }

        var transcript = await WaitForCommittedTranscriptAsync(session, cts.Token);
        transcript.Should().NotBeNullOrWhiteSpace("Expected committed transcript from ElevenLabs.");
    }

    [TestMethod]
    public async Task TextToSpeech_WithDefaultVoice_ReturnsAudio()
    {
        if (!RunManualTests)
        {
            Assert.Inconclusive("Set RUN_MANUAL_TESTS=1 to run TTS integration tests.");
        }

        var voiceId = Environment.GetEnvironmentVariable("ELEVENLABS_TEST_VOICE_ID");
        if (string.IsNullOrWhiteSpace(voiceId))
        {
            voiceId = "xyu8HSCv1JYrhLx4m8UG";
        }

        using var client = GetAuthenticatedClient();
        using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));

        var audioBytes = await client.TextToSpeech.CreateTextToSpeechByVoiceIdAsync(
            voiceId: voiceId,
            request: new BodyTextToSpeechFull
            {
                Text = "This is an ElevenLabs SDK text to speech integration test.",
                ModelId = "eleven_multilingual_v2",
            },
            outputFormat: TextToSpeechFullOutputFormat.Mp32205032,
            enableLogging: true,
            cancellationToken: cts.Token);

        audioBytes.Length.Should().BeGreaterThan(0);
    }

    private static async Task<SessionStartedEvent?> WaitForSessionStartedAsync(
        RealtimeSpeechToTextSession session,
        CancellationToken cancellationToken)
    {
        var deadline = DateTime.UtcNow.AddSeconds(10);
        while (DateTime.UtcNow < deadline)
        {
            var evt = await session.ReceiveEventAsync(cancellationToken);
            if (evt == null)
            {
                return null;
            }

            if (evt is SessionStartedEvent started)
            {
                return started;
            }

            if (evt is ErrorEvent error)
            {
                throw new InvalidOperationException(
                    $"ElevenLabs error: {error.ErrorType} - {error.Error}");
            }
        }

        return null;
    }

    private static async Task<string?> WaitForCommittedTranscriptAsync(
        RealtimeSpeechToTextSession session,
        CancellationToken cancellationToken)
    {
        var deadline = DateTime.UtcNow.AddSeconds(20);
        while (DateTime.UtcNow < deadline)
        {
            var evt = await session.ReceiveEventAsync(cancellationToken);
            if (evt == null)
            {
                return null;
            }

            switch (evt)
            {
                case CommittedTranscriptEvent committed:
                    return committed.Text;
                case CommittedTranscriptWithTimestampsEvent committedWithTimestamps:
                    return committedWithTimestamps.Text;
                case ErrorEvent error:
                    throw new InvalidOperationException(
                        $"ElevenLabs error: {error.ErrorType} - {error.Error}");
            }
        }

        return null;
    }

    private static (short[] samples, int sampleRate, int channels) ReadWavPcm16(ReadOnlySpan<byte> data)
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
        ushort channels = 1;
        int sampleRate = 16000;
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
                channels = br.ReadUInt16();
                sampleRate = br.ReadInt32();
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
                return (samples, sampleRate, channels);
            }
            else
            {
                if (size > 0)
                {
                    br.ReadBytes(size);
                }
            }
        }

        throw new InvalidDataException("WAV data chunk not found");
    }
}
