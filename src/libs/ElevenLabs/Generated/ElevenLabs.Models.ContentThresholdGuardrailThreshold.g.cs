
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
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
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
                ContentThresholdGuardrailThreshold.High => "high",
                ContentThresholdGuardrailThreshold.Low => "low",
                ContentThresholdGuardrailThreshold.Medium => "medium",
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
                "high" => ContentThresholdGuardrailThreshold.High,
                "low" => ContentThresholdGuardrailThreshold.Low,
                "medium" => ContentThresholdGuardrailThreshold.Medium,
                _ => null,
            };
        }
    }
}