
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Aggregated TTS usage for a conversation (analytics-only, not billing).
    /// </summary>
    public sealed partial class ConversationTTSUsageModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primary_tts_model")]
        public string? PrimaryTtsModel { get; set; }

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_audio_output_seconds")]
        public double? TotalAudioOutputSeconds { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_characters")]
        public int? TotalCharacters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("per_voice_usage")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.ConversationVoiceUsageModel>? PerVoiceUsage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationTTSUsageModel" /> class.
        /// </summary>
        /// <param name="primaryTtsModel"></param>
        /// <param name="totalAudioOutputSeconds">
        /// Default Value: 0F
        /// </param>
        /// <param name="totalCharacters">
        /// Default Value: 0
        /// </param>
        /// <param name="perVoiceUsage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationTTSUsageModel(
            string? primaryTtsModel,
            double? totalAudioOutputSeconds,
            int? totalCharacters,
            global::System.Collections.Generic.IList<global::ElevenLabs.ConversationVoiceUsageModel>? perVoiceUsage)
        {
            this.PrimaryTtsModel = primaryTtsModel;
            this.TotalAudioOutputSeconds = totalAudioOutputSeconds;
            this.TotalCharacters = totalCharacters;
            this.PerVoiceUsage = perVoiceUsage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationTTSUsageModel" /> class.
        /// </summary>
        public ConversationTTSUsageModel()
        {
        }

    }
}