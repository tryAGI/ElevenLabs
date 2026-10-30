
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A workspace's next renewal, estimated before Stripe drafts the invoice.
    /// </summary>
    public sealed partial class ResellerUpcomingPayment
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
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkspaceName { get; set; }

        /// <summary>
        /// A reseller-managed paid subscription, as the reseller can act on it.<br/>
        /// Present only for a workspace the reseller actually sells to: untiered and<br/>
        /// trial workspaces have no subscription to change or end, and are assigned to<br/>
        /// instead. Projected from ``SMBBillingState`` rather than read from Stripe,<br/>
        /// so it is the same state the grant path wrote.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ResellerWorkspaceSubscription Subscription { get; set; }

        /// <summary>
        /// The plan the renewal charges upfront: the pending downgrade's tier when there is one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PlanUsd { get; set; }

        /// <summary>
        /// This period's usage beyond its included minutes so far, charged at the renewal and still growing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overage_so_far_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double OverageSoFarUsd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResellerUpcomingPayment" /> class.
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="workspaceName"></param>
        /// <param name="subscription">
        /// A reseller-managed paid subscription, as the reseller can act on it.<br/>
        /// Present only for a workspace the reseller actually sells to: untiered and<br/>
        /// trial workspaces have no subscription to change or end, and are assigned to<br/>
        /// instead. Projected from ``SMBBillingState`` rather than read from Stripe,<br/>
        /// so it is the same state the grant path wrote.
        /// </param>
        /// <param name="planUsd">
        /// The plan the renewal charges upfront: the pending downgrade's tier when there is one.
        /// </param>
        /// <param name="overageSoFarUsd">
        /// This period's usage beyond its included minutes so far, charged at the renewal and still growing.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResellerUpcomingPayment(
            string workspaceId,
            string workspaceName,
            global::ElevenLabs.ResellerWorkspaceSubscription subscription,
            double planUsd,
            double overageSoFarUsd)
        {
            this.WorkspaceId = workspaceId ?? throw new global::System.ArgumentNullException(nameof(workspaceId));
            this.WorkspaceName = workspaceName ?? throw new global::System.ArgumentNullException(nameof(workspaceName));
            this.Subscription = subscription ?? throw new global::System.ArgumentNullException(nameof(subscription));
            this.PlanUsd = planUsd;
            this.OverageSoFarUsd = overageSoFarUsd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResellerUpcomingPayment" /> class.
        /// </summary>
        public ResellerUpcomingPayment()
        {
        }

    }
}