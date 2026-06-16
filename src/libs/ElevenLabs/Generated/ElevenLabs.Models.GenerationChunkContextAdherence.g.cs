
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// How much the model adheres to the context of its surrounding chunks. Low adherence means the model can deviate from the context and be more creative. High adherence means the model will be more consistent with the context.<br/>
    /// Default Value: high
    /// </summary>
    public enum GenerationChunkContextAdherence
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
    public static class GenerationChunkContextAdherenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationChunkContextAdherence value)
        {
            return value switch
            {
                GenerationChunkContextAdherence.High => "high",
                GenerationChunkContextAdherence.Low => "low",
                GenerationChunkContextAdherence.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationChunkContextAdherence? ToEnum(string value)
        {
            return value switch
            {
                "high" => GenerationChunkContextAdherence.High,
                "low" => GenerationChunkContextAdherence.Low,
                "medium" => GenerationChunkContextAdherence.Medium,
                _ => null,
            };
        }
    }
}