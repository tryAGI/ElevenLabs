
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// How much the model adheres to the context of its surrounding chunks. Low adherence means the model can deviate from the context and be more creative. High adherence means the model will be more consistent with the context.<br/>
    /// Default Value: high
    /// </summary>
    public enum GenerationChunkOutputContextAdherence
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
    public static class GenerationChunkOutputContextAdherenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationChunkOutputContextAdherence value)
        {
            return value switch
            {
                GenerationChunkOutputContextAdherence.High => "high",
                GenerationChunkOutputContextAdherence.Low => "low",
                GenerationChunkOutputContextAdherence.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationChunkOutputContextAdherence? ToEnum(string value)
        {
            return value switch
            {
                "high" => GenerationChunkOutputContextAdherence.High,
                "low" => GenerationChunkOutputContextAdherence.Low,
                "medium" => GenerationChunkOutputContextAdherence.Medium,
                _ => null,
            };
        }
    }
}