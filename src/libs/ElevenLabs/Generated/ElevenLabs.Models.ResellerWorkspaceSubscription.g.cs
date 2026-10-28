
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A reseller-managed paid subscription, as the reseller can act on it.<br/>
    /// Present only for a workspace the reseller actually sells to: untiered and<br/>
    /// trial workspaces have no subscription to change or end, and are assigned to<br/>
    /// instead. Projected from ``SMBBillingState`` rather than read from Stripe,<br/>
    /// so it is the same state the grant path wrote.
    /// </summary>
    public sealed partial class ResellerWorkspaceSubscription
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TierId { get; set; }

        /// <summary>
        /// Cadence being billed. None only for a subscription mid-provisioning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing_period")]
        public global::ElevenLabs.ResellerWorkspaceSubscriptionBillingPeriod? BillingPeriod { get; set; }

        /// <summary>
        /// When the current period ends, and so when a deferred change lands.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing_period_end_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BillingPeriodEndUnix { get; set; }

        /// <summary>
        /// When Stripe will end the subscription. Set means a pending unassignment the reseller can still undo.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancel_at_unix")]
        public int? CancelAtUnix { get; set; }

        /// <summary>
        /// Tier this workspace drops to at the period boundary, if a downgrade is already scheduled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_downgrade_tier")]
        public string? PendingDowngradeTier { get; set; }

        /// <summary>
        /// When that scheduled downgrade takes effect.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_downgrade_at_unix")]
        public int? PendingDowngradeAtUnix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResellerWorkspaceSubscription" /> class.
        /// </summary>
        /// <param name="tierId"></param>
        /// <param name="billingPeriodEndUnix">
        /// When the current period ends, and so when a deferred change lands.
        /// </param>
        /// <param name="billingPeriod">
        /// Cadence being billed. None only for a subscription mid-provisioning.
        /// </param>
        /// <param name="cancelAtUnix">
        /// When Stripe will end the subscription. Set means a pending unassignment the reseller can still undo.
        /// </param>
        /// <param name="pendingDowngradeTier">
        /// Tier this workspace drops to at the period boundary, if a downgrade is already scheduled.
        /// </param>
        /// <param name="pendingDowngradeAtUnix">
        /// When that scheduled downgrade takes effect.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResellerWorkspaceSubscription(
            string tierId,
            int billingPeriodEndUnix,
            global::ElevenLabs.ResellerWorkspaceSubscriptionBillingPeriod? billingPeriod,
            int? cancelAtUnix,
            string? pendingDowngradeTier,
            int? pendingDowngradeAtUnix)
        {
            this.TierId = tierId ?? throw new global::System.ArgumentNullException(nameof(tierId));
            this.BillingPeriod = billingPeriod;
            this.BillingPeriodEndUnix = billingPeriodEndUnix;
            this.CancelAtUnix = cancelAtUnix;
            this.PendingDowngradeTier = pendingDowngradeTier;
            this.PendingDowngradeAtUnix = pendingDowngradeAtUnix;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResellerWorkspaceSubscription" /> class.
        /// </summary>
        public ResellerWorkspaceSubscription()
        {
        }

    }
}