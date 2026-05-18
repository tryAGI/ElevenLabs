#nullable enable

namespace ElevenLabs
{
    public partial interface IProductionsClient
    {
        /// <summary>
        /// List Orders<br/>
        /// Lists Productions orders in the workspace. Supports filtering by status and date range, with pagination.
        /// </summary>
        /// <param name="workspaceId">
        /// The ID of the workspace.
        /// </param>
        /// <param name="pageSize">
        /// Maximum number of orders to return per page.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="offset">
        /// Number of orders to skip for pagination.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="status">
        /// Filter orders by one or more statuses.
        /// </param>
        /// <param name="startDate">
        /// Filter orders created on or after this date.
        /// </param>
        /// <param name="endDate">
        /// Filter orders created on or before this date.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ListOrdersResponse> ListAsync(
            string workspaceId,
            int? pageSize = default,
            int? offset = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.OrderRequestState>? status = default,
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Orders<br/>
        /// Lists Productions orders in the workspace. Supports filtering by status and date range, with pagination.
        /// </summary>
        /// <param name="workspaceId">
        /// The ID of the workspace.
        /// </param>
        /// <param name="pageSize">
        /// Maximum number of orders to return per page.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="offset">
        /// Number of orders to skip for pagination.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="status">
        /// Filter orders by one or more statuses.
        /// </param>
        /// <param name="startDate">
        /// Filter orders created on or after this date.
        /// </param>
        /// <param name="endDate">
        /// Filter orders created on or before this date.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.ListOrdersResponse>> ListAsResponseAsync(
            string workspaceId,
            int? pageSize = default,
            int? offset = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.OrderRequestState>? status = default,
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}