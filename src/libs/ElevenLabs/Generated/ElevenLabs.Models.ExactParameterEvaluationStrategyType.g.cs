
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExactParameterEvaluationStrategyType
    {
        /// <summary>
        /// 
        /// </summary>
        Exact,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExactParameterEvaluationStrategyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExactParameterEvaluationStrategyType value)
        {
            return value switch
            {
                ExactParameterEvaluationStrategyType.Exact => "exact",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExactParameterEvaluationStrategyType? ToEnum(string value)
        {
            return value switch
            {
                "exact" => ExactParameterEvaluationStrategyType.Exact,
                _ => null,
            };
        }
    }
}