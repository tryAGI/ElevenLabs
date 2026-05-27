#nullable enable

namespace ElevenLabs
{
    public partial interface IWorkspaceClient
    {
        /// <summary>
        /// Share Workspace Resource<br/>
        /// Grants a role (one of 'admin', 'editor', 'commenter', or 'viewer') on a workspace resource to a user, group, or workspace (service account) API key. This overrides any existing role the target has on the resource. To target a user or service account, pass only the user email; the user must be in your workspace. To target a group, pass only the group id. To target a workspace (service account) API key, pass the api key id; the resource will be shared with the service account associated with that key. You must have admin access to the resource to share it.
        /// </summary>
        /// <param name="resourceId">
        /// The ID of the target resource.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ShareAsync(
            string resourceId,

            global::ElevenLabs.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Share Workspace Resource<br/>
        /// Grants a role (one of 'admin', 'editor', 'commenter', or 'viewer') on a workspace resource to a user, group, or workspace (service account) API key. This overrides any existing role the target has on the resource. To target a user or service account, pass only the user email; the user must be in your workspace. To target a group, pass only the group id. To target a workspace (service account) API key, pass the api key id; the resource will be shared with the service account associated with that key. You must have admin access to the resource to share it.
        /// </summary>
        /// <param name="resourceId">
        /// The ID of the target resource.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<string>> ShareAsResponseAsync(
            string resourceId,

            global::ElevenLabs.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Share Workspace Resource<br/>
        /// Grants a role (one of 'admin', 'editor', 'commenter', or 'viewer') on a workspace resource to a user, group, or workspace (service account) API key. This overrides any existing role the target has on the resource. To target a user or service account, pass only the user email; the user must be in your workspace. To target a group, pass only the group id. To target a workspace (service account) API key, pass the api key id; the resource will be shared with the service account associated with that key. You must have admin access to the resource to share it.
        /// </summary>
        /// <param name="resourceId">
        /// The ID of the target resource.
        /// </param>
        /// <param name="role">
        /// Role to grant to the target: one of 'admin', 'editor', 'commenter', or 'viewer'.
        /// </param>
        /// <param name="resourceType">
        /// Resource type of the target resource.
        /// </param>
        /// <param name="userEmail">
        /// The email of the user or service account.
        /// </param>
        /// <param name="groupId">
        /// The ID of the target group. Use 'default' to set the resource's baseline role — every workspace member receives this role unless they hold a higher one through a direct user grant, group membership, or workspace (service account) API key.
        /// </param>
        /// <param name="workspaceApiKeyId">
        /// The ID of the target workspace (service account) API key. This is not the API key string itself that you pass in the header for authentication — it is the key's ID, which workspace admins can find under Developers → Service Accounts.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ShareAsync(
            string resourceId,
            global::ElevenLabs.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole role,
            global::ElevenLabs.WorkspaceResourceType resourceType,
            string? userEmail = default,
            string? groupId = default,
            string? workspaceApiKeyId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}