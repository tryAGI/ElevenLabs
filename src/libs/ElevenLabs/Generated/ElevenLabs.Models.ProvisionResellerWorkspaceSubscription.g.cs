
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProvisionResellerWorkspaceSubscription
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TierId { get; set; }

        /// <summary>
        /// Default Value: monthly_period
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing_period")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ProvisionResellerWorkspaceSubscriptionBillingPeriodJsonConverter))]
        public global::ElevenLabs.ProvisionResellerWorkspaceSubscriptionBillingPeriod? BillingPeriod { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProvisionResellerWorkspaceSubscription" /> class.
        /// </summary>
        /// <param name="tierId"></param>
        /// <param name="billingPeriod">
        /// Default Value: monthly_period
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProvisionResellerWorkspaceSubscription(
            string tierId,
            global::ElevenLabs.ProvisionResellerWorkspaceSubscriptionBillingPeriod? billingPeriod)
        {
            this.TierId = tierId ?? throw new global::System.ArgumentNullException(nameof(tierId));
            this.BillingPeriod = billingPeriod;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProvisionResellerWorkspaceSubscription" /> class.
        /// </summary>
        public ProvisionResellerWorkspaceSubscription()
        {
        }

    }
}