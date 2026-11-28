
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ReceptionProvisionResellerWorkspaceRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("business_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BusinessName { get; set; }

        /// <summary>
        /// The business's vertical, used with `complete_onboarding`. Without it, onboarding picks the vertical as usual.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vertical")]
        public global::ElevenLabs.ReceptionVertical? Vertical { get; set; }

        /// <summary>
        /// Bill the workspace's own customer instead of the reseller: it checks out and sees its billing itself, and the reseller earns a commission. Only for a reseller on standard billing.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("charge_customer")]
        public bool? ChargeCustomer { get; set; }

        /// <summary>
        /// Paid tier to subscribe to. Omitted leaves the workspace with no subscription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription")]
        public global::ElevenLabs.ProvisionResellerWorkspaceSubscription? Subscription { get; set; }

        /// <summary>
        /// A free number from the reseller's phone pool, reserved for the workspace until onboarding binds it to the receptionist.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// People to invite once the workspace exists, capped by the tier's team size. Best-effort: each outcome is in `member_results`.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.TeamInviteRequest>? Members { get; set; }

        /// <summary>
        /// Finish setup right away, as `POST /v1/reception/reseller/workspaces/{workspace_id}/complete-onboarding` does. Best-effort: `onboarding_completed_at_unix` stays null on failure, and that call can be retried.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("complete_onboarding")]
        public bool? CompleteOnboarding { get; set; }

        /// <summary>
        /// Your own key-value pairs for the workspace, such as your customer or contract id. Up to 20 keys of up to 40 characters, without `.` or `$`, and values of up to 500 characters. Not shown to the workspace's members.<br/>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Client-generated key that makes a retry safe. The same key and body within 24 hours returns the first result without running again. While that first request is still running, a retry gets 409 `idempotency_key_in_progress`; a different body with the same key gets 400 `idempotency_key_reused`. A request that fails is not saved, so it can be retried with the same key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idempotency_key")]
        public string? IdempotencyKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReceptionProvisionResellerWorkspaceRequest" /> class.
        /// </summary>
        /// <param name="businessName"></param>
        /// <param name="vertical">
        /// The business's vertical, used with `complete_onboarding`. Without it, onboarding picks the vertical as usual.
        /// </param>
        /// <param name="chargeCustomer">
        /// Bill the workspace's own customer instead of the reseller: it checks out and sees its billing itself, and the reseller earns a commission. Only for a reseller on standard billing.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="subscription">
        /// Paid tier to subscribe to. Omitted leaves the workspace with no subscription.
        /// </param>
        /// <param name="phoneNumber">
        /// A free number from the reseller's phone pool, reserved for the workspace until onboarding binds it to the receptionist.
        /// </param>
        /// <param name="members">
        /// People to invite once the workspace exists, capped by the tier's team size. Best-effort: each outcome is in `member_results`.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="completeOnboarding">
        /// Finish setup right away, as `POST /v1/reception/reseller/workspaces/{workspace_id}/complete-onboarding` does. Best-effort: `onboarding_completed_at_unix` stays null on failure, and that call can be retried.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="metadata">
        /// Your own key-value pairs for the workspace, such as your customer or contract id. Up to 20 keys of up to 40 characters, without `.` or `$`, and values of up to 500 characters. Not shown to the workspace's members.<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="idempotencyKey">
        /// Client-generated key that makes a retry safe. The same key and body within 24 hours returns the first result without running again. While that first request is still running, a retry gets 409 `idempotency_key_in_progress`; a different body with the same key gets 400 `idempotency_key_reused`. A request that fails is not saved, so it can be retried with the same key.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReceptionProvisionResellerWorkspaceRequest(
            string businessName,
            global::ElevenLabs.ReceptionVertical? vertical,
            bool? chargeCustomer,
            global::ElevenLabs.ProvisionResellerWorkspaceSubscription? subscription,
            string? phoneNumber,
            global::System.Collections.Generic.IList<global::ElevenLabs.TeamInviteRequest>? members,
            bool? completeOnboarding,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            string? idempotencyKey)
        {
            this.BusinessName = businessName ?? throw new global::System.ArgumentNullException(nameof(businessName));
            this.Vertical = vertical;
            this.ChargeCustomer = chargeCustomer;
            this.Subscription = subscription;
            this.PhoneNumber = phoneNumber;
            this.Members = members;
            this.CompleteOnboarding = completeOnboarding;
            this.Metadata = metadata;
            this.IdempotencyKey = idempotencyKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReceptionProvisionResellerWorkspaceRequest" /> class.
        /// </summary>
        public ReceptionProvisionResellerWorkspaceRequest()
        {
        }

    }
}