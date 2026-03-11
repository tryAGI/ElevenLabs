namespace ElevenLabs;

/// <summary>
/// Options for opening a realtime speech-to-text session.
/// </summary>
public sealed record RealtimeSpeechToTextOptions
{
    /// <summary>
    /// Model ID to use for transcription.
    /// </summary>
    public string? ModelId { get; init; }

    /// <summary>
    /// Single-use token for client-side transcription.
    /// </summary>
    public string? Token { get; init; }

    /// <summary>
    /// Include word-level timestamps in committed transcripts.
    /// </summary>
    public bool IncludeTimestamps { get; init; }

    /// <summary>
    /// Include language detection in committed transcripts.
    /// </summary>
    public bool IncludeLanguageDetection { get; init; }

    /// <summary>
    /// Audio format for input audio.
    /// </summary>
    public RealtimeAudioFormat AudioFormat { get; init; } = RealtimeAudioFormat.Pcm16000;

    /// <summary>
    /// Language code in ISO 639-1 or ISO 639-3 format.
    /// </summary>
    public string? LanguageCode { get; init; }

    /// <summary>
    /// Commit strategy for transcription.
    /// </summary>
    public RealtimeCommitStrategy CommitStrategy { get; init; } = RealtimeCommitStrategy.Manual;

    /// <summary>
    /// Silence threshold in seconds for VAD-based commits.
    /// </summary>
    public double? VadSilenceThresholdSeconds { get; init; }

    /// <summary>
    /// Voice activity detection threshold.
    /// </summary>
    public double? VadThreshold { get; init; }

    /// <summary>
    /// Minimum speech duration in milliseconds.
    /// </summary>
    public int? MinSpeechDurationMs { get; init; }

    /// <summary>
    /// Minimum silence duration in milliseconds.
    /// </summary>
    public int? MinSilenceDurationMs { get; init; }

    /// <summary>
    /// Enable or disable logging on ElevenLabs side.
    /// </summary>
    public bool? EnableLogging { get; init; }
}
