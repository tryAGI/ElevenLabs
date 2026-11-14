
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A tier's prices and the limits shown on its tier card.
    /// </summary>
    public sealed partial class ResellerTierEconomics
    {
        /// <summary>
        /// What one month is sold for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly_price_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MonthlyPriceUsd { get; set; }

        /// <summary>
        /// What a year up front is sold for. Null for the trial.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annual_price_usd")]
        public double? AnnualPriceUsd { get; set; }

        /// <summary>
        /// Phone minutes included each month. A web minute draws half a minute, a chat message a tenth.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("included_minutes_per_month")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double IncludedMinutesPerMonth { get; set; }

        /// <summary>
        /// Charged per minute past the included ones. Null for the trial.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overage_price_per_minute_usd")]
        public double? OveragePricePerMinuteUsd { get; set; }

        /// <summary>
        /// Phone numbers a workspace on this tier can hold at once.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_phone_numbers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxPhoneNumbers { get; set; }

        /// <summary>
        /// Calls a workspace on this tier can take at the same time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrent_calls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ConcurrentCalls { get; set; }

        /// <summary>
        /// Business locations a workspace on this tier can have active.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_active_locations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxActiveLocations { get; set; }

        /// <summary>
        /// Receptionists a workspace on this tier can have active.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_customer_facing_agents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxCustomerFacingAgents { get; set; }

        /// <summary>
        /// Team members a workspace on this tier can have, counting pending invites.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_team_members")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxTeamMembers { get; set; }

        /// <summary>
        /// Messages the owner can send the Assistant each day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistant_daily_messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AssistantDailyMessages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResellerTierEconomics" /> class.
        /// </summary>
        /// <param name="monthlyPriceUsd">
        /// What one month is sold for.
        /// </param>
        /// <param name="includedMinutesPerMonth">
        /// Phone minutes included each month. A web minute draws half a minute, a chat message a tenth.
        /// </param>
        /// <param name="maxPhoneNumbers">
        /// Phone numbers a workspace on this tier can hold at once.
        /// </param>
        /// <param name="concurrentCalls">
        /// Calls a workspace on this tier can take at the same time.
        /// </param>
        /// <param name="maxActiveLocations">
        /// Business locations a workspace on this tier can have active.
        /// </param>
        /// <param name="maxCustomerFacingAgents">
        /// Receptionists a workspace on this tier can have active.
        /// </param>
        /// <param name="maxTeamMembers">
        /// Team members a workspace on this tier can have, counting pending invites.
        /// </param>
        /// <param name="assistantDailyMessages">
        /// Messages the owner can send the Assistant each day.
        /// </param>
        /// <param name="annualPriceUsd">
        /// What a year up front is sold for. Null for the trial.
        /// </param>
        /// <param name="overagePricePerMinuteUsd">
        /// Charged per minute past the included ones. Null for the trial.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResellerTierEconomics(
            double monthlyPriceUsd,
            double includedMinutesPerMonth,
            int maxPhoneNumbers,
            int concurrentCalls,
            int maxActiveLocations,
            int maxCustomerFacingAgents,
            int maxTeamMembers,
            int assistantDailyMessages,
            double? annualPriceUsd,
            double? overagePricePerMinuteUsd)
        {
            this.MonthlyPriceUsd = monthlyPriceUsd;
            this.AnnualPriceUsd = annualPriceUsd;
            this.IncludedMinutesPerMonth = includedMinutesPerMonth;
            this.OveragePricePerMinuteUsd = overagePricePerMinuteUsd;
            this.MaxPhoneNumbers = maxPhoneNumbers;
            this.ConcurrentCalls = concurrentCalls;
            this.MaxActiveLocations = maxActiveLocations;
            this.MaxCustomerFacingAgents = maxCustomerFacingAgents;
            this.MaxTeamMembers = maxTeamMembers;
            this.AssistantDailyMessages = assistantDailyMessages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResellerTierEconomics" /> class.
        /// </summary>
        public ResellerTierEconomics()
        {
        }

    }
}