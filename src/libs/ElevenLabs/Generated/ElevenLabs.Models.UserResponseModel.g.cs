
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.SubscriptionResponseModel Subscription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription_extras")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.SubscriptionExtrasResponseModel SubscriptionExtras { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_new_user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsNewUser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xi_api_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string XiApiKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_use_delayed_payment_methods")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CanUseDelayedPaymentMethods { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_onboarding_completed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsOnboardingCompleted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_onboarding_checklist_completed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsOnboardingChecklistCompleted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_name")]
        public string? FirstName { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_api_key_hashed")]
        public bool? IsApiKeyHashed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xi_api_key_preview")]
        public string? XiApiKeyPreview { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referral_link_code")]
        public string? ReferralLinkCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partnerstack_partner_default_link")]
        public string? PartnerstackPartnerDefaultLink { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserResponseModel" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="subscription"></param>
        /// <param name="subscriptionExtras"></param>
        /// <param name="isNewUser"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="canUseDelayedPaymentMethods"></param>
        /// <param name="isOnboardingCompleted"></param>
        /// <param name="isOnboardingChecklistCompleted"></param>
        /// <param name="firstName"></param>
        /// <param name="isApiKeyHashed">
        /// Default Value: false
        /// </param>
        /// <param name="xiApiKeyPreview"></param>
        /// <param name="referralLinkCode"></param>
        /// <param name="partnerstackPartnerDefaultLink"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UserResponseModel(
            string userId,
            global::ElevenLabs.SubscriptionResponseModel subscription,
            global::ElevenLabs.SubscriptionExtrasResponseModel subscriptionExtras,
            bool isNewUser,
            string xiApiKey,
            bool canUseDelayedPaymentMethods,
            bool isOnboardingCompleted,
            bool isOnboardingChecklistCompleted,
            string? firstName,
            bool? isApiKeyHashed,
            string? xiApiKeyPreview,
            string? referralLinkCode,
            string? partnerstackPartnerDefaultLink)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Subscription = subscription ?? throw new global::System.ArgumentNullException(nameof(subscription));
            this.SubscriptionExtras = subscriptionExtras ?? throw new global::System.ArgumentNullException(nameof(subscriptionExtras));
            this.IsNewUser = isNewUser;
            this.XiApiKey = xiApiKey ?? throw new global::System.ArgumentNullException(nameof(xiApiKey));
            this.CanUseDelayedPaymentMethods = canUseDelayedPaymentMethods;
            this.IsOnboardingCompleted = isOnboardingCompleted;
            this.IsOnboardingChecklistCompleted = isOnboardingChecklistCompleted;
            this.FirstName = firstName;
            this.IsApiKeyHashed = isApiKeyHashed;
            this.XiApiKeyPreview = xiApiKeyPreview;
            this.ReferralLinkCode = referralLinkCode;
            this.PartnerstackPartnerDefaultLink = partnerstackPartnerDefaultLink;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserResponseModel" /> class.
        /// </summary>
        public UserResponseModel()
        {
        }
    }
}