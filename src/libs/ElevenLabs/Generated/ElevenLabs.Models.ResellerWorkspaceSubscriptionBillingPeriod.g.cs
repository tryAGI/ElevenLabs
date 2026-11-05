
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum ResellerWorkspaceSubscriptionBillingPeriod
    {
        /// <summary>
        ///
        /// </summary>
        AnnualPeriod,
        /// <summary>
        ///
        /// </summary>
        MonthlyPeriod,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResellerWorkspaceSubscriptionBillingPeriodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResellerWorkspaceSubscriptionBillingPeriod value)
        {
            return value switch
            {
                ResellerWorkspaceSubscriptionBillingPeriod.AnnualPeriod => "annual_period",
                ResellerWorkspaceSubscriptionBillingPeriod.MonthlyPeriod => "monthly_period",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResellerWorkspaceSubscriptionBillingPeriod? ToEnum(string value)
        {
            return value switch
            {
                "annual_period" => ResellerWorkspaceSubscriptionBillingPeriod.AnnualPeriod,
                "monthly_period" => ResellerWorkspaceSubscriptionBillingPeriod.MonthlyPeriod,
                _ => null,
            };
        }
    }
}