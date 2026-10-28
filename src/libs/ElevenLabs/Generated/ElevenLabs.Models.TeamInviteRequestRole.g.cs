
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: workspace_member
    /// </summary>
    public enum TeamInviteRequestRole
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
    public static class TeamInviteRequestRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamInviteRequestRole value)
        {
            return value switch
            {
                TeamInviteRequestRole.WorkspaceAdmin => "workspace_admin",
                TeamInviteRequestRole.WorkspaceMember => "workspace_member",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamInviteRequestRole? ToEnum(string value)
        {
            return value switch
            {
                "workspace_admin" => TeamInviteRequestRole.WorkspaceAdmin,
                "workspace_member" => TeamInviteRequestRole.WorkspaceMember,
                _ => null,
            };
        }
    }
}