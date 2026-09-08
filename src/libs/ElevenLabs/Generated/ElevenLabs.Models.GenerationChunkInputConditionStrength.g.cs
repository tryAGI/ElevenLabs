
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum GenerationChunkInputConditionStrength
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
    public static class GenerationChunkInputConditionStrengthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationChunkInputConditionStrength value)
        {
            return value switch
            {
                GenerationChunkInputConditionStrength.High => "high",
                GenerationChunkInputConditionStrength.Low => "low",
                GenerationChunkInputConditionStrength.Medium => "medium",
                GenerationChunkInputConditionStrength.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationChunkInputConditionStrength? ToEnum(string value)
        {
            return value switch
            {
                "high" => GenerationChunkInputConditionStrength.High,
                "low" => GenerationChunkInputConditionStrength.Low,
                "medium" => GenerationChunkInputConditionStrength.Medium,
                "xhigh" => GenerationChunkInputConditionStrength.Xhigh,
                _ => null,
            };
        }
    }
}