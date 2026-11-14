#nullable enable

namespace ElevenLabs
{
    public partial interface ISmbClient
    {
        /// <summary>
        /// Adjust Product Stock<br/>
        /// Add to or subtract from the on-hand quantity of a counted product at one location, without overwriting orders taken at the same time.
        /// </summary>
        /// <param name="productId">
        /// ID of the product. Returned when you create one; list them with `GET /v1/reception/products`.
        /// </param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ReceptionProduct> AdjustAsync(
            string productId,
            string xiWorkspaceId,

            global::ElevenLabs.ReceptionAdjustProductStockRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Adjust Product Stock<br/>
        /// Add to or subtract from the on-hand quantity of a counted product at one location, without overwriting orders taken at the same time.
        /// </summary>
        /// <param name="productId">
        /// ID of the product. Returned when you create one; list them with `GET /v1/reception/products`.
        /// </param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.ReceptionProduct>> AdjustAsResponseAsync(
            string productId,
            string xiWorkspaceId,

            global::ElevenLabs.ReceptionAdjustProductStockRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Adjust Product Stock<br/>
        /// Add to or subtract from the on-hand quantity of a counted product at one location, without overwriting orders taken at the same time.
        /// </summary>
        /// <param name="productId">
        /// ID of the product. Returned when you create one; list them with `GET /v1/reception/products`.
        /// </param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="locationId">
        /// Location whose count changes.
        /// </param>
        /// <param name="delta">
        /// Signed change to apply to on-hand. Prefer this over an absolute write whenever the intent is 'a few more/fewer'.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ReceptionProduct> AdjustAsync(
            string productId,
            string xiWorkspaceId,
            string locationId,
            int delta,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}