
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Put a workspace with no subscription onto one of the reseller's tiers.
    /// </summary>
    public sealed partial class AssignResellerTierRequest
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AssignResellerTierRequestBillingPeriodJsonConverter))]
        public global::ElevenLabs.AssignResellerTierRequestBillingPeriod? BillingPeriod { get; set; }

        /// <summary>
        /// Client-generated key so a retried request cannot create or apply the same subscription change twice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idempotency_key")]
        public string? IdempotencyKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignResellerTierRequest" /> class.
        /// </summary>
        /// <param name="tierId"></param>
        /// <param name="billingPeriod">
        /// Default Value: monthly_period
        /// </param>
        /// <param name="idempotencyKey">
        /// Client-generated key so a retried request cannot create or apply the same subscription change twice.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssignResellerTierRequest(
            string tierId,
            global::ElevenLabs.AssignResellerTierRequestBillingPeriod? billingPeriod,
            string? idempotencyKey)
        {
            this.TierId = tierId ?? throw new global::System.ArgumentNullException(nameof(tierId));
            this.BillingPeriod = billingPeriod;
            this.IdempotencyKey = idempotencyKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignResellerTierRequest" /> class.
        /// </summary>
        public AssignResellerTierRequest()
        {
        }

    }
}