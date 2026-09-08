
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum GenerationChunkOutputConditionStrength
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
    public static class GenerationChunkOutputConditionStrengthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationChunkOutputConditionStrength value)
        {
            return value switch
            {
                GenerationChunkOutputConditionStrength.High => "high",
                GenerationChunkOutputConditionStrength.Low => "low",
                GenerationChunkOutputConditionStrength.Medium => "medium",
                GenerationChunkOutputConditionStrength.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationChunkOutputConditionStrength? ToEnum(string value)
        {
            return value switch
            {
                "high" => GenerationChunkOutputConditionStrength.High,
                "low" => GenerationChunkOutputConditionStrength.Low,
                "medium" => GenerationChunkOutputConditionStrength.Medium,
                "xhigh" => GenerationChunkOutputConditionStrength.Xhigh,
                _ => null,
            };
        }
    }
}