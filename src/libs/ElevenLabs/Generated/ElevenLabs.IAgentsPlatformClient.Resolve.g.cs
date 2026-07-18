#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Resolve Conversation Reference<br/>
        /// Resolve a conversation URL (a Slack message URL or a Zendesk ticket URL) to the deterministic conversation ID for the given agent, then confirm the conversation exists.
        /// </summary>
        /// <param name="agentId">
        /// Agent id (agent_…) or speech engine external id (seng_), resolved to the same underlying resource.
        /// </param>
        /// <param name="reference">
        /// A Slack message URL or a Zendesk ticket URL.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetConversationResponseModel> ResolveAsync(
            string agentId,
            string reference,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Resolve Conversation Reference<br/>
        /// Resolve a conversation URL (a Slack message URL or a Zendesk ticket URL) to the deterministic conversation ID for the given agent, then confirm the conversation exists.
        /// </summary>
        /// <param name="agentId">
        /// Agent id (agent_…) or speech engine external id (seng_), resolved to the same underlying resource.
        /// </param>
        /// <param name="reference">
        /// A Slack message URL or a Zendesk ticket URL.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.GetConversationResponseModel>> ResolveAsResponseAsync(
            string agentId,
            string reference,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}