
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResourceAccessInfoAccessSource2
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
    public static class ResourceAccessInfoAccessSource2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResourceAccessInfoAccessSource2 value)
        {
            return value switch
            {
                ResourceAccessInfoAccessSource2.Creator => "creator",
                ResourceAccessInfoAccessSource2.Explicit => "explicit",
                ResourceAccessInfoAccessSource2.WorkspaceAdmin => "workspace_admin",
                ResourceAccessInfoAccessSource2.WorkspaceDefault => "workspace_default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResourceAccessInfoAccessSource2? ToEnum(string value)
        {
            return value switch
            {
                "creator" => ResourceAccessInfoAccessSource2.Creator,
                "explicit" => ResourceAccessInfoAccessSource2.Explicit,
                "workspace_admin" => ResourceAccessInfoAccessSource2.WorkspaceAdmin,
                "workspace_default" => ResourceAccessInfoAccessSource2.WorkspaceDefault,
                _ => null,
            };
        }
    }
}