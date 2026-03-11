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
}
