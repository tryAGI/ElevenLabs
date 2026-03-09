
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"can_bypass_voice_captcha":true,"can_request_manual_pro_voice_verification":true,"concurrency":10,"convai_concurrency":10,"force_logging_disabled":false,"moderation":{"enterprise_background_moderation_enabled":false,"enterprise_check_block_nogo_voice":false,"enterprise_check_nogo_voice":false,"is_in_probation":false,"never_live_moderate":false,"nogo_voice_similar_voice_upload_count":0,"on_watchlist":false},"overused_characters_rolled_over_from_previous_period":1000,"unused_characters_rolled_over_from_previous_period":1000,"usage":{"actual_reported_credits":1000,"manually_gifted_credits_quota":1000,"manually_gifted_credits_used":1000,"paid_usage_based_credits_used":1000,"rollover_credits_quota":1000,"rollover_credits_used":1000,"subscription_cycle_credits_quota":1000,"subscription_cycle_credits_used":1000}}
    /// </summary>
    public sealed partial class SubscriptionExtrasResponseModel
    {
        /// <summary>
        /// The concurrency of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int Concurrency { get; set; } = default!;

        /// <summary>
        /// The Convai concurrency of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convai_concurrency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int ConvaiConcurrency { get; set; } = default!;

        /// <summary>
        /// The Convai characters per minute of the user. This field is deprecated and will always return None.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convai_chars_per_minute")]
        public int? ConvaiCharsPerMinute { get; set; }

        /// <summary>
        /// The Convai ASR characters per minute of the user. This field is deprecated and will always return None.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convai_asr_chars_per_minute")]
        public int? ConvaiAsrCharsPerMinute { get; set; }

        /// <summary>
        /// Whether the user's logging is disabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("force_logging_disabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public bool ForceLoggingDisabled { get; set; } = default!;

        /// <summary>
        /// Whether the user can request manual pro voice verification.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_request_manual_pro_voice_verification")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public bool CanRequestManualProVoiceVerification { get; set; } = default!;

        /// <summary>
        /// Whether the user can bypass the voice captcha.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_bypass_voice_captcha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public bool CanBypassVoiceCaptcha { get; set; } = default!;

        /// <summary>
        /// Example: {"enterprise_background_moderation_enabled":false,"enterprise_check_block_nogo_voice":false,"enterprise_check_nogo_voice":false,"is_in_probation":false,"never_live_moderate":false,"nogo_voice_similar_voice_upload_count":0,"on_watchlist":false}
        /// </summary>
        /// <example>{"enterprise_background_moderation_enabled":false,"enterprise_check_block_nogo_voice":false,"enterprise_check_nogo_voice":false,"is_in_probation":false,"never_live_moderate":false,"nogo_voice_similar_voice_upload_count":0,"on_watchlist":false}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("moderation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::ElevenLabs.ModerationStatusResponseModel Moderation { get; set; } = default!;

        /// <summary>
        /// The unused characters rolled over from the previous period.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unused_characters_rolled_over_from_previous_period")]
        public int? UnusedCharactersRolledOverFromPreviousPeriod { get; set; }

        /// <summary>
        /// The overused characters rolled over from the previous period.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overused_characters_rolled_over_from_previous_period")]
        public int? OverusedCharactersRolledOverFromPreviousPeriod { get; set; }

        /// <summary>
        /// Example: {"actual_reported_credits":1000,"manually_gifted_credits_quota":1000,"manually_gifted_credits_used":1000,"paid_usage_based_credits_used":1000,"rollover_credits_quota":1000,"rollover_credits_used":1000,"subscription_cycle_credits_quota":1000,"subscription_cycle_credits_used":1000}
        /// </summary>
        /// <example>{"actual_reported_credits":1000,"manually_gifted_credits_quota":1000,"manually_gifted_credits_used":1000,"paid_usage_based_credits_used":1000,"rollover_credits_quota":1000,"rollover_credits_used":1000,"subscription_cycle_credits_quota":1000,"subscription_cycle_credits_used":1000}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::ElevenLabs.SubscriptionUsageResponseModel? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionExtrasResponseModel" /> class.
        /// </summary>
        /// <param name="concurrency">
        /// The concurrency of the user.
        /// </param>
        /// <param name="convaiConcurrency">
        /// The Convai concurrency of the user.
        /// </param>
        /// <param name="convaiCharsPerMinute">
        /// The Convai characters per minute of the user. This field is deprecated and will always return None.
        /// </param>
        /// <param name="convaiAsrCharsPerMinute">
        /// The Convai ASR characters per minute of the user. This field is deprecated and will always return None.
        /// </param>
        /// <param name="forceLoggingDisabled">
        /// Whether the user's logging is disabled.
        /// </param>
        /// <param name="canRequestManualProVoiceVerification">
        /// Whether the user can request manual pro voice verification.
        /// </param>
        /// <param name="canBypassVoiceCaptcha">
        /// Whether the user can bypass the voice captcha.
        /// </param>
        /// <param name="moderation">
        /// Example: {"enterprise_background_moderation_enabled":false,"enterprise_check_block_nogo_voice":false,"enterprise_check_nogo_voice":false,"is_in_probation":false,"never_live_moderate":false,"nogo_voice_similar_voice_upload_count":0,"on_watchlist":false}
        /// </param>
        /// <param name="unusedCharactersRolledOverFromPreviousPeriod">
        /// The unused characters rolled over from the previous period.
        /// </param>
        /// <param name="overusedCharactersRolledOverFromPreviousPeriod">
        /// The overused characters rolled over from the previous period.
        /// </param>
        /// <param name="usage">
        /// Example: {"actual_reported_credits":1000,"manually_gifted_credits_quota":1000,"manually_gifted_credits_used":1000,"paid_usage_based_credits_used":1000,"rollover_credits_quota":1000,"rollover_credits_used":1000,"subscription_cycle_credits_quota":1000,"subscription_cycle_credits_used":1000}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionExtrasResponseModel(
            int concurrency,
            int convaiConcurrency,
            bool forceLoggingDisabled,
            bool canRequestManualProVoiceVerification,
            bool canBypassVoiceCaptcha,
            global::ElevenLabs.ModerationStatusResponseModel moderation,
            int? convaiCharsPerMinute,
            int? convaiAsrCharsPerMinute,
            int? unusedCharactersRolledOverFromPreviousPeriod,
            int? overusedCharactersRolledOverFromPreviousPeriod,
            global::ElevenLabs.SubscriptionUsageResponseModel? usage)
        {
            this.Concurrency = concurrency;
            this.ConvaiConcurrency = convaiConcurrency;
            this.ForceLoggingDisabled = forceLoggingDisabled;
            this.CanRequestManualProVoiceVerification = canRequestManualProVoiceVerification;
            this.CanBypassVoiceCaptcha = canBypassVoiceCaptcha;
            this.Moderation = moderation ?? throw new global::System.ArgumentNullException(nameof(moderation));
            this.ConvaiCharsPerMinute = convaiCharsPerMinute;
            this.ConvaiAsrCharsPerMinute = convaiAsrCharsPerMinute;
            this.UnusedCharactersRolledOverFromPreviousPeriod = unusedCharactersRolledOverFromPreviousPeriod;
            this.OverusedCharactersRolledOverFromPreviousPeriod = overusedCharactersRolledOverFromPreviousPeriod;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionExtrasResponseModel" /> class.
        /// </summary>
        public SubscriptionExtrasResponseModel()
        {
        }
    }
}