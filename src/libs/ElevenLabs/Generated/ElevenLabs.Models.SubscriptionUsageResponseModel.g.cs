
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubscriptionUsageResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rollover_credits_quota")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RolloverCreditsQuota { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription_cycle_credits_quota")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SubscriptionCycleCreditsQuota { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manually_gifted_credits_quota")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ManuallyGiftedCreditsQuota { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rollover_credits_used")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RolloverCreditsUsed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription_cycle_credits_used")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SubscriptionCycleCreditsUsed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manually_gifted_credits_used")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ManuallyGiftedCreditsUsed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paid_usage_based_credits_used")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PaidUsageBasedCreditsUsed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actual_reported_credits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ActualReportedCredits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionUsageResponseModel" /> class.
        /// </summary>
        /// <param name="rolloverCreditsQuota"></param>
        /// <param name="subscriptionCycleCreditsQuota"></param>
        /// <param name="manuallyGiftedCreditsQuota"></param>
        /// <param name="rolloverCreditsUsed"></param>
        /// <param name="subscriptionCycleCreditsUsed"></param>
        /// <param name="manuallyGiftedCreditsUsed"></param>
        /// <param name="paidUsageBasedCreditsUsed"></param>
        /// <param name="actualReportedCredits"></param>
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