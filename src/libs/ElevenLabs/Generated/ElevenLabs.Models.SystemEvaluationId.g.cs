
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum SystemEvaluationId
    {
        /// <summary>
        ///
        /// </summary>
        SystemEvalCriteriaFrustration,
        /// <summary>
        ///
        /// </summary>
        SystemEvalCriteriaSentiment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SystemEvaluationIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SystemEvaluationId value)
        {
            return value switch
            {
                SystemEvaluationId.SystemEvalCriteriaFrustration => "__system_eval_criteria_frustration",
                SystemEvaluationId.SystemEvalCriteriaSentiment => "__system_eval_criteria_sentiment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SystemEvaluationId? ToEnum(string value)
        {
            return value switch
            {
                "__system_eval_criteria_frustration" => SystemEvaluationId.SystemEvalCriteriaFrustration,
                "__system_eval_criteria_sentiment" => SystemEvaluationId.SystemEvalCriteriaSentiment,
                _ => null,
            };
        }
    }
}