
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConversationHistoryTranscriptToolCallCommonModelToolDetailsDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Client,
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
    public static class ConversationHistoryTranscriptToolCallCommonModelToolDetailsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationHistoryTranscriptToolCallCommonModelToolDetailsDiscriminatorType value)
        {
            return value switch
            {
                ConversationHistoryTranscriptToolCallCommonModelToolDetailsDiscriminatorType.Client => "client",
                ConversationHistoryTranscriptToolCallCommonModelToolDetailsDiscriminatorType.Mcp => "mcp",
                ConversationHistoryTranscriptToolCallCommonModelToolDetailsDiscriminatorType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationHistoryTranscriptToolCallCommonModelToolDetailsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "client" => ConversationHistoryTranscriptToolCallCommonModelToolDetailsDiscriminatorType.Client,
                "mcp" => ConversationHistoryTranscriptToolCallCommonModelToolDetailsDiscriminatorType.Mcp,
                "webhook" => ConversationHistoryTranscriptToolCallCommonModelToolDetailsDiscriminatorType.Webhook,
                _ => null,
            };
        }
    }
}