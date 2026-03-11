
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"allowed_to_extend_character_limit":false,"billing_period":"monthly_period","can_extend_character_limit":false,"can_extend_voice_limit":false,"can_use_instant_voice_cloning":true,"can_use_professional_voice_cloning":true,"character_count":17231,"character_limit":100000,"character_refresh_period":"monthly_period","currency":"usd","max_character_limit_extension":10000,"max_voice_add_edits":230,"next_character_count_reset_unix":1738356858,"professional_voice_limit":1,"professional_voice_slots_used":0,"status":"free","tier":"trial","voice_add_edit_counter":212,"voice_limit":120,"voice_slots_used":1}
    /// </summary>
    public sealed partial class SubscriptionResponseModel
    {
        /// <summary>
        /// The tier of the user's subscription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Tier { get; set; } = default!;

        /// <summary>
        /// The number of characters used by the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int CharacterCount { get; set; } = default!;

        /// <summary>
        /// The maximum number of characters allowed in the current billing period.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int CharacterLimit { get; set; } = default!;

        /// <summary>
        /// Maximum number of characters that the character limit can be exceeded by. Managed by the workspace admin.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_character_limit_extension")]
        public int? MaxCharacterLimitExtension { get; set; }

        /// <summary>
        /// Whether the user can extend their character limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_extend_character_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public bool CanExtendCharacterLimit { get; set; } = default!;

        /// <summary>
        /// Whether the user is allowed to extend their character limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_to_extend_character_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public bool AllowedToExtendCharacterLimit { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp of the next character count reset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_character_count_reset_unix")]
        public int? NextCharacterCountResetUnix { get; set; }

        /// <summary>
        /// The number of voice slots used by the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_slots_used")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int VoiceSlotsUsed { get; set; } = default!;

        /// <summary>
        /// The number of professional voice slots used by the workspace/user if single seat.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("professional_voice_slots_used")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int ProfessionalVoiceSlotsUsed { get; set; } = default!;

        /// <summary>
        /// The maximum number of voice slots allowed for the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int VoiceLimit { get; set; } = default!;

        /// <summary>
        /// The maximum number of voice add/edits allowed for the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_voice_add_edits")]
        public int? MaxVoiceAddEdits { get; set; }

        /// <summary>
        /// The number of voice add/edits used by the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_add_edit_counter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int VoiceAddEditCounter { get; set; } = default!;

        /// <summary>
        /// The maximum number of professional voices allowed for the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("professional_voice_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int ProfessionalVoiceLimit { get; set; } = default!;

        /// <summary>
        /// Whether the user can extend their voice limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_extend_voice_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public bool CanExtendVoiceLimit { get; set; } = default!;

        /// <summary>
        /// Whether the user can use instant voice cloning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_use_instant_voice_cloning")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public bool CanUseInstantVoiceCloning { get; set; } = default!;

        /// <summary>
        /// Whether the user can use professional voice cloning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_use_professional_voice_cloning")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public bool CanUseProfessionalVoiceCloning { get; set; } = default!;

        /// <summary>
        /// The currency of the user's subscription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currency")]
        public global::ElevenLabs.SubscriptionResponseModelCurrency2? Currency { get; set; }

        /// <summary>
        /// The status of the user's subscription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.SubscriptionStatusTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::ElevenLabs.SubscriptionStatusType Status { get; set; } = default!;

        /// <summary>
        /// The billing period of the user's subscription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing_period")]
        public global::ElevenLabs.BillingPeriod? BillingPeriod { get; set; }

        /// <summary>
        /// The character refresh period of the user's subscription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_refresh_period")]
        public global::ElevenLabs.CharacterRefreshPeriod? CharacterRefreshPeriod { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionResponseModel" /> class.
        /// </summary>
        /// <param name="tier">
        /// The tier of the user's subscription.
        /// </param>
        /// <param name="characterCount">
        /// The number of characters used by the user.
        /// </param>
        /// <param name="characterLimit">
        /// The maximum number of characters allowed in the current billing period.
        /// </param>
        /// <param name="maxCharacterLimitExtension">
        /// Maximum number of characters that the character limit can be exceeded by. Managed by the workspace admin.
        /// </param>
        /// <param name="canExtendCharacterLimit">
        /// Whether the user can extend their character limit.
        /// </param>
        /// <param name="allowedToExtendCharacterLimit">
        /// Whether the user is allowed to extend their character limit.
        /// </param>
        /// <param name="nextCharacterCountResetUnix">
        /// The Unix timestamp of the next character count reset.
        /// </param>
        /// <param name="voiceSlotsUsed">
        /// The number of voice slots used by the user.
        /// </param>
        /// <param name="professionalVoiceSlotsUsed">
        /// The number of professional voice slots used by the workspace/user if single seat.
        /// </param>
        /// <param name="voiceLimit">
        /// The maximum number of voice slots allowed for the user.
        /// </param>
        /// <param name="maxVoiceAddEdits">
        /// The maximum number of voice add/edits allowed for the user.
        /// </param>
        /// <param name="voiceAddEditCounter">
        /// The number of voice add/edits used by the user.
        /// </param>
        /// <param name="professionalVoiceLimit">
        /// The maximum number of professional voices allowed for the user.
        /// </param>
        /// <param name="canExtendVoiceLimit">
        /// Whether the user can extend their voice limit.
        /// </param>
        /// <param name="canUseInstantVoiceCloning">
        /// Whether the user can use instant voice cloning.
        /// </param>
        /// <param name="canUseProfessionalVoiceCloning">
        /// Whether the user can use professional voice cloning.
        /// </param>
        /// <param name="currency">
        /// The currency of the user's subscription.
        /// </param>
        /// <param name="status">
        /// The status of the user's subscription.
        /// </param>
        /// <param name="billingPeriod">
        /// The billing period of the user's subscription.
        /// </param>
        /// <param name="characterRefreshPeriod">
        /// The character refresh period of the user's subscription.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionResponseModel(
            string tier,
            int characterCount,
            int characterLimit,
            bool canExtendCharacterLimit,
            bool allowedToExtendCharacterLimit,
            int voiceSlotsUsed,
            int professionalVoiceSlotsUsed,
            int voiceLimit,
            int voiceAddEditCounter,
            int professionalVoiceLimit,
            bool canExtendVoiceLimit,
            bool canUseInstantVoiceCloning,
            bool canUseProfessionalVoiceCloning,
            global::ElevenLabs.SubscriptionStatusType status,
            int? maxCharacterLimitExtension,
            int? nextCharacterCountResetUnix,
            int? maxVoiceAddEdits,
            global::ElevenLabs.SubscriptionResponseModelCurrency2? currency,
            global::ElevenLabs.BillingPeriod? billingPeriod,
            global::ElevenLabs.CharacterRefreshPeriod? characterRefreshPeriod)
        {
            this.Tier = tier ?? throw new global::System.ArgumentNullException(nameof(tier));
            this.CharacterCount = characterCount;
            this.CharacterLimit = characterLimit;
            this.CanExtendCharacterLimit = canExtendCharacterLimit;
            this.AllowedToExtendCharacterLimit = allowedToExtendCharacterLimit;
            this.VoiceSlotsUsed = voiceSlotsUsed;
            this.ProfessionalVoiceSlotsUsed = professionalVoiceSlotsUsed;
            this.VoiceLimit = voiceLimit;
            this.VoiceAddEditCounter = voiceAddEditCounter;
            this.ProfessionalVoiceLimit = professionalVoiceLimit;
            this.CanExtendVoiceLimit = canExtendVoiceLimit;
            this.CanUseInstantVoiceCloning = canUseInstantVoiceCloning;
            this.CanUseProfessionalVoiceCloning = canUseProfessionalVoiceCloning;
            this.Status = status;
            this.MaxCharacterLimitExtension = maxCharacterLimitExtension;
            this.NextCharacterCountResetUnix = nextCharacterCountResetUnix;
            this.MaxVoiceAddEdits = maxVoiceAddEdits;
            this.Currency = currency;
            this.BillingPeriod = billingPeriod;
            this.CharacterRefreshPeriod = characterRefreshPeriod;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionResponseModel" /> class.
        /// </summary>
        public SubscriptionResponseModel()
        {
        }
    }
}