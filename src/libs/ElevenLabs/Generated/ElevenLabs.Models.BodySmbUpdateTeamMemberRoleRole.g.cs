
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum BodySmbUpdateTeamMemberRoleRole
    {
        /// <summary>
        ///
        /// </summary>
        WorkspaceAdmin,
        /// <summary>
        ///
        /// </summary>
        WorkspaceMember,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodySmbUpdateTeamMemberRoleRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodySmbUpdateTeamMemberRoleRole value)
        {
            return value switch
            {
                BodySmbUpdateTeamMemberRoleRole.WorkspaceAdmin => "workspace_admin",
                BodySmbUpdateTeamMemberRoleRole.WorkspaceMember => "workspace_member",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodySmbUpdateTeamMemberRoleRole? ToEnum(string value)
        {
            return value switch
            {
                "workspace_admin" => BodySmbUpdateTeamMemberRoleRole.WorkspaceAdmin,
                "workspace_member" => BodySmbUpdateTeamMemberRoleRole.WorkspaceMember,
                _ => null,
            };
        }
    }
}