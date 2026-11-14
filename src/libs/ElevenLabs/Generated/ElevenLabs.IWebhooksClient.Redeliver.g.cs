#nullable enable

namespace ElevenLabs
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Redeliver Webhook Delivery<br/>
        /// Sends a stored delivery again, once, with the same delivery ID, a new signature and an ElevenLabs-Webhook-Redelivery header. A retry that is already scheduled is still sent. Only workspace admins on a web session can redeliver, and only deliveries whose payload is stored. Redeliveries and test events share a limit of 10 per webhook per minute.
        /// </summary>
        /// <param name="webhookId">
        /// The ID of the webhook.
        /// </param>
        /// <param name="deliveryId">
        /// The ID of the delivery to send again.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.WebhookSendResultResponseModel> RedeliverAsync(
            string webhookId,
            string deliveryId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Redeliver Webhook Delivery<br/>
        /// Sends a stored delivery again, once, with the same delivery ID, a new signature and an ElevenLabs-Webhook-Redelivery header. A retry that is already scheduled is still sent. Only workspace admins on a web session can redeliver, and only deliveries whose payload is stored. Redeliveries and test events share a limit of 10 per webhook per minute.
        /// </summary>
        /// <param name="webhookId">
        /// The ID of the webhook.
        /// </param>
        /// <param name="deliveryId">
        /// The ID of the delivery to send again.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.WebhookSendResultResponseModel>> RedeliverAsResponseAsync(
            string webhookId,
            string deliveryId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}