
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessageSearchSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        SearchScore,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageSearchSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageSearchSortBy value)
        {
            return value switch
            {
                MessageSearchSortBy.CreatedAt => "created_at",
                MessageSearchSortBy.SearchScore => "search_score",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageSearchSortBy? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => MessageSearchSortBy.CreatedAt,
                "search_score" => MessageSearchSortBy.SearchScore,
                _ => null,
            };
        }
    }
}