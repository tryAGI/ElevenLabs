
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentAnalysisItemsOutputEvaluationCriteriaItemDiscriminatorSource
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
    public static class AgentAnalysisItemsOutputEvaluationCriteriaItemDiscriminatorSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentAnalysisItemsOutputEvaluationCriteriaItemDiscriminatorSource value)
        {
            return value switch
            {
                AgentAnalysisItemsOutputEvaluationCriteriaItemDiscriminatorSource.System => "system",
                AgentAnalysisItemsOutputEvaluationCriteriaItemDiscriminatorSource.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentAnalysisItemsOutputEvaluationCriteriaItemDiscriminatorSource? ToEnum(string value)
        {
            return value switch
            {
                "system" => AgentAnalysisItemsOutputEvaluationCriteriaItemDiscriminatorSource.System,
                "user" => AgentAnalysisItemsOutputEvaluationCriteriaItemDiscriminatorSource.User,
                _ => null,
            };
        }
    }
}