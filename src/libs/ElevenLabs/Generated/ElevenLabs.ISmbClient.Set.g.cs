#nullable enable

namespace ElevenLabs
{
    public partial interface ISmbClient
    {
        /// <summary>
        /// Update Product Stock<br/>
        /// Set the on-hand quantity of a counted product at one location. Rejected with a 409 if it changed since `expected_on_hand` was read.
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.SMBProductDBModel> SetAsync(
            string productId,

            global::ElevenLabs.SMBUpdateProductStockRequest request,
            string? xiWorkspaceId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Product Stock<br/>
        /// Set the on-hand quantity of a counted product at one location. Rejected with a 409 if it changed since `expected_on_hand` was read.
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.SMBProductDBModel>> SetAsResponseAsync(
            string productId,

            global::ElevenLabs.SMBUpdateProductStockRequest request,
            string? xiWorkspaceId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Product Stock<br/>
        /// Set the on-hand quantity of a counted product at one location. Rejected with a 409 if it changed since `expected_on_hand` was read.
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="locationId">
        /// Location whose count is set.
        /// </param>
        /// <param name="onHand">
        /// The new on-hand quantity.
        /// </param>
        /// <param name="expectedOnHand">
        /// On-hand value the caller last saw. The write is rejected with a 409 if it no longer matches, so a sale made while the caller was editing is never overwritten.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.SMBProductDBModel> SetAsync(
            string productId,
            string locationId,
            int onHand,
            int expectedOnHand,
            string? xiWorkspaceId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}