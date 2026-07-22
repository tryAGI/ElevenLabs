
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentAnalysisItemsOutputDataCollectionItemDiscriminatorSource
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
    public static class AgentAnalysisItemsOutputDataCollectionItemDiscriminatorSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentAnalysisItemsOutputDataCollectionItemDiscriminatorSource value)
        {
            return value switch
            {
                AgentAnalysisItemsOutputDataCollectionItemDiscriminatorSource.System => "system",
                AgentAnalysisItemsOutputDataCollectionItemDiscriminatorSource.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentAnalysisItemsOutputDataCollectionItemDiscriminatorSource? ToEnum(string value)
        {
            return value switch
            {
                "system" => AgentAnalysisItemsOutputDataCollectionItemDiscriminatorSource.System,
                "user" => AgentAnalysisItemsOutputDataCollectionItemDiscriminatorSource.User,
                _ => null,
            };
        }
    }
}