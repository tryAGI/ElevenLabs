#nullable enable

namespace ElevenLabs
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Delete Workspace Webhook<br/>
        /// Delete the specified workspace webhook
        /// </summary>
        /// <param name="webhookId">
        /// The unique ID for the webhook
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.DeleteWorkspaceWebhookResponseModel> Delete4Async(
            string webhookId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}