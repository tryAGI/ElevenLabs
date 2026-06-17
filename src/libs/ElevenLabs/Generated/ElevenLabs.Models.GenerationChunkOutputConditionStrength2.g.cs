
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum GenerationChunkOutputConditionStrength2
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
    public static class GenerationChunkOutputConditionStrength2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationChunkOutputConditionStrength2 value)
        {
            return value switch
            {
                GenerationChunkOutputConditionStrength2.High => "high",
                GenerationChunkOutputConditionStrength2.Low => "low",
                GenerationChunkOutputConditionStrength2.Medium => "medium",
                GenerationChunkOutputConditionStrength2.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationChunkOutputConditionStrength2? ToEnum(string value)
        {
            return value switch
            {
                "high" => GenerationChunkOutputConditionStrength2.High,
                "low" => GenerationChunkOutputConditionStrength2.Low,
                "medium" => GenerationChunkOutputConditionStrength2.Medium,
                "xhigh" => GenerationChunkOutputConditionStrength2.Xhigh,
                _ => null,
            };
        }
    }
}