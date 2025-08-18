
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutputType
    {
        /// <summary>
        /// 
        /// </summary>
        Workflow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutputType value)
        {
            return value switch
            {
                ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutputType.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutputType? ToEnum(string value)
        {
            return value switch
            {
                "workflow" => ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutputType.Workflow,
                _ => null,
            };
        }
    }
}