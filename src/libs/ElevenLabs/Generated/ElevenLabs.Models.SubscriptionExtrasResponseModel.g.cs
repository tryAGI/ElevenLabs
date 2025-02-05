
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubscriptionExtrasResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Concurrency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convai_concurrency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ConvaiConcurrency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convai_chars_per_minute")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ConvaiCharsPerMinute { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convai_asr_chars_per_minute")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ConvaiAsrCharsPerMinute { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("force_logging_disabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ForceLoggingDisabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_request_manual_pro_voice_verification")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CanRequestManualProVoiceVerification { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_bypass_voice_captcha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CanBypassVoiceCaptcha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moderation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ModerationStatusResponseModel Moderation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionExtrasResponseModel" /> class.
        /// </summary>
        /// <param name="concurrency"></param>
        /// <param name="convaiConcurrency"></param>
        /// <param name="convaiCharsPerMinute"></param>
        /// <param name="convaiAsrCharsPerMinute"></param>
        /// <param name="forceLoggingDisabled"></param>
        /// <param name="canRequestManualProVoiceVerification"></param>
        /// <param name="canBypassVoiceCaptcha"></param>
        /// <param name="moderation"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SubscriptionExtrasResponseModel(
            int concurrency,
            int convaiConcurrency,
            int convaiCharsPerMinute,
            int convaiAsrCharsPerMinute,
            bool forceLoggingDisabled,
            bool canRequestManualProVoiceVerification,
            bool canBypassVoiceCaptcha,
            global::ElevenLabs.ModerationStatusResponseModel moderation)
        {
            this.Concurrency = concurrency;
            this.ConvaiConcurrency = convaiConcurrency;
            this.ConvaiCharsPerMinute = convaiCharsPerMinute;
            this.ConvaiAsrCharsPerMinute = convaiAsrCharsPerMinute;
            this.ForceLoggingDisabled = forceLoggingDisabled;
            this.CanRequestManualProVoiceVerification = canRequestManualProVoiceVerification;
            this.CanBypassVoiceCaptcha = canBypassVoiceCaptcha;
            this.Moderation = moderation ?? throw new global::System.ArgumentNullException(nameof(moderation));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionExtrasResponseModel" /> class.
        /// </summary>
        public SubscriptionExtrasResponseModel()
        {
        }
    }
}