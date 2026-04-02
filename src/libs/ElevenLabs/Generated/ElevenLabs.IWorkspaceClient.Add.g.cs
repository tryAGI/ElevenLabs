#nullable enable

namespace ElevenLabs
{
    public partial interface IWorkspaceClient
    {
        /// <summary>
        /// Add Member To User Group<br/>
        /// Adds a member of your workspace to the specified group. Requires `group_members_manage` permission.
        /// </summary>
        /// <param name="groupId">
        /// The ID of the target group.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AddWorkspaceGroupMemberResponseModel> AddAsync(
            string groupId,

            global::ElevenLabs.BodyAddMemberToUserGroupV1WorkspaceGroupsGroupIdMembersPost request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Member To User Group<br/>
        /// Adds a member of your workspace to the specified group. Requires `group_members_manage` permission.
        /// </summary>
        /// <param name="groupId">
        /// The ID of the target group.
        /// </param>
        /// <param name="email">
        /// The email of the target workspace member.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AddWorkspaceGroupMemberResponseModel> AddAsync(
            string groupId,
            string email,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}