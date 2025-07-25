
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConversationHistoryTranscriptSystemToolResultCommonModelType
    {
        /// <summary>
        /// 
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationHistoryTranscriptSystemToolResultCommonModelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationHistoryTranscriptSystemToolResultCommonModelType value)
        {
            return value switch
            {
                ConversationHistoryTranscriptSystemToolResultCommonModelType.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationHistoryTranscriptSystemToolResultCommonModelType? ToEnum(string value)
        {
            return value switch
            {
                "system" => ConversationHistoryTranscriptSystemToolResultCommonModelType.System,
                _ => null,
            };
        }
    }
}