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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.DeleteWorkspaceWebhookResponseModel> Delete4Async(
            string webhookId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}