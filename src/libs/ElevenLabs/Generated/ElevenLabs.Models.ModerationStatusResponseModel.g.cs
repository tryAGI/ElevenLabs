
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModerationStatusResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_in_probation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsInProbation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enterprise_check_nogo_voice")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool EnterpriseCheckNogoVoice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enterprise_check_block_nogo_voice")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool EnterpriseCheckBlockNogoVoice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("never_live_moderate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool NeverLiveModerate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nogo_voice_similar_voice_upload_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NogoVoiceSimilarVoiceUploadCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enterprise_background_moderation_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool EnterpriseBackgroundModerationEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("safety_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ModerationStatusResponseModelSafetyStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ModerationStatusResponseModelSafetyStatus SafetyStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warning_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ModerationStatusResponseModelWarningStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ModerationStatusResponseModelWarningStatus WarningStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationStatusResponseModel" /> class.
        /// </summary>
        /// <param name="isInProbation"></param>
        /// <param name="enterpriseCheckNogoVoice"></param>
        /// <param name="enterpriseCheckBlockNogoVoice"></param>
        /// <param name="neverLiveModerate"></param>
        /// <param name="nogoVoiceSimilarVoiceUploadCount"></param>
        /// <param name="enterpriseBackgroundModerationEnabled"></param>
        /// <param name="safetyStatus"></param>
        /// <param name="warningStatus"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ModerationStatusResponseModel(
            bool isInProbation,
            bool enterpriseCheckNogoVoice,
            bool enterpriseCheckBlockNogoVoice,
            bool neverLiveModerate,
            int nogoVoiceSimilarVoiceUploadCount,
            bool enterpriseBackgroundModerationEnabled,
            global::ElevenLabs.ModerationStatusResponseModelSafetyStatus safetyStatus,
            global::ElevenLabs.ModerationStatusResponseModelWarningStatus warningStatus)
        {
            this.IsInProbation = isInProbation;
            this.EnterpriseCheckNogoVoice = enterpriseCheckNogoVoice;
            this.EnterpriseCheckBlockNogoVoice = enterpriseCheckBlockNogoVoice;
            this.NeverLiveModerate = neverLiveModerate;
            this.NogoVoiceSimilarVoiceUploadCount = nogoVoiceSimilarVoiceUploadCount;
            this.EnterpriseBackgroundModerationEnabled = enterpriseBackgroundModerationEnabled;
            this.SafetyStatus = safetyStatus;
            this.WarningStatus = warningStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationStatusResponseModel" /> class.
        /// </summary>
        public ModerationStatusResponseModel()
        {
        }
    }
}