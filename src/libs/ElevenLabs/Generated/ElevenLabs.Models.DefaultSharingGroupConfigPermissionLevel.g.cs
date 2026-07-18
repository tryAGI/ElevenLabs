
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The permission level to grant to the group
    /// </summary>
    public enum DefaultSharingGroupConfigPermissionLevel
    {
        /// <summary>
        /// 
        /// </summary>
        Admin,
        /// <summary>
        /// 
        /// </summary>
        Editor,
        /// <summary>
        /// 
        /// </summary>
        Viewer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DefaultSharingGroupConfigPermissionLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DefaultSharingGroupConfigPermissionLevel value)
        {
            return value switch
            {
                DefaultSharingGroupConfigPermissionLevel.Admin => "admin",
                DefaultSharingGroupConfigPermissionLevel.Editor => "editor",
                DefaultSharingGroupConfigPermissionLevel.Viewer => "viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DefaultSharingGroupConfigPermissionLevel? ToEnum(string value)
        {
            return value switch
            {
                "admin" => DefaultSharingGroupConfigPermissionLevel.Admin,
                "editor" => DefaultSharingGroupConfigPermissionLevel.Editor,
                "viewer" => DefaultSharingGroupConfigPermissionLevel.Viewer,
                _ => null,
            };
        }
    }
}