
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProvisionResellerWorkspaceRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("business_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BusinessName { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProvisionResellerWorkspaceRequest" /> class.
        /// </summary>
        /// <param name="businessName"></param>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProvisionResellerWorkspaceRequest(
            string businessName,
            global::ElevenLabs.ProvisionResellerWorkspaceSubscription? subscription,
            string? phoneNumber,
            global::System.Collections.Generic.IList<global::ElevenLabs.TeamInviteRequest>? members)
        {
            this.BusinessName = businessName ?? throw new global::System.ArgumentNullException(nameof(businessName));
            this.Subscription = subscription;
            this.PhoneNumber = phoneNumber;
            this.Members = members;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProvisionResellerWorkspaceRequest" /> class.
        /// </summary>
        public ProvisionResellerWorkspaceRequest()
        {
        }

    }
}