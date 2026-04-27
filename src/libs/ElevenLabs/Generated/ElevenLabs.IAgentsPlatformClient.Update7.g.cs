#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Update Convai Settings<br/>
        /// Update Convai settings for the workspace
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetConvAISettingsResponseModel> Update7Async(

            global::ElevenLabs.PatchConvAISettingsRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Convai Settings<br/>
        /// Update Convai settings for the workspace
        /// </summary>
        /// <param name="conversationInitiationClientDataWebhook"></param>
        /// <param name="webhooks"></param>
        /// <param name="canUseMcpServers">
        /// Whether the workspace can use MCP servers<br/>
        /// Default Value: false
        /// </param>
        /// <param name="ragRetentionPeriodDays">
        /// Default Value: 10
        /// </param>
        /// <param name="conversationEmbeddingRetentionDays">
        /// Days to retain conversation embeddings. None means use the system default (30 days).
        /// </param>
        /// <param name="defaultLivekitStack">
        /// Default Value: standard
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetConvAISettingsResponseModel> Update7Async(
            global::ElevenLabs.ConversationInitiationClientDataWebhook? conversationInitiationClientDataWebhook = default,
            global::ElevenLabs.ConvAIWebhooks? webhooks = default,
            bool? canUseMcpServers = default,
            int? ragRetentionPeriodDays = default,
            int? conversationEmbeddingRetentionDays = default,
            global::ElevenLabs.LivekitStackType? defaultLivekitStack = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}