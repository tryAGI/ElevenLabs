
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: monthly_period
    /// </summary>
    public enum ProvisionResellerWorkspaceSubscriptionBillingPeriod
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
    public static class ProvisionResellerWorkspaceSubscriptionBillingPeriodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProvisionResellerWorkspaceSubscriptionBillingPeriod value)
        {
            return value switch
            {
                ProvisionResellerWorkspaceSubscriptionBillingPeriod.AnnualPeriod => "annual_period",
                ProvisionResellerWorkspaceSubscriptionBillingPeriod.MonthlyPeriod => "monthly_period",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProvisionResellerWorkspaceSubscriptionBillingPeriod? ToEnum(string value)
        {
            return value switch
            {
                "annual_period" => ProvisionResellerWorkspaceSubscriptionBillingPeriod.AnnualPeriod,
                "monthly_period" => ProvisionResellerWorkspaceSubscriptionBillingPeriod.MonthlyPeriod,
                _ => null,
            };
        }
    }
}