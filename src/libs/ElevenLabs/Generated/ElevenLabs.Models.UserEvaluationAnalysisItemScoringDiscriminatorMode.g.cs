
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum UserEvaluationAnalysisItemScoringDiscriminatorMode
    {
        /// <summary>
        ///
        /// </summary>
        Binary,
        /// <summary>
        ///
        /// </summary>
        NumericUniform,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserEvaluationAnalysisItemScoringDiscriminatorModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserEvaluationAnalysisItemScoringDiscriminatorMode value)
        {
            return value switch
            {
                UserEvaluationAnalysisItemScoringDiscriminatorMode.Binary => "binary",
                UserEvaluationAnalysisItemScoringDiscriminatorMode.NumericUniform => "numeric_uniform",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserEvaluationAnalysisItemScoringDiscriminatorMode? ToEnum(string value)
        {
            return value switch
            {
                "binary" => UserEvaluationAnalysisItemScoringDiscriminatorMode.Binary,
                "numeric_uniform" => UserEvaluationAnalysisItemScoringDiscriminatorMode.NumericUniform,
                _ => null,
            };
        }
    }
}