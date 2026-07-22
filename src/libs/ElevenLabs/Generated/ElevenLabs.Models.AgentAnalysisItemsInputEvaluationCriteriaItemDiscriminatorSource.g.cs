
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentAnalysisItemsInputEvaluationCriteriaItemDiscriminatorSource
    {
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentAnalysisItemsInputEvaluationCriteriaItemDiscriminatorSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentAnalysisItemsInputEvaluationCriteriaItemDiscriminatorSource value)
        {
            return value switch
            {
                AgentAnalysisItemsInputEvaluationCriteriaItemDiscriminatorSource.System => "system",
                AgentAnalysisItemsInputEvaluationCriteriaItemDiscriminatorSource.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentAnalysisItemsInputEvaluationCriteriaItemDiscriminatorSource? ToEnum(string value)
        {
            return value switch
            {
                "system" => AgentAnalysisItemsInputEvaluationCriteriaItemDiscriminatorSource.System,
                "user" => AgentAnalysisItemsInputEvaluationCriteriaItemDiscriminatorSource.User,
                _ => null,
            };
        }
    }
}