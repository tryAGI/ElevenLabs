
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A tier's prices and quotas, in the fields a tier is created with.
    /// </summary>
    public sealed partial class SMBTierEconomics
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistant_daily_messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AssistantDailyMessages { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pool_outbound_sms_daily_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PoolOutboundSmsDailyLimit { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_phone_numbers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxPhoneNumbers { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_active_locations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxActiveLocations { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge_source_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int KnowledgeSourceLimit { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrent_calls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ConcurrentCalls { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_customer_facing_agents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxCustomerFacingAgents { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_team_members")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxTeamMembers { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ivc_voice_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int IvcVoiceLimit { get; set; }

        /// <summary>
        /// What one month is sold for. Also values an included minute, at this price over the included minutes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly_price_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MonthlyPriceUsd { get; set; }

        /// <summary>
        /// What a year up front is sold for, at a discount on twelve months. Required for a tier on the ladder, omitted for the trial
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annual_price_usd")]
        public double? AnnualPriceUsd { get; set; }

        /// <summary>
        /// Phone minutes included each month. Other channels draw on the same allowance more cheaply — a web minute costs half a phone minute, a chat message a tenth
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("included_minutes_per_month")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double IncludedMinutesPerMonth { get; set; }

        /// <summary>
        /// Charged per minute past the included ones, and may not undercut their value. Required for a tier on the ladder, omitted for the trial
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overage_price_per_minute_usd")]
        public double? OveragePricePerMinuteUsd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SMBTierEconomics" /> class.
        /// </summary>
        /// <param name="assistantDailyMessages"></param>
        /// <param name="poolOutboundSmsDailyLimit"></param>
        /// <param name="maxPhoneNumbers"></param>
        /// <param name="maxActiveLocations"></param>
        /// <param name="knowledgeSourceLimit"></param>
        /// <param name="concurrentCalls"></param>
        /// <param name="maxCustomerFacingAgents"></param>
        /// <param name="maxTeamMembers"></param>
        /// <param name="ivcVoiceLimit"></param>
        /// <param name="monthlyPriceUsd">
        /// What one month is sold for. Also values an included minute, at this price over the included minutes
        /// </param>
        /// <param name="includedMinutesPerMonth">
        /// Phone minutes included each month. Other channels draw on the same allowance more cheaply — a web minute costs half a phone minute, a chat message a tenth
        /// </param>
        /// <param name="annualPriceUsd">
        /// What a year up front is sold for, at a discount on twelve months. Required for a tier on the ladder, omitted for the trial
        /// </param>
        /// <param name="overagePricePerMinuteUsd">
        /// Charged per minute past the included ones, and may not undercut their value. Required for a tier on the ladder, omitted for the trial
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SMBTierEconomics(
            int assistantDailyMessages,
            int poolOutboundSmsDailyLimit,
            int maxPhoneNumbers,
            int maxActiveLocations,
            int knowledgeSourceLimit,
            int concurrentCalls,
            int maxCustomerFacingAgents,
            int maxTeamMembers,
            int ivcVoiceLimit,
            double monthlyPriceUsd,
            double includedMinutesPerMonth,
            double? annualPriceUsd,
            double? overagePricePerMinuteUsd)
        {
            this.AssistantDailyMessages = assistantDailyMessages;
            this.PoolOutboundSmsDailyLimit = poolOutboundSmsDailyLimit;
            this.MaxPhoneNumbers = maxPhoneNumbers;
            this.MaxActiveLocations = maxActiveLocations;
            this.KnowledgeSourceLimit = knowledgeSourceLimit;
            this.ConcurrentCalls = concurrentCalls;
            this.MaxCustomerFacingAgents = maxCustomerFacingAgents;
            this.MaxTeamMembers = maxTeamMembers;
            this.IvcVoiceLimit = ivcVoiceLimit;
            this.MonthlyPriceUsd = monthlyPriceUsd;
            this.AnnualPriceUsd = annualPriceUsd;
            this.IncludedMinutesPerMonth = includedMinutesPerMonth;
            this.OveragePricePerMinuteUsd = overagePricePerMinuteUsd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SMBTierEconomics" /> class.
        /// </summary>
        public SMBTierEconomics()
        {
        }

    }
}