#nullable enable

namespace ElevenLabs
{
    public partial interface IProductionsClient
    {
        /// <summary>
        /// Get Order<br/>
        /// Retrieves full details for a Productions order.<br/>
        /// Quote and pricing information may not be available immediately; if you wish to see the quote before submission, you may need to poll the order details until it is ready.
        /// </summary>
        /// <param name="orderId">
        /// The ID of the order.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.OrderResponse> GetAsync(
            string orderId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Order<br/>
        /// Retrieves full details for a Productions order.<br/>
        /// Quote and pricing information may not be available immediately; if you wish to see the quote before submission, you may need to poll the order details until it is ready.
        /// </summary>
        /// <param name="orderId">
        /// The ID of the order.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.OrderResponse>> GetAsResponseAsync(
            string orderId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}