
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConversationHistoryTranscriptOtherToolsResultCommonModelType
    {
        /// <summary>
        /// 
        /// </summary>
        Client,
        /// <summary>
        /// 
        /// </summary>
        Webhook,
        /// <summary>
        /// 
        /// </summary>
        Mcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationHistoryTranscriptOtherToolsResultCommonModelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationHistoryTranscriptOtherToolsResultCommonModelType value)
        {
            return value switch
            {
                ConversationHistoryTranscriptOtherToolsResultCommonModelType.Client => "client",
                ConversationHistoryTranscriptOtherToolsResultCommonModelType.Webhook => "webhook",
                ConversationHistoryTranscriptOtherToolsResultCommonModelType.Mcp => "mcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationHistoryTranscriptOtherToolsResultCommonModelType? ToEnum(string value)
        {
            return value switch
            {
                "client" => ConversationHistoryTranscriptOtherToolsResultCommonModelType.Client,
                "webhook" => ConversationHistoryTranscriptOtherToolsResultCommonModelType.Webhook,
                "mcp" => ConversationHistoryTranscriptOtherToolsResultCommonModelType.Mcp,
                _ => null,
            };
        }
    }
}