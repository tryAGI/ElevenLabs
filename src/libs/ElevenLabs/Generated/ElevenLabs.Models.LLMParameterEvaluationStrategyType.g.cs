
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum LLMParameterEvaluationStrategyType
    {
        /// <summary>
        /// 
        /// </summary>
        Llm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LLMParameterEvaluationStrategyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMParameterEvaluationStrategyType value)
        {
            return value switch
            {
                LLMParameterEvaluationStrategyType.Llm => "llm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMParameterEvaluationStrategyType? ToEnum(string value)
        {
            return value switch
            {
                "llm" => LLMParameterEvaluationStrategyType.Llm,
                _ => null,
            };
        }
    }
}