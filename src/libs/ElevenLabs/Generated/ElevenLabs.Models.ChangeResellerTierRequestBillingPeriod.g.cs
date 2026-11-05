
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: monthly_period
    /// </summary>
    public enum ChangeResellerTierRequestBillingPeriod
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
    public static class ChangeResellerTierRequestBillingPeriodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChangeResellerTierRequestBillingPeriod value)
        {
            return value switch
            {
                ChangeResellerTierRequestBillingPeriod.AnnualPeriod => "annual_period",
                ChangeResellerTierRequestBillingPeriod.MonthlyPeriod => "monthly_period",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChangeResellerTierRequestBillingPeriod? ToEnum(string value)
        {
            return value switch
            {
                "annual_period" => ChangeResellerTierRequestBillingPeriod.AnnualPeriod,
                "monthly_period" => ChangeResellerTierRequestBillingPeriod.MonthlyPeriod,
                _ => null,
            };
        }
    }
}