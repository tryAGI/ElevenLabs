
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConversationHistoriesRouteExcludeStatusesVariant1Item
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
    public static class GetConversationHistoriesRouteExcludeStatusesVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConversationHistoriesRouteExcludeStatusesVariant1Item value)
        {
            return value switch
            {
                GetConversationHistoriesRouteExcludeStatusesVariant1Item.Done => "done",
                GetConversationHistoriesRouteExcludeStatusesVariant1Item.Failed => "failed",
                GetConversationHistoriesRouteExcludeStatusesVariant1Item.InProgress => "in-progress",
                GetConversationHistoriesRouteExcludeStatusesVariant1Item.Initiated => "initiated",
                GetConversationHistoriesRouteExcludeStatusesVariant1Item.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConversationHistoriesRouteExcludeStatusesVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "done" => GetConversationHistoriesRouteExcludeStatusesVariant1Item.Done,
                "failed" => GetConversationHistoriesRouteExcludeStatusesVariant1Item.Failed,
                "in-progress" => GetConversationHistoriesRouteExcludeStatusesVariant1Item.InProgress,
                "initiated" => GetConversationHistoriesRouteExcludeStatusesVariant1Item.Initiated,
                "processing" => GetConversationHistoriesRouteExcludeStatusesVariant1Item.Processing,
                _ => null,
            };
        }
    }
}