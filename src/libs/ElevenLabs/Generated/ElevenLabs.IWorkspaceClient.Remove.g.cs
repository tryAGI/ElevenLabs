#nullable enable

namespace ElevenLabs
{
    public partial interface IWorkspaceClient
    {
        /// <summary>
        /// Delete Member From User Group<br/>
        /// Removes a member from the specified group. Requires `group_members_manage` permission.
        /// </summary>
        /// <param name="groupId">
        /// The ID of the target group.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.DeleteWorkspaceGroupMemberResponseModel> RemoveAsync(
            string groupId,

            global::ElevenLabs.BodyDeleteMemberFromUserGroupV1WorkspaceGroupsGroupIdMembersRemovePost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Member From User Group<br/>
        /// Removes a member from the specified group. Requires `group_members_manage` permission.
        /// </summary>
        /// <param name="groupId">
        /// The ID of the target group.
        /// </param>
        /// <param name="email">
        /// The email of the target workspace member.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.DeleteWorkspaceGroupMemberResponseModel> RemoveAsync(
            string groupId,
            string email,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}