
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: mcp
    /// </summary>
    public enum ConversationHistoryTranscriptToolCallMCPDetailsType
    {
        /// <summary>
        /// 
        /// </summary>
        Mcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationHistoryTranscriptToolCallMCPDetailsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationHistoryTranscriptToolCallMCPDetailsType value)
        {
            return value switch
            {
                ConversationHistoryTranscriptToolCallMCPDetailsType.Mcp => "mcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationHistoryTranscriptToolCallMCPDetailsType? ToEnum(string value)
        {
            return value switch
            {
                "mcp" => ConversationHistoryTranscriptToolCallMCPDetailsType.Mcp,
                _ => null,
            };
        }
    }
}