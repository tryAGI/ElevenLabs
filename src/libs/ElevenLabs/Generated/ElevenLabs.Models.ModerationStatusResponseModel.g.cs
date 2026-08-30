
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"enterprise_background_moderation_enabled":false,"enterprise_check_block_nogo_voice":false,"enterprise_check_nogo_voice":false,"is_in_probation":false,"is_ivc_captcha_required":false,"never_live_moderate":false,"nogo_voice_similar_voice_upload_count":0,"on_watchlist":false}
    /// </summary>
    public sealed partial class ModerationStatusResponseModel
    {
        /// <summary>
        /// Whether the user is in probation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_in_probation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsInProbation { get; set; }

        /// <summary>
        /// Whether the user's enterprise check nogo voice is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enterprise_check_nogo_voice")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool EnterpriseCheckNogoVoice { get; set; }

        /// <summary>
        /// Whether the user's enterprise check block nogo voice is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enterprise_check_block_nogo_voice")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool EnterpriseCheckBlockNogoVoice { get; set; }

        /// <summary>
        /// Whether the user's never live moderate is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("never_live_moderate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool NeverLiveModerate { get; set; }

        /// <summary>
        /// The number of similar voice uploads that have been blocked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nogo_voice_similar_voice_upload_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NogoVoiceSimilarVoiceUploadCount { get; set; }

        /// <summary>
        /// Whether the user's enterprise background moderation is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enterprise_background_moderation_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool EnterpriseBackgroundModerationEnabled { get; set; }

        /// <summary>
        /// Whether captcha is required when creating IVCs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_ivc_captcha_required")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsIvcCaptchaRequired { get; set; }

        /// <summary>
        /// The safety status of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("safety_status")]
        public global::ElevenLabs.ModerationStatusResponseModelSafetyStatus2? SafetyStatus { get; set; }

        /// <summary>
        /// The warning status of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warning_status")]
        public global::ElevenLabs.ModerationStatusResponseModelWarningStatus2? WarningStatus { get; set; }

        /// <summary>
        /// Whether the user is on the watchlist.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_watchlist")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool OnWatchlist { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationStatusResponseModel" /> class.
        /// </summary>
        /// <param name="isInProbation">
        /// Whether the user is in probation.
        /// </param>
        /// <param name="enterpriseCheckNogoVoice">
        /// Whether the user's enterprise check nogo voice is enabled.
        /// </param>
        /// <param name="enterpriseCheckBlockNogoVoice">
        /// Whether the user's enterprise check block nogo voice is enabled.
        /// </param>
        /// <param name="neverLiveModerate">
        /// Whether the user's never live moderate is enabled.
        /// </param>
        /// <param name="nogoVoiceSimilarVoiceUploadCount">
        /// The number of similar voice uploads that have been blocked.
        /// </param>
        /// <param name="enterpriseBackgroundModerationEnabled">
        /// Whether the user's enterprise background moderation is enabled.
        /// </param>
        /// <param name="isIvcCaptchaRequired">
        /// Whether captcha is required when creating IVCs.
        /// </param>
        /// <param name="onWatchlist">
        /// Whether the user is on the watchlist.
        /// </param>
        /// <param name="safetyStatus">
        /// The safety status of the user.
        /// </param>
        /// <param name="warningStatus">
        /// The warning status of the user.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModerationStatusResponseModel(
            bool isInProbation,
            bool enterpriseCheckNogoVoice,
            bool enterpriseCheckBlockNogoVoice,
            bool neverLiveModerate,
            int nogoVoiceSimilarVoiceUploadCount,
            bool enterpriseBackgroundModerationEnabled,
            bool isIvcCaptchaRequired,
            bool onWatchlist,
            global::ElevenLabs.ModerationStatusResponseModelSafetyStatus2? safetyStatus,
            global::ElevenLabs.ModerationStatusResponseModelWarningStatus2? warningStatus)
        {
            this.IsInProbation = isInProbation;
            this.EnterpriseCheckNogoVoice = enterpriseCheckNogoVoice;
            this.EnterpriseCheckBlockNogoVoice = enterpriseCheckBlockNogoVoice;
            this.NeverLiveModerate = neverLiveModerate;
            this.NogoVoiceSimilarVoiceUploadCount = nogoVoiceSimilarVoiceUploadCount;
            this.EnterpriseBackgroundModerationEnabled = enterpriseBackgroundModerationEnabled;
            this.IsIvcCaptchaRequired = isIvcCaptchaRequired;
            this.SafetyStatus = safetyStatus;
            this.WarningStatus = warningStatus;
            this.OnWatchlist = onWatchlist;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationStatusResponseModel" /> class.
        /// </summary>
        public ModerationStatusResponseModel()
        {
        }

    }
}