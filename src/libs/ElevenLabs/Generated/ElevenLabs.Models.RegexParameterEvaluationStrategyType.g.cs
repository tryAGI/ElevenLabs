
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum RegexParameterEvaluationStrategyType
    {
        /// <summary>
        /// 
        /// </summary>
        Regex,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RegexParameterEvaluationStrategyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegexParameterEvaluationStrategyType value)
        {
            return value switch
            {
                RegexParameterEvaluationStrategyType.Regex => "regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegexParameterEvaluationStrategyType? ToEnum(string value)
        {
            return value switch
            {
                "regex" => RegexParameterEvaluationStrategyType.Regex,
                _ => null,
            };
        }
    }
}