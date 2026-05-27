
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Role to grant to the target: one of 'admin', 'editor', 'commenter', or 'viewer'.
    /// </summary>
    public enum BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole
    {
        /// <summary>
        /// one of 'admin', 'editor', 'commenter', or 'viewer'.
        /// </summary>
        Admin,
        /// <summary>
        /// one of 'admin', 'editor', 'commenter', or 'viewer'.
        /// </summary>
        Commenter,
        /// <summary>
        /// one of 'admin', 'editor', 'commenter', or 'viewer'.
        /// </summary>
        Editor,
        /// <summary>
        /// one of 'admin', 'editor', 'commenter', or 'viewer'.
        /// </summary>
        Viewer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole value)
        {
            return value switch
            {
                BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole.Admin => "admin",
                BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole.Commenter => "commenter",
                BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole.Editor => "editor",
                BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole.Viewer => "viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole.Admin,
                "commenter" => BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole.Commenter,
                "editor" => BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole.Editor,
                "viewer" => BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole.Viewer,
                _ => null,
            };
        }
    }
}