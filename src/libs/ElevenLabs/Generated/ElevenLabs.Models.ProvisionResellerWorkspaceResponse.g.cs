
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProvisionResellerWorkspaceResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkspaceId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("business_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BusinessName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing_tier")]
        public string? BillingTier { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("receptionist_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ReceptionistCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calls_last_30_days")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CallsLast30Days { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAtUnix { get; set; }

        /// <summary>
        /// The reseller-managed subscription, when this workspace has one. None means the reseller sells nothing here: no tier is assigned yet, or the workspace pays for its own subscription (see charge_customer).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription")]
        public global::ElevenLabs.ResellerWorkspaceSubscription? Subscription { get; set; }

        /// <summary>
        /// The workspace pays for its own subscription, so its tier can't be assigned or changed here.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("charge_customer")]
        public bool? ChargeCustomer { get; set; }

        /// <summary>
        /// A charge for this workspace is unpaid. Assigning or changing a tier is refused until it clears, so surface it rather than letting it fail.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_payment_issue")]
        public bool? HasPaymentIssue { get; set; }

        /// <summary>
        /// The customer's main contact: the email of the workspace's earliest admin that is a person. None until someone invited as admin joins.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_email")]
        public string? OwnerEmail { get; set; }

        /// <summary>
        /// When onboarding finished. Until then the onboarding wizard may replace or remove the workspace's business data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("onboarding_completed_at_unix")]
        public int? OnboardingCompletedAtUnix { get; set; }

        /// <summary>
        /// Your own key-value pairs for the workspace.<br/>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("member_results")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.TeamInviteResult>? MemberResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProvisionResellerWorkspaceResponse" /> class.
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="businessName"></param>
        /// <param name="receptionistCount"></param>
        /// <param name="callsLast30Days"></param>
        /// <param name="createdAtUnix"></param>
        /// <param name="billingTier"></param>
        /// <param name="subscription">
        /// The reseller-managed subscription, when this workspace has one. None means the reseller sells nothing here: no tier is assigned yet, or the workspace pays for its own subscription (see charge_customer).
        /// </param>
        /// <param name="chargeCustomer">
        /// The workspace pays for its own subscription, so its tier can't be assigned or changed here.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="hasPaymentIssue">
        /// A charge for this workspace is unpaid. Assigning or changing a tier is refused until it clears, so surface it rather than letting it fail.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="ownerEmail">
        /// The customer's main contact: the email of the workspace's earliest admin that is a person. None until someone invited as admin joins.
        /// </param>
        /// <param name="onboardingCompletedAtUnix">
        /// When onboarding finished. Until then the onboarding wizard may replace or remove the workspace's business data.
        /// </param>
        /// <param name="metadata">
        /// Your own key-value pairs for the workspace.<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="memberResults">
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProvisionResellerWorkspaceResponse(
            string workspaceId,
            string businessName,
            int receptionistCount,
            int callsLast30Days,
            int createdAtUnix,
            string? billingTier,
            global::ElevenLabs.ResellerWorkspaceSubscription? subscription,
            bool? chargeCustomer,
            bool? hasPaymentIssue,
            string? ownerEmail,
            int? onboardingCompletedAtUnix,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::System.Collections.Generic.IList<global::ElevenLabs.TeamInviteResult>? memberResults)
        {
            this.WorkspaceId = workspaceId ?? throw new global::System.ArgumentNullException(nameof(workspaceId));
            this.BusinessName = businessName ?? throw new global::System.ArgumentNullException(nameof(businessName));
            this.BillingTier = billingTier;
            this.ReceptionistCount = receptionistCount;
            this.CallsLast30Days = callsLast30Days;
            this.CreatedAtUnix = createdAtUnix;
            this.Subscription = subscription;
            this.ChargeCustomer = chargeCustomer;
            this.HasPaymentIssue = hasPaymentIssue;
            this.OwnerEmail = ownerEmail;
            this.OnboardingCompletedAtUnix = onboardingCompletedAtUnix;
            this.Metadata = metadata;
            this.MemberResults = memberResults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProvisionResellerWorkspaceResponse" /> class.
        /// </summary>
        public ProvisionResellerWorkspaceResponse()
        {
        }

    }
}