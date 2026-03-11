using System.Text.Json;
using System.Text.Json.Serialization;

namespace ElevenLabs;

/// <summary>
/// Outbound audio chunk message.
/// </summary>
internal sealed record InputAudioChunk
{
    [JsonPropertyName("message_type")]
    public string MessageType { get; init; } = "input_audio_chunk";

    [JsonPropertyName("audio_base_64")]
    public required string AudioBase64 { get; init; }

    [JsonPropertyName("commit")]
    public required bool Commit { get; init; }

    [JsonPropertyName("sample_rate")]
    public required int SampleRate { get; init; }

    [JsonPropertyName("previous_text")]
    public string? PreviousText { get; init; }
}

/// <summary>
/// Base type for realtime events returned by ElevenLabs.
/// </summary>
/// <param name="MessageType">The message type identifier.</param>
public abstract record RealtimeSpeechToTextEvent(string MessageType);

/// <summary>
/// Event received when a realtime session is established.
/// </summary>
/// <param name="SessionId">The session identifier.</param>
/// <param name="Config">The negotiated session configuration.</param>
public sealed record SessionStartedEvent(string SessionId, SessionConfig Config)
    : RealtimeSpeechToTextEvent("session_started");

/// <summary>
/// Event containing a partial (in-progress) transcript.
/// </summary>
/// <param name="Text">The partial transcript text.</param>
public sealed record PartialTranscriptEvent(string Text)
    : RealtimeSpeechToTextEvent("partial_transcript");

/// <summary>
/// Event containing a committed (final) transcript.
/// </summary>
/// <param name="Text">The committed transcript text.</param>
public sealed record CommittedTranscriptEvent(string Text)
    : RealtimeSpeechToTextEvent("committed_transcript");

/// <summary>
/// Event containing a committed transcript with word-level timestamps.
/// </summary>
/// <param name="Text">The committed transcript text.</param>
/// <param name="LanguageCode">The detected language code, if available.</param>
/// <param name="Words">Word-level timing information.</param>
public sealed record CommittedTranscriptWithTimestampsEvent(
        string Text,
        string? LanguageCode,
        IReadOnlyList<TranscriptionWord>? Words)
    : RealtimeSpeechToTextEvent("committed_transcript_with_timestamps");

/// <summary>
/// Event indicating an error from the ElevenLabs service.
/// </summary>
/// <param name="ErrorType">The error type identifier.</param>
/// <param name="Error">The error message.</param>
public sealed record ErrorEvent(string ErrorType, string Error)
    : RealtimeSpeechToTextEvent(ErrorType);

/// <summary>
/// Event for unrecognized message types.
/// </summary>
/// <param name="RawJson">The raw JSON string of the unknown event.</param>
public sealed record UnknownEvent(string RawJson)
    : RealtimeSpeechToTextEvent("unknown");

/// <summary>
/// Negotiated configuration for a realtime session.
/// </summary>
/// <param name="SampleRate">The sample rate in Hz.</param>
/// <param name="AudioFormat">The audio format.</param>
/// <param name="LanguageCode">The language code.</param>
/// <param name="CommitStrategy">The commit strategy.</param>
/// <param name="VadSilenceThresholdSeconds">VAD silence threshold in seconds.</param>
/// <param name="VadThreshold">Voice activity detection threshold.</param>
/// <param name="MinSpeechDurationMs">Minimum speech duration in milliseconds.</param>
/// <param name="MinSilenceDurationMs">Minimum silence duration in milliseconds.</param>
/// <param name="ModelId">The model ID.</param>
/// <param name="EnableLogging">Whether logging is enabled.</param>
/// <param name="IncludeTimestamps">Whether timestamps are included.</param>
/// <param name="IncludeLanguageDetection">Whether language detection is included.</param>
public sealed record SessionConfig(
    int? SampleRate,
    RealtimeAudioFormat? AudioFormat,
    string? LanguageCode,
    RealtimeCommitStrategy? CommitStrategy,
    double? VadSilenceThresholdSeconds,
    double? VadThreshold,
    int? MinSpeechDurationMs,
    int? MinSilenceDurationMs,
    string? ModelId,
    bool? EnableLogging,
    bool? IncludeTimestamps,
    bool? IncludeLanguageDetection);

/// <summary>
/// Type of a transcription word element.
/// </summary>
public enum TranscriptionWordType
{
    /// <summary>A spoken word.</summary>
    Word,

    /// <summary>Spacing between words.</summary>
    Spacing
}

/// <summary>
/// A word with timing information from a transcription.
/// </summary>
/// <param name="Text">The word text.</param>
/// <param name="Start">Start time in seconds.</param>
/// <param name="End">End time in seconds.</param>
/// <param name="Type">Whether this is a word or spacing.</param>
/// <param name="SpeakerId">Optional speaker identifier.</param>
/// <param name="LogProb">Optional log probability.</param>
/// <param name="Characters">Optional character-level breakdown.</param>
public sealed record TranscriptionWord(
    string Text,
    double Start,
    double End,
    TranscriptionWordType Type,
    string? SpeakerId,
    double? LogProb,
    IReadOnlyList<string>? Characters);

/// <summary>
/// Parses JSON messages from the ElevenLabs realtime WebSocket into typed events.
/// </summary>
public static class RealtimeEventParser
{
    private static readonly HashSet<string> ErrorTypes =
    [
        "error",
        "auth_error",
        "quota_exceeded",
        "commit_throttled",
        "unaccepted_terms",
        "rate_limited",
        "queue_overflow",
        "resource_exhausted",
        "session_time_limit_exceeded",
        "input_error",
        "chunk_size_exceeded",
        "insufficient_audio_activity",
        "transcriber_error"
    ];

    /// <summary>
    /// Parses a JSON string into a typed <see cref="RealtimeSpeechToTextEvent"/>.
    /// </summary>
    /// <param name="json">The raw JSON message from the WebSocket.</param>
    /// <returns>A typed event instance.</returns>
    public static RealtimeSpeechToTextEvent Parse(string json)
    {
        using var doc = JsonDocument.Parse(json);
        if (!doc.RootElement.TryGetProperty("message_type", out var typeElement))
        {
            return new UnknownEvent(json);
        }

        var type = typeElement.GetString();
        if (string.IsNullOrWhiteSpace(type))
        {
            return new UnknownEvent(json);
        }

        switch (type)
        {
            case "session_started":
                return ParseSessionStarted(doc.RootElement);
            case "partial_transcript":
                return new PartialTranscriptEvent(
                    doc.RootElement.GetProperty("text").GetString() ?? string.Empty);
            case "committed_transcript":
                return new CommittedTranscriptEvent(
                    doc.RootElement.GetProperty("text").GetString() ?? string.Empty);
            case "committed_transcript_with_timestamps":
                return ParseCommittedTranscriptWithTimestamps(doc.RootElement);
            default:
                if (ErrorTypes.Contains(type))
                {
                    var error = doc.RootElement.TryGetProperty("error", out var errorElement)
                        ? errorElement.GetString() ?? string.Empty
                        : string.Empty;
                    return new ErrorEvent(type, error);
                }

                return new UnknownEvent(json);
        }
    }

    private static SessionStartedEvent ParseSessionStarted(JsonElement root)
    {
        var sessionId = root.TryGetProperty("session_id", out var sessionIdElement)
            ? sessionIdElement.GetString() ?? string.Empty
            : string.Empty;

        SessionConfig config = new(
            SampleRate: null,
            AudioFormat: null,
            LanguageCode: null,
            CommitStrategy: null,
            VadSilenceThresholdSeconds: null,
            VadThreshold: null,
            MinSpeechDurationMs: null,
            MinSilenceDurationMs: null,
            ModelId: null,
            EnableLogging: null,
            IncludeTimestamps: null,
            IncludeLanguageDetection: null);

        if (root.TryGetProperty("config", out var configElement))
        {
            config = new SessionConfig(
                SampleRate: GetInt(configElement, "sample_rate"),
                AudioFormat: RealtimeAudioFormatExtensions.FromApiValue(GetString(configElement, "audio_format")),
                LanguageCode: GetString(configElement, "language_code"),
                CommitStrategy: RealtimeCommitStrategyExtensions.FromApiValue(GetString(configElement, "commit_strategy")),
                VadSilenceThresholdSeconds: GetDouble(configElement, "vad_silence_threshold_secs"),
                VadThreshold: GetDouble(configElement, "vad_threshold"),
                MinSpeechDurationMs: GetInt(configElement, "min_speech_duration_ms"),
                MinSilenceDurationMs: GetInt(configElement, "min_silence_duration_ms"),
                ModelId: GetString(configElement, "model_id"),
                EnableLogging: GetBool(configElement, "enable_logging"),
                IncludeTimestamps: GetBool(configElement, "include_timestamps"),
                IncludeLanguageDetection: GetBool(configElement, "include_language_detection"));
        }

        return new SessionStartedEvent(sessionId, config);
    }

    private static CommittedTranscriptWithTimestampsEvent ParseCommittedTranscriptWithTimestamps(JsonElement root)
    {
        var text = root.TryGetProperty("text", out var textElement)
            ? textElement.GetString() ?? string.Empty
            : string.Empty;

        var languageCode = GetString(root, "language_code");
        IReadOnlyList<TranscriptionWord>? words = null;

        if (root.TryGetProperty("words", out var wordsElement) && wordsElement.ValueKind == JsonValueKind.Array)
        {
            var list = new List<TranscriptionWord>();
            foreach (var wordElement in wordsElement.EnumerateArray())
            {
                list.Add(ParseWord(wordElement));
            }
            words = list;
        }

        return new CommittedTranscriptWithTimestampsEvent(text, languageCode, words);
    }

    private static TranscriptionWord ParseWord(JsonElement wordElement)
    {
        var text = GetString(wordElement, "text") ?? string.Empty;
        var start = GetDouble(wordElement, "start") ?? 0.0;
        var end = GetDouble(wordElement, "end") ?? 0.0;
        var typeValue = GetString(wordElement, "type") ?? "word";
        var type = typeValue == "spacing" ? TranscriptionWordType.Spacing : TranscriptionWordType.Word;
        var speakerId = GetString(wordElement, "speaker_id");
        var logProb = GetDouble(wordElement, "logprob");
        IReadOnlyList<string>? characters = null;

        if (wordElement.TryGetProperty("characters", out var charsElement) && charsElement.ValueKind == JsonValueKind.Array)
        {
            var list = new List<string>();
            foreach (var charElement in charsElement.EnumerateArray())
            {
                if (charElement.ValueKind == JsonValueKind.String)
                {
                    list.Add(charElement.GetString() ?? string.Empty);
                }
            }
            characters = list;
        }

        return new TranscriptionWord(text, start, end, type, speakerId, logProb, characters);
    }

    private static string? GetString(JsonElement element, string name)
    {
        return element.TryGetProperty(name, out var property) && property.ValueKind == JsonValueKind.String
            ? property.GetString()
            : null;
    }

    private static int? GetInt(JsonElement element, string name)
    {
        if (element.TryGetProperty(name, out var property) && property.ValueKind == JsonValueKind.Number && property.TryGetInt32(out var value))
        {
            return value;
        }

        return null;
    }

    private static double? GetDouble(JsonElement element, string name)
    {
        if (element.TryGetProperty(name, out var property) && property.ValueKind == JsonValueKind.Number && property.TryGetDouble(out var value))
        {
            return value;
        }

        return null;
    }

    private static bool? GetBool(JsonElement element, string name)
    {
        if (element.TryGetProperty(name, out var property))
        {
            return property.ValueKind switch
            {
                JsonValueKind.True => true,
                JsonValueKind.False => false,
                _ => null
            };
        }

        return null;
    }
}
