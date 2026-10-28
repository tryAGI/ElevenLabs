
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: monthly_period
    /// </summary>
    public enum AssignResellerTierRequestBillingPeriod
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
    public static class AssignResellerTierRequestBillingPeriodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssignResellerTierRequestBillingPeriod value)
        {
            return value switch
            {
                AssignResellerTierRequestBillingPeriod.AnnualPeriod => "annual_period",
                AssignResellerTierRequestBillingPeriod.MonthlyPeriod => "monthly_period",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssignResellerTierRequestBillingPeriod? ToEnum(string value)
        {
            return value switch
            {
                "annual_period" => AssignResellerTierRequestBillingPeriod.AnnualPeriod,
                "monthly_period" => AssignResellerTierRequestBillingPeriod.MonthlyPeriod,
                _ => null,
            };
        }
    }
}