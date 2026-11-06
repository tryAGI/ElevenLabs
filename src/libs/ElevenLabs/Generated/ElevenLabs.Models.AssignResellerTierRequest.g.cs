
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
        /// Initializes a new instance of the <see cref="AssignResellerTierRequest" /> class.
        /// </summary>
        /// <param name="tierId"></param>
        /// <param name="billingPeriod">
        /// Default Value: monthly_period
        /// </param>
        /// <param name="idempotencyKey">
        /// Client-generated key that makes a retry safe. The same key and body within 24 hours returns the first result without running again. While that first request is still running, a retry gets 409 `idempotency_key_in_progress`; a different body with the same key gets 400 `idempotency_key_reused`. A request that fails is not saved, so it can be retried with the same key.
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