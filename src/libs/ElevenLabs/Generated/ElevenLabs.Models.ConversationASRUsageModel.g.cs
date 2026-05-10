
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Aggregated ASR usage for a conversation (analytics-only, not billing).
    /// </summary>
    public sealed partial class ConversationASRUsageModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asr_model")]
        public string? AsrModel { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_transcription_calls")]
        public int? TotalTranscriptionCalls { get; set; }

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_audio_input_seconds")]
        public double? TotalAudioInputSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationASRUsageModel" /> class.
        /// </summary>
        /// <param name="asrModel"></param>
        /// <param name="totalTranscriptionCalls">
        /// Default Value: 0
        /// </param>
        /// <param name="totalAudioInputSeconds">
        /// Default Value: 0F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationASRUsageModel(
            string? asrModel,
            int? totalTranscriptionCalls,
            double? totalAudioInputSeconds)
        {
            this.AsrModel = asrModel;
            this.TotalTranscriptionCalls = totalTranscriptionCalls;
            this.TotalAudioInputSeconds = totalAudioInputSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationASRUsageModel" /> class.
        /// </summary>
        public ConversationASRUsageModel()
        {
        }

    }
}