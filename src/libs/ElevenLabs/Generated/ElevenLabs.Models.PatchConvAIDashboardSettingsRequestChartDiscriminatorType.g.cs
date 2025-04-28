
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchConvAIDashboardSettingsRequestChartDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        CallSuccess,
        /// <summary>
        /// 
        /// </summary>
        Criteria,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchConvAIDashboardSettingsRequestChartDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchConvAIDashboardSettingsRequestChartDiscriminatorType value)
        {
            return value switch
            {
                PatchConvAIDashboardSettingsRequestChartDiscriminatorType.CallSuccess => "call_success",
                PatchConvAIDashboardSettingsRequestChartDiscriminatorType.Criteria => "criteria",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchConvAIDashboardSettingsRequestChartDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "call_success" => PatchConvAIDashboardSettingsRequestChartDiscriminatorType.CallSuccess,
                "criteria" => PatchConvAIDashboardSettingsRequestChartDiscriminatorType.Criteria,
                _ => null,
            };
        }
    }
}