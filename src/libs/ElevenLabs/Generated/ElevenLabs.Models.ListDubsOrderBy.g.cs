
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The field to use for ordering results from this query.<br/>
    /// Default Value: created_at
    /// </summary>
    public enum ListDubsOrderBy
    {
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        Name,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListDubsOrderByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListDubsOrderBy value)
        {
            return value switch
            {
                ListDubsOrderBy.CreatedAt => "created_at",
                ListDubsOrderBy.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListDubsOrderBy? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => ListDubsOrderBy.CreatedAt,
                "name" => ListDubsOrderBy.Name,
                _ => null,
            };
        }
    }
}