
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum TextSearchConversationMessagesRouteExcludeStatusesVariant1Item
    {
        /// <summary>
        /// 
        /// </summary>
        Done,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Initiated,
        /// <summary>
        /// 
        /// </summary>
        Processing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextSearchConversationMessagesRouteExcludeStatusesVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextSearchConversationMessagesRouteExcludeStatusesVariant1Item value)
        {
            return value switch
            {
                TextSearchConversationMessagesRouteExcludeStatusesVariant1Item.Done => "done",
                TextSearchConversationMessagesRouteExcludeStatusesVariant1Item.Failed => "failed",
                TextSearchConversationMessagesRouteExcludeStatusesVariant1Item.InProgress => "in-progress",
                TextSearchConversationMessagesRouteExcludeStatusesVariant1Item.Initiated => "initiated",
                TextSearchConversationMessagesRouteExcludeStatusesVariant1Item.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextSearchConversationMessagesRouteExcludeStatusesVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "done" => TextSearchConversationMessagesRouteExcludeStatusesVariant1Item.Done,
                "failed" => TextSearchConversationMessagesRouteExcludeStatusesVariant1Item.Failed,
                "in-progress" => TextSearchConversationMessagesRouteExcludeStatusesVariant1Item.InProgress,
                "initiated" => TextSearchConversationMessagesRouteExcludeStatusesVariant1Item.Initiated,
                "processing" => TextSearchConversationMessagesRouteExcludeStatusesVariant1Item.Processing,
                _ => null,
            };
        }
    }
}