
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum GenerationChunkInputConditionStrength2
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
    public static class GenerationChunkInputConditionStrength2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationChunkInputConditionStrength2 value)
        {
            return value switch
            {
                GenerationChunkInputConditionStrength2.High => "high",
                GenerationChunkInputConditionStrength2.Low => "low",
                GenerationChunkInputConditionStrength2.Medium => "medium",
                GenerationChunkInputConditionStrength2.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationChunkInputConditionStrength2? ToEnum(string value)
        {
            return value switch
            {
                "high" => GenerationChunkInputConditionStrength2.High,
                "low" => GenerationChunkInputConditionStrength2.Low,
                "medium" => GenerationChunkInputConditionStrength2.Medium,
                "xhigh" => GenerationChunkInputConditionStrength2.Xhigh,
                _ => null,
            };
        }
    }
}