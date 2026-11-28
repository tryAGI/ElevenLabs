#nullable enable

namespace ElevenLabs
{
    public partial interface ISmbClient
    {
        /// <summary>
        /// Update Reseller Workspace<br/>
        /// Update a customer workspace. Only the fields sent are changed.
        /// </summary>
        /// <param name="workspaceId">
        /// ID of the customer workspace. Returned when you provision one; list them with `GET /v1/reception/reseller/workspaces`.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ResellerWorkspaceSummary> Update13Async(
            string workspaceId,

            global::ElevenLabs.UpdateResellerWorkspaceRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Reseller Workspace<br/>
        /// Update a customer workspace. Only the fields sent are changed.
        /// </summary>
        /// <param name="workspaceId">
        /// ID of the customer workspace. Returned when you provision one; list them with `GET /v1/reception/reseller/workspaces`.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.ResellerWorkspaceSummary>> Update13AsResponseAsync(
            string workspaceId,

            global::ElevenLabs.UpdateResellerWorkspaceRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Reseller Workspace<br/>
        /// Update a customer workspace. Only the fields sent are changed.
        /// </summary>
        /// <param name="workspaceId">
        /// ID of the customer workspace. Returned when you provision one; list them with `GET /v1/reception/reseller/workspaces`.
        /// </param>
        /// <param name="metadata">
        /// Replaces the workspace's whole metadata map; send `{}` to clear it. Omitted leaves it unchanged.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ResellerWorkspaceSummary> Update13Async(
            string workspaceId,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}