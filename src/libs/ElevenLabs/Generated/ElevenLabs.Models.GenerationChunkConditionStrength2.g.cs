
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum GenerationChunkConditionStrength2
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
    public static class GenerationChunkConditionStrength2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationChunkConditionStrength2 value)
        {
            return value switch
            {
                GenerationChunkConditionStrength2.High => "high",
                GenerationChunkConditionStrength2.Low => "low",
                GenerationChunkConditionStrength2.Medium => "medium",
                GenerationChunkConditionStrength2.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationChunkConditionStrength2? ToEnum(string value)
        {
            return value switch
            {
                "high" => GenerationChunkConditionStrength2.High,
                "low" => GenerationChunkConditionStrength2.Low,
                "medium" => GenerationChunkConditionStrength2.Medium,
                "xhigh" => GenerationChunkConditionStrength2.Xhigh,
                _ => null,
            };
        }
    }
}