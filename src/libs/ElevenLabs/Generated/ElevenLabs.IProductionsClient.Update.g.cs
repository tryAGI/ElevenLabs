#nullable enable

namespace ElevenLabs
{
    public partial interface IProductionsClient
    {
        /// <summary>
        /// Update Order<br/>
        /// Updates an open order.
        /// </summary>
        /// <param name="orderId">
        /// The ID of the order.
        /// </param>
        /// <param name="workspaceId">
        /// The ID of the workspace.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.UpdateOrderResponse> UpdateAsync(
            string orderId,
            string workspaceId,

            global::ElevenLabs.BodyUpdateOrderV1ProductionsWorkspaceWorkspaceIdOrdersOrderIdPatch request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Order<br/>
        /// Updates an open order.
        /// </summary>
        /// <param name="orderId">
        /// The ID of the order.
        /// </param>
        /// <param name="workspaceId">
        /// The ID of the workspace.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.UpdateOrderResponse>> UpdateAsResponseAsync(
            string orderId,
            string workspaceId,

            global::ElevenLabs.BodyUpdateOrderV1ProductionsWorkspaceWorkspaceIdOrdersOrderIdPatch request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Order<br/>
        /// Updates an open order.
        /// </summary>
        /// <param name="orderId">
        /// The ID of the order.
        /// </param>
        /// <param name="workspaceId">
        /// The ID of the workspace.
        /// </param>
        /// <param name="request">
        /// Example: {"name":"Spanish Dubs"}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.UpdateOrderResponse> UpdateAsync(
            string orderId,
            string workspaceId,
            global::ElevenLabs.UpdateOrderRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}