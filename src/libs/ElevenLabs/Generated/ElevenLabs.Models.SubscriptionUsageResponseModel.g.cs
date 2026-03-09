
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"actual_reported_credits":1000,"manually_gifted_credits_quota":1000,"manually_gifted_credits_used":1000,"paid_usage_based_credits_used":1000,"rollover_credits_quota":1000,"rollover_credits_used":1000,"subscription_cycle_credits_quota":1000,"subscription_cycle_credits_used":1000}
    /// </summary>
    public sealed partial class SubscriptionUsageResponseModel
    {
        /// <summary>
        /// The rollover credits quota.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rollover_credits_quota")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int RolloverCreditsQuota { get; set; } = default!;

        /// <summary>
        /// The subscription cycle credits quota.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription_cycle_credits_quota")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int SubscriptionCycleCreditsQuota { get; set; } = default!;

        /// <summary>
        /// The manually gifted credits quota.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manually_gifted_credits_quota")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int ManuallyGiftedCreditsQuota { get; set; } = default!;

        /// <summary>
        /// The rollover credits used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rollover_credits_used")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int RolloverCreditsUsed { get; set; } = default!;

        /// <summary>
        /// The subscription cycle credits used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription_cycle_credits_used")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int SubscriptionCycleCreditsUsed { get; set; } = default!;

        /// <summary>
        /// The manually gifted credits used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manually_gifted_credits_used")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int ManuallyGiftedCreditsUsed { get; set; } = default!;

        /// <summary>
        /// The paid usage based credits used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paid_usage_based_credits_used")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int PaidUsageBasedCreditsUsed { get; set; } = default!;

        /// <summary>
        /// The actual reported credits.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actual_reported_credits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int ActualReportedCredits { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionUsageResponseModel" /> class.
        /// </summary>
        /// <param name="rolloverCreditsQuota">
        /// The rollover credits quota.
        /// </param>
        /// <param name="subscriptionCycleCreditsQuota">
        /// The subscription cycle credits quota.
        /// </param>
        /// <param name="manuallyGiftedCreditsQuota">
        /// The manually gifted credits quota.
        /// </param>
        /// <param name="rolloverCreditsUsed">
        /// The rollover credits used.
        /// </param>
        /// <param name="subscriptionCycleCreditsUsed">
        /// The subscription cycle credits used.
        /// </param>
        /// <param name="manuallyGiftedCreditsUsed">
        /// The manually gifted credits used.
        /// </param>
        /// <param name="paidUsageBasedCreditsUsed">
        /// The paid usage based credits used.
        /// </param>
        /// <param name="actualReportedCredits">
        /// The actual reported credits.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionUsageResponseModel(
            int rolloverCreditsQuota,
            int subscriptionCycleCreditsQuota,
            int manuallyGiftedCreditsQuota,
            int rolloverCreditsUsed,
            int subscriptionCycleCreditsUsed,
            int manuallyGiftedCreditsUsed,
            int paidUsageBasedCreditsUsed,
            int actualReportedCredits)
        {
            this.RolloverCreditsQuota = rolloverCreditsQuota;
            this.SubscriptionCycleCreditsQuota = subscriptionCycleCreditsQuota;
            this.ManuallyGiftedCreditsQuota = manuallyGiftedCreditsQuota;
            this.RolloverCreditsUsed = rolloverCreditsUsed;
            this.SubscriptionCycleCreditsUsed = subscriptionCycleCreditsUsed;
            this.ManuallyGiftedCreditsUsed = manuallyGiftedCreditsUsed;
            this.PaidUsageBasedCreditsUsed = paidUsageBasedCreditsUsed;
            this.ActualReportedCredits = actualReportedCredits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionUsageResponseModel" /> class.
        /// </summary>
        public SubscriptionUsageResponseModel()
        {
        }
    }
}