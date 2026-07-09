#nullable enable

namespace ElevenLabs
{
    public partial interface IWorkspaceClient
    {
        /// <summary>
        /// Transfer Workspace Resource Ownership<br/>
        /// Transfers ownership of a workspace resource from the current owner to another user in the same workspace. You must be the resource's current owner to transfer it. The previous owner keeps admin access to the resource.
        /// </summary>
        /// <param name="resourceId">
        /// The ID of the target resource.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> TransferAsync(
            string resourceId,

            global::ElevenLabs.BodyTransferWorkspaceResourceOwnershipV1WorkspaceResourcesResourceIdTransferPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Transfer Workspace Resource Ownership<br/>
        /// Transfers ownership of a workspace resource from the current owner to another user in the same workspace. You must be the resource's current owner to transfer it. The previous owner keeps admin access to the resource.
        /// </summary>
        /// <param name="resourceId">
        /// The ID of the target resource.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<string>> TransferAsResponseAsync(
            string resourceId,

            global::ElevenLabs.BodyTransferWorkspaceResourceOwnershipV1WorkspaceResourcesResourceIdTransferPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Transfer Workspace Resource Ownership<br/>
        /// Transfers ownership of a workspace resource from the current owner to another user in the same workspace. You must be the resource's current owner to transfer it. The previous owner keeps admin access to the resource.
        /// </summary>
        /// <param name="resourceId">
        /// The ID of the target resource.
        /// </param>
        /// <param name="resourceType">
        /// Resource type of the target resource.
        /// </param>
        /// <param name="targetUserId">
        /// The ID of the user the resource should be transferred to.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> TransferAsync(
            string resourceId,
            global::ElevenLabs.WorkspaceResourceType resourceType,
            string targetUserId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}