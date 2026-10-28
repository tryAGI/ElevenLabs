
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
        /// The reseller-managed subscription, when this workspace has one. None means nothing is sold here yet and a tier can be assigned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription")]
        public global::ElevenLabs.ResellerWorkspaceSubscription? Subscription { get; set; }

        /// <summary>
        /// A charge for this workspace is unpaid. Assigning or changing a tier is refused until it clears, so surface it rather than letting it fail.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_payment_issue")]
        public bool? HasPaymentIssue { get; set; }

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
        /// The reseller-managed subscription, when this workspace has one. None means nothing is sold here yet and a tier can be assigned.
        /// </param>
        /// <param name="hasPaymentIssue">
        /// A charge for this workspace is unpaid. Assigning or changing a tier is refused until it clears, so surface it rather than letting it fail.<br/>
        /// Default Value: false
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
            bool? hasPaymentIssue,
            global::System.Collections.Generic.IList<global::ElevenLabs.TeamInviteResult>? memberResults)
        {
            this.WorkspaceId = workspaceId ?? throw new global::System.ArgumentNullException(nameof(workspaceId));
            this.BusinessName = businessName ?? throw new global::System.ArgumentNullException(nameof(businessName));
            this.BillingTier = billingTier;
            this.ReceptionistCount = receptionistCount;
            this.CallsLast30Days = callsLast30Days;
            this.CreatedAtUnix = createdAtUnix;
            this.Subscription = subscription;
            this.HasPaymentIssue = hasPaymentIssue;
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