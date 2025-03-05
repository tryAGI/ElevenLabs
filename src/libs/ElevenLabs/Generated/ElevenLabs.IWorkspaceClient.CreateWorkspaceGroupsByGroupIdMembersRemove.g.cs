#nullable enable

namespace ElevenLabs
{
    public partial interface IWorkspaceClient
    {
        /// <summary>
        /// Delete Member From User Group<br/>
        /// Removes a member from the specified group. This endpoint may only be called by workspace administrators.
        /// </summary>
        /// <param name="groupId">
        /// The ID of the target group.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.DeleteWorkspaceGroupMemberResponseModel> CreateWorkspaceGroupsByGroupIdMembersRemoveAsync(
            string groupId,
            string xiApiKey,
            global::ElevenLabs.BodyDeleteMemberFromUserGroupV1WorkspaceGroupsGroupIdMembersRemovePost request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete Member From User Group<br/>
        /// Removes a member from the specified group. This endpoint may only be called by workspace administrators.
        /// </summary>
        /// <param name="groupId">
        /// The ID of the target group.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="email">
        /// The email of the target workspace member.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.DeleteWorkspaceGroupMemberResponseModel> CreateWorkspaceGroupsByGroupIdMembersRemoveAsync(
            string groupId,
            string xiApiKey,
            string email,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}