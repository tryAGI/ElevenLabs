
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PrivacyConfig
    {
        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("record_voice")]
        public bool? RecordVoice { get; set; }

        /// <summary>
        /// Default Value: -1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retention_days")]
        public int? RetentionDays { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete_transcript_and_pii")]
        public bool? DeleteTranscriptAndPii { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete_audio")]
        public bool? DeleteAudio { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apply_to_existing_conversations")]
        public bool? ApplyToExistingConversations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivacyConfig" /> class.
        /// </summary>
        /// <param name="recordVoice">
        /// Default Value: true
        /// </param>
        /// <param name="retentionDays">
        /// Default Value: -1
        /// </param>
        /// <param name="deleteTranscriptAndPii">
        /// Default Value: false
        /// </param>
        /// <param name="deleteAudio">
        /// Default Value: false
        /// </param>
        /// <param name="applyToExistingConversations">
        /// Default Value: false
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PrivacyConfig(
            bool? recordVoice,
            int? retentionDays,
            bool? deleteTranscriptAndPii,
            bool? deleteAudio,
            bool? applyToExistingConversations)
        {
            this.RecordVoice = recordVoice;
            this.RetentionDays = retentionDays;
            this.DeleteTranscriptAndPii = deleteTranscriptAndPii;
            this.DeleteAudio = deleteAudio;
            this.ApplyToExistingConversations = applyToExistingConversations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivacyConfig" /> class.
        /// </summary>
        public PrivacyConfig()
        {
        }
    }
}