#nullable enable

namespace ElevenLabs
{
    public partial interface IWorkspaceClient
    {
        /// <summary>
        /// Add Member To User Group<br/>
        /// Adds a member of your workspace to the specified group. This endpoint may only be called by workspace administrators.
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
        global::System.Threading.Tasks.Task<string> CreateWorkspaceGroupsByGroupIdMembersAsync(
            string groupId,
            string xiApiKey,
            global::ElevenLabs.BodyAddMemberToUserGroupV1WorkspaceGroupsGroupIdMembersPost request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add Member To User Group<br/>
        /// Adds a member of your workspace to the specified group. This endpoint may only be called by workspace administrators.
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
        global::System.Threading.Tasks.Task<string> CreateWorkspaceGroupsByGroupIdMembersAsync(
            string groupId,
            string xiApiKey,
            string email,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}