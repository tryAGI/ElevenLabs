
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum ResourceAccessInfoAccessSource
    {
        /// <summary>
        ///
        /// </summary>
        Creator,
        /// <summary>
        ///
        /// </summary>
        Explicit,
        /// <summary>
        ///
        /// </summary>
        WorkspaceAdmin,
        /// <summary>
        ///
        /// </summary>
        WorkspaceDefault,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResourceAccessInfoAccessSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResourceAccessInfoAccessSource value)
        {
            return value switch
            {
                ResourceAccessInfoAccessSource.Creator => "creator",
                ResourceAccessInfoAccessSource.Explicit => "explicit",
                ResourceAccessInfoAccessSource.WorkspaceAdmin => "workspace_admin",
                ResourceAccessInfoAccessSource.WorkspaceDefault => "workspace_default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResourceAccessInfoAccessSource? ToEnum(string value)
        {
            return value switch
            {
                "creator" => ResourceAccessInfoAccessSource.Creator,
                "explicit" => ResourceAccessInfoAccessSource.Explicit,
                "workspace_admin" => ResourceAccessInfoAccessSource.WorkspaceAdmin,
                "workspace_default" => ResourceAccessInfoAccessSource.WorkspaceDefault,
                _ => null,
            };
        }
    }
}