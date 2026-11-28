
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum ResellerWorkspaceSort
    {
        /// <summary>
        ///
        /// </summary>
        Name,
        /// <summary>
        ///
        /// </summary>
        Newest,
        /// <summary>
        ///
        /// </summary>
        Oldest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResellerWorkspaceSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResellerWorkspaceSort value)
        {
            return value switch
            {
                ResellerWorkspaceSort.Name => "name",
                ResellerWorkspaceSort.Newest => "newest",
                ResellerWorkspaceSort.Oldest => "oldest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResellerWorkspaceSort? ToEnum(string value)
        {
            return value switch
            {
                "name" => ResellerWorkspaceSort.Name,
                "newest" => ResellerWorkspaceSort.Newest,
                "oldest" => ResellerWorkspaceSort.Oldest,
                _ => null,
            };
        }
    }
}