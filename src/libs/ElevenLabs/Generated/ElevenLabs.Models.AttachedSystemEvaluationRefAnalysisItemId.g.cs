
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Id of the referenced built-in system evaluation.
    /// </summary>
    public enum AttachedSystemEvaluationRefAnalysisItemId
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
    public static class AttachedSystemEvaluationRefAnalysisItemIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AttachedSystemEvaluationRefAnalysisItemId value)
        {
            return value switch
            {
                AttachedSystemEvaluationRefAnalysisItemId.SystemEvalCriteriaFrustration => "__system_eval_criteria_frustration",
                AttachedSystemEvaluationRefAnalysisItemId.SystemEvalCriteriaSentiment => "__system_eval_criteria_sentiment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AttachedSystemEvaluationRefAnalysisItemId? ToEnum(string value)
        {
            return value switch
            {
                "__system_eval_criteria_frustration" => AttachedSystemEvaluationRefAnalysisItemId.SystemEvalCriteriaFrustration,
                "__system_eval_criteria_sentiment" => AttachedSystemEvaluationRefAnalysisItemId.SystemEvalCriteriaSentiment,
                _ => null,
            };
        }
    }
}