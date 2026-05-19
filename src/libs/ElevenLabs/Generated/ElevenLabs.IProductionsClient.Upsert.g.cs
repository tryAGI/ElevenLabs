#nullable enable

namespace ElevenLabs
{
    public partial interface IProductionsClient
    {
        /// <summary>
        /// Upsert Order Item<br/>
        /// Adds or updates an order item on an open order. Returns the item ID and the quoted price.
        /// </summary>
        /// <param name="orderId">
        /// The ID of the order.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.UpsertOrderItemResponse> UpsertAsync(
            string orderId,

            global::ElevenLabs.BodyUpsertOrderItemV1ProductionsOrdersOrderIdItemsPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upsert Order Item<br/>
        /// Adds or updates an order item on an open order. Returns the item ID and the quoted price.
        /// </summary>
        /// <param name="orderId">
        /// The ID of the order.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.UpsertOrderItemResponse>> UpsertAsResponseAsync(
            string orderId,

            global::ElevenLabs.BodyUpsertOrderItemV1ProductionsOrdersOrderIdItemsPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upsert Order Item<br/>
        /// Adds or updates an order item on an open order. Returns the item ID and the quoted price.
        /// </summary>
        /// <param name="orderId">
        /// The ID of the order.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.UpsertOrderItemResponse> UpsertAsync(
            string orderId,
            global::ElevenLabs.UpsertOrderItemRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}