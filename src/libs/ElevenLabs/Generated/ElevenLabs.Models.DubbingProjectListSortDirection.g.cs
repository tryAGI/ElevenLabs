
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Sort by creation time (default 'DESCENDING').<br/>
    /// Default Value: DESCENDING
    /// </summary>
    public enum DubbingProjectListSortDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Ascending,
        /// <summary>
        /// 
        /// </summary>
        Descending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DubbingProjectListSortDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DubbingProjectListSortDirection value)
        {
            return value switch
            {
                DubbingProjectListSortDirection.Ascending => "ASCENDING",
                DubbingProjectListSortDirection.Descending => "DESCENDING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DubbingProjectListSortDirection? ToEnum(string value)
        {
            return value switch
            {
                "ASCENDING" => DubbingProjectListSortDirection.Ascending,
                "DESCENDING" => DubbingProjectListSortDirection.Descending,
                _ => null,
            };
        }
    }
}