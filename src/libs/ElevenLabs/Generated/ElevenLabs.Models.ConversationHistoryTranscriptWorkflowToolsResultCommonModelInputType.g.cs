
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConversationHistoryTranscriptWorkflowToolsResultCommonModelInputType
    {
        /// <summary>
        /// 
        /// </summary>
        Workflow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationHistoryTranscriptWorkflowToolsResultCommonModelInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationHistoryTranscriptWorkflowToolsResultCommonModelInputType value)
        {
            return value switch
            {
                ConversationHistoryTranscriptWorkflowToolsResultCommonModelInputType.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationHistoryTranscriptWorkflowToolsResultCommonModelInputType? ToEnum(string value)
        {
            return value switch
            {
                "workflow" => ConversationHistoryTranscriptWorkflowToolsResultCommonModelInputType.Workflow,
                _ => null,
            };
        }
    }
}