using System.Text;

namespace ElevenLabs.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void Parse_SessionStarted_MapsConfig()
    {
        var json = """
        {
          "message_type": "session_started",
          "session_id": "session-123",
          "config": {
            "sample_rate": 24000,
            "audio_format": "pcm_24000",
            "language_code": "en",
            "commit_strategy": "vad",
            "vad_silence_threshold_secs": 1.5,
            "vad_threshold": 0.4,
            "min_speech_duration_ms": 100,
            "min_silence_duration_ms": 200,
            "model_id": "scribe_v1",
            "enable_logging": true,
            "include_timestamps": true,
            "include_language_detection": false
          }
        }
        """;

        var evt = RealtimeEventParser.Parse(json);
        evt.Should().BeOfType<SessionStartedEvent>();
        var started = (SessionStartedEvent)evt;

        started.SessionId.Should().Be("session-123");
        started.Config.SampleRate.Should().Be(24000);
        started.Config.AudioFormat.Should().Be(RealtimeAudioFormat.Pcm24000);
        started.Config.LanguageCode.Should().Be("en");
        started.Config.CommitStrategy.Should().Be(RealtimeCommitStrategy.Vad);
        started.Config.VadSilenceThresholdSeconds.Should().Be(1.5);
        started.Config.VadThreshold.Should().Be(0.4);
        started.Config.MinSpeechDurationMs.Should().Be(100);
        started.Config.MinSilenceDurationMs.Should().Be(200);
        started.Config.ModelId.Should().Be("scribe_v1");
        started.Config.EnableLogging.Should().Be(true);
        started.Config.IncludeTimestamps.Should().Be(true);
        started.Config.IncludeLanguageDetection.Should().Be(false);
    }

    [TestMethod]
    public void Parse_PartialTranscript_ParsesText()
    {
        var json = """
        { "message_type": "partial_transcript", "text": "hello" }
        """;

        var evt = RealtimeEventParser.Parse(json);
        evt.Should().BeOfType<PartialTranscriptEvent>();
        ((PartialTranscriptEvent)evt).Text.Should().Be("hello");
    }

    [TestMethod]
    public void Parse_CommittedTranscript_ParsesText()
    {
        var json = """
        { "message_type": "committed_transcript", "text": "done" }
        """;

        var evt = RealtimeEventParser.Parse(json);
        evt.Should().BeOfType<CommittedTranscriptEvent>();
        ((CommittedTranscriptEvent)evt).Text.Should().Be("done");
    }

    [TestMethod]
    public void Parse_CommittedTranscriptWithTimestamps_ParsesWords()
    {
        var json = """
        {
          "message_type": "committed_transcript_with_timestamps",
          "text": "hello",
          "language_code": "en",
          "words": [
            { "text": "hello", "start": 0.0, "end": 0.5, "type": "word" },
            { "text": " ", "start": 0.5, "end": 0.6, "type": "spacing" }
          ]
        }
        """;

        var evt = RealtimeEventParser.Parse(json);
        evt.Should().BeOfType<CommittedTranscriptWithTimestampsEvent>();
        var committed = (CommittedTranscriptWithTimestampsEvent)evt;

        committed.Text.Should().Be("hello");
        committed.LanguageCode.Should().Be("en");
        committed.Words.Should().NotBeNull();
        committed.Words!.Count.Should().Be(2);
        committed.Words[0].Type.Should().Be(TranscriptionWordType.Word);
        committed.Words[1].Type.Should().Be(TranscriptionWordType.Spacing);
    }

    [TestMethod]
    public void Parse_ErrorEvent_ParsesError()
    {
        var json = """
        { "message_type": "auth_error", "error": "bad key" }
        """;

        var evt = RealtimeEventParser.Parse(json);
        evt.Should().BeOfType<ErrorEvent>();
        var error = (ErrorEvent)evt;

        error.ErrorType.Should().Be("auth_error");
        error.Error.Should().Be("bad key");
    }

    [TestMethod]
    public void Parse_UnknownEvent_ReturnsUnknown()
    {
        var json = """
        { "foo": "bar" }
        """;

        var evt = RealtimeEventParser.Parse(json);
        evt.Should().BeOfType<UnknownEvent>();
    }

    ////
    //// Integration tests that call the real ElevenLabs Realtime API.
    //// Requires ELEVENLABS_API_KEY environment variable.
    ////

    [TestMethod]
    public async Task RealtimeSpeechToText_WithWavSample_ReturnsCommittedTranscript()
    {
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
                throw new InvalidOperationException($"ElevenLabs error: {error.ErrorType} - {error.Error}");
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
                    throw new InvalidOperationException($"ElevenLabs error: {error.ErrorType} - {error.Error}");
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
