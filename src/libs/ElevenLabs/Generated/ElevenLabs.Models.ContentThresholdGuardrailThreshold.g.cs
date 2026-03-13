
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ContentThresholdGuardrailThreshold
    {
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
        High,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContentThresholdGuardrailThresholdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentThresholdGuardrailThreshold value)
        {
            return value switch
            {
                ContentThresholdGuardrailThreshold.Low => "low",
                ContentThresholdGuardrailThreshold.Medium => "medium",
                ContentThresholdGuardrailThreshold.High => "high",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentThresholdGuardrailThreshold? ToEnum(string value)
        {
            return value switch
            {
                "low" => ContentThresholdGuardrailThreshold.Low,
                "medium" => ContentThresholdGuardrailThreshold.Medium,
                "high" => ContentThresholdGuardrailThreshold.High,
                _ => null,
            };
        }
    }
}