
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The role the invitee joins with: 'workspace_admin' or 'workspace_member'.<br/>
    /// Default Value: workspace_member
    /// </summary>
    public enum CreateTeamInviteRequestRole
    {
        /// <summary>
        /// 'workspace_admin' or 'workspace_member'.
        /// </summary>
        WorkspaceAdmin,
        /// <summary>
        /// 'workspace_admin' or 'workspace_member'.
        /// </summary>
        WorkspaceMember,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTeamInviteRequestRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTeamInviteRequestRole value)
        {
            return value switch
            {
                CreateTeamInviteRequestRole.WorkspaceAdmin => "workspace_admin",
                CreateTeamInviteRequestRole.WorkspaceMember => "workspace_member",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTeamInviteRequestRole? ToEnum(string value)
        {
            return value switch
            {
                "workspace_admin" => CreateTeamInviteRequestRole.WorkspaceAdmin,
                "workspace_member" => CreateTeamInviteRequestRole.WorkspaceMember,
                _ => null,
            };
        }
    }
}