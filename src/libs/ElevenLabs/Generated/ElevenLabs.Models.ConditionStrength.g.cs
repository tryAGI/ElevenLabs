
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum ConditionStrength
    {
        /// <summary>
        ///
        /// </summary>
        High,
        /// <summary>
        ///
        /// </summary>
        Low,
        /// <summary>
        ///
        /// </summary>
        Medium,
        /// <summary>
        ///
        /// </summary>
        Xhigh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConditionStrengthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConditionStrength value)
        {
            return value switch
            {
                ConditionStrength.High => "high",
                ConditionStrength.Low => "low",
                ConditionStrength.Medium => "medium",
                ConditionStrength.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConditionStrength? ToEnum(string value)
        {
            return value switch
            {
                "high" => ConditionStrength.High,
                "low" => ConditionStrength.Low,
                "medium" => ConditionStrength.Medium,
                "xhigh" => ConditionStrength.Xhigh,
                _ => null,
            };
        }
    }
}