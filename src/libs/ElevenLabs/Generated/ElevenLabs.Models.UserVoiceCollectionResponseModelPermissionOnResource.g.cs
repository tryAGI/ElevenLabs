
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The caller's access role on the voice collection.
    /// </summary>
    public enum UserVoiceCollectionResponseModelPermissionOnResource
    {
        /// <summary>
        ///
        /// </summary>
        Admin,
        /// <summary>
        ///
        /// </summary>
        Commenter,
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
    public static class UserVoiceCollectionResponseModelPermissionOnResourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserVoiceCollectionResponseModelPermissionOnResource value)
        {
            return value switch
            {
                UserVoiceCollectionResponseModelPermissionOnResource.Admin => "admin",
                UserVoiceCollectionResponseModelPermissionOnResource.Commenter => "commenter",
                UserVoiceCollectionResponseModelPermissionOnResource.Editor => "editor",
                UserVoiceCollectionResponseModelPermissionOnResource.Viewer => "viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserVoiceCollectionResponseModelPermissionOnResource? ToEnum(string value)
        {
            return value switch
            {
                "admin" => UserVoiceCollectionResponseModelPermissionOnResource.Admin,
                "commenter" => UserVoiceCollectionResponseModelPermissionOnResource.Commenter,
                "editor" => UserVoiceCollectionResponseModelPermissionOnResource.Editor,
                "viewer" => UserVoiceCollectionResponseModelPermissionOnResource.Viewer,
                _ => null,
            };
        }
    }
}