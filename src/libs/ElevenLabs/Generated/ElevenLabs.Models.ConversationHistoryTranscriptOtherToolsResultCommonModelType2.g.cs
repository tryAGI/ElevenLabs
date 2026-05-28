
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConversationHistoryTranscriptOtherToolsResultCommonModelType2
    {
        /// <summary>
        /// 
        /// </summary>
        Client,
        /// <summary>
        /// 
        /// </summary>
        Code,
        /// <summary>
        /// 
        /// </summary>
        Mcp,
        /// <summary>
        /// 
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationHistoryTranscriptOtherToolsResultCommonModelType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationHistoryTranscriptOtherToolsResultCommonModelType2 value)
        {
            return value switch
            {
                ConversationHistoryTranscriptOtherToolsResultCommonModelType2.Client => "client",
                ConversationHistoryTranscriptOtherToolsResultCommonModelType2.Code => "code",
                ConversationHistoryTranscriptOtherToolsResultCommonModelType2.Mcp => "mcp",
                ConversationHistoryTranscriptOtherToolsResultCommonModelType2.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationHistoryTranscriptOtherToolsResultCommonModelType2? ToEnum(string value)
        {
            return value switch
            {
                "client" => ConversationHistoryTranscriptOtherToolsResultCommonModelType2.Client,
                "code" => ConversationHistoryTranscriptOtherToolsResultCommonModelType2.Code,
                "mcp" => ConversationHistoryTranscriptOtherToolsResultCommonModelType2.Mcp,
                "webhook" => ConversationHistoryTranscriptOtherToolsResultCommonModelType2.Webhook,
                _ => null,
            };
        }
    }
}