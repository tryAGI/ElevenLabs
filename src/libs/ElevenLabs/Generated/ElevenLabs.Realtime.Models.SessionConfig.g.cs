
#nullable enable

namespace ElevenLabs.Realtime
{
    /// <summary>
    /// Negotiated session configuration returned by the server.
    /// </summary>
    public sealed partial class SessionConfig
    {
        /// <summary>
        /// The model used for transcription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Audio sample rate in Hz.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_rate")]
        public int? SampleRate { get; set; }

        /// <summary>
        /// Audio format being used (e.g., pcm_16000, ulaw_8000).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_format")]
        public string? AudioFormat { get; set; }

        /// <summary>
        /// Language code in ISO 639-1 or ISO 639-3 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_code")]
        public string? LanguageCode { get; set; }

        /// <summary>
        /// Commit strategy (manual or vad).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_strategy")]
        public string? CommitStrategy { get; set; }

        /// <summary>
        /// VAD silence threshold in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vad_silence_threshold_secs")]
        public double? VadSilenceThresholdSecs { get; set; }

        /// <summary>
        /// Voice activity detection threshold.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vad_threshold")]
        public double? VadThreshold { get; set; }

        /// <summary>
        /// Minimum speech duration in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_speech_duration_ms")]
        public int? MinSpeechDurationMs { get; set; }

        /// <summary>
        /// Minimum silence duration in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_silence_duration_ms")]
        public int? MinSilenceDurationMs { get; set; }

        /// <summary>
        /// Whether logging is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_logging")]
        public bool? EnableLogging { get; set; }

        /// <summary>
        /// Whether word-level timestamps are included.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_timestamps")]
        public bool? IncludeTimestamps { get; set; }

        /// <summary>
        /// Whether language detection is included.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_language_detection")]
        public bool? IncludeLanguageDetection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionConfig" /> class.
        /// </summary>
        /// <param name="modelId">
        /// The model used for transcription.
        /// </param>
        /// <param name="sampleRate">
        /// Audio sample rate in Hz.
        /// </param>
        /// <param name="audioFormat">
        /// Audio format being used (e.g., pcm_16000, ulaw_8000).
        /// </param>
        /// <param name="languageCode">
        /// Language code in ISO 639-1 or ISO 639-3 format.
        /// </param>
        /// <param name="commitStrategy">
        /// Commit strategy (manual or vad).
        /// </param>
        /// <param name="vadSilenceThresholdSecs">
        /// VAD silence threshold in seconds.
        /// </param>
        /// <param name="vadThreshold">
        /// Voice activity detection threshold.
        /// </param>
        /// <param name="minSpeechDurationMs">
        /// Minimum speech duration in milliseconds.
        /// </param>
        /// <param name="minSilenceDurationMs">
        /// Minimum silence duration in milliseconds.
        /// </param>
        /// <param name="enableLogging">
        /// Whether logging is enabled.
        /// </param>
        /// <param name="includeTimestamps">
        /// Whether word-level timestamps are included.
        /// </param>
        /// <param name="includeLanguageDetection">
        /// Whether language detection is included.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionConfig(
            string? modelId,
            int? sampleRate,
            string? audioFormat,
            string? languageCode,
            string? commitStrategy,
            double? vadSilenceThresholdSecs,
            double? vadThreshold,
            int? minSpeechDurationMs,
            int? minSilenceDurationMs,
            bool? enableLogging,
            bool? includeTimestamps,
            bool? includeLanguageDetection)
        {
            this.ModelId = modelId;
            this.SampleRate = sampleRate;
            this.AudioFormat = audioFormat;
            this.LanguageCode = languageCode;
            this.CommitStrategy = commitStrategy;
            this.VadSilenceThresholdSecs = vadSilenceThresholdSecs;
            this.VadThreshold = vadThreshold;
            this.MinSpeechDurationMs = minSpeechDurationMs;
            this.MinSilenceDurationMs = minSilenceDurationMs;
            this.EnableLogging = enableLogging;
            this.IncludeTimestamps = includeTimestamps;
            this.IncludeLanguageDetection = includeLanguageDetection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionConfig" /> class.
        /// </summary>
        public SessionConfig()
        {
        }
    }
}