#nullable enable

namespace ElevenLabs
{
    public partial interface ISmbClient
    {
        /// <summary>
        /// Update Team Member Role<br/>
        /// Promote a member to admin or demote an admin to member.
        /// </summary>
        /// <param name="userId">
        /// User ID of the member to update
        /// </param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, string>> UpdateRoleAsync(
            string userId,
            string xiWorkspaceId,

            global::ElevenLabs.BodySmbUpdateTeamMemberRole request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Team Member Role<br/>
        /// Promote a member to admin or demote an admin to member.
        /// </summary>
        /// <param name="userId">
        /// User ID of the member to update
        /// </param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::System.Collections.Generic.Dictionary<string, string>>> UpdateRoleAsResponseAsync(
            string userId,
            string xiWorkspaceId,

            global::ElevenLabs.BodySmbUpdateTeamMemberRole request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Team Member Role<br/>
        /// Promote a member to admin or demote an admin to member.
        /// </summary>
        /// <param name="userId">
        /// User ID of the member to update
        /// </param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="role">
        /// The member's new role.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, string>> UpdateRoleAsync(
            string userId,
            string xiWorkspaceId,
            global::ElevenLabs.BodySmbUpdateTeamMemberRoleRole role,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}