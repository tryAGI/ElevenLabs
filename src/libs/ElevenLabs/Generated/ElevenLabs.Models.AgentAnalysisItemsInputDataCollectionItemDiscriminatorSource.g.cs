
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentAnalysisItemsInputDataCollectionItemDiscriminatorSource
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
    public static class AgentAnalysisItemsInputDataCollectionItemDiscriminatorSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentAnalysisItemsInputDataCollectionItemDiscriminatorSource value)
        {
            return value switch
            {
                AgentAnalysisItemsInputDataCollectionItemDiscriminatorSource.System => "system",
                AgentAnalysisItemsInputDataCollectionItemDiscriminatorSource.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentAnalysisItemsInputDataCollectionItemDiscriminatorSource? ToEnum(string value)
        {
            return value switch
            {
                "system" => AgentAnalysisItemsInputDataCollectionItemDiscriminatorSource.System,
                "user" => AgentAnalysisItemsInputDataCollectionItemDiscriminatorSource.User,
                _ => null,
            };
        }
    }
}