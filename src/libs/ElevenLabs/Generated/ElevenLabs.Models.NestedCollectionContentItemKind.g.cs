
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum NestedCollectionContentItemKind
    {
        /// <summary>
        /// 
        /// </summary>
        Subproject,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NestedCollectionContentItemKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NestedCollectionContentItemKind value)
        {
            return value switch
            {
                NestedCollectionContentItemKind.Subproject => "subproject",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NestedCollectionContentItemKind? ToEnum(string value)
        {
            return value switch
            {
                "subproject" => NestedCollectionContentItemKind.Subproject,
                _ => null,
            };
        }
    }
}