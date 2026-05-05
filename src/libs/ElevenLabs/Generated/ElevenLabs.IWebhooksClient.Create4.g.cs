#nullable enable

namespace ElevenLabs
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Create Workspace Webhook<br/>
        /// Create a new webhook for the workspace with the specified authentication type.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.WorkspaceCreateWebhookResponseModel> Create4Async(

            global::ElevenLabs.BodyCreateWorkspaceWebhookV1WorkspaceWebhooksPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Workspace Webhook<br/>
        /// Create a new webhook for the workspace with the specified authentication type.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.WorkspaceCreateWebhookResponseModel>> Create4AsResponseAsync(

            global::ElevenLabs.BodyCreateWorkspaceWebhookV1WorkspaceWebhooksPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Workspace Webhook<br/>
        /// Create a new webhook for the workspace with the specified authentication type.
        /// </summary>
        /// <param name="settings">
        /// Webhook settings object containing auth_type and corresponding configuration
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.WorkspaceCreateWebhookResponseModel> Create4Async(
            global::ElevenLabs.WebhookHMACSettings settings,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}