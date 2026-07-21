
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Sort by field (created_at or name)<br/>
    /// Default Value: created_at
    /// </summary>
    public enum GetFinetunesSort
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
    public static class GetFinetunesSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFinetunesSort value)
        {
            return value switch
            {
                GetFinetunesSort.CreatedAt => "created_at",
                GetFinetunesSort.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFinetunesSort? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => GetFinetunesSort.CreatedAt,
                "name" => GetFinetunesSort.Name,
                _ => null,
            };
        }
    }
}