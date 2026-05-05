#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Get Signed Url<br/>
        /// Get a signed url to start a conversation with an agent with an agent that requires authorization
        /// </summary>
        /// <param name="agentId">
        /// The id of the agent you're taking the action on.
        /// </param>
        /// <param name="includeConversationId">
        /// Whether to include a conversation_id with the response. If included, the conversation_signature cannot be used again.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="branchId">
        /// The ID of the branch to use
        /// </param>
        /// <param name="environment">
        /// The environment to use for resolving environment variables (e.g. 'production', 'staging'). Defaults to 'production'.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ConversationSignedUrlResponseModel> GetSignedUrlAsync(
            string agentId,
            bool? includeConversationId = default,
            string? branchId = default,
            string? environment = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Signed Url<br/>
        /// Get a signed url to start a conversation with an agent with an agent that requires authorization
        /// </summary>
        /// <param name="agentId">
        /// The id of the agent you're taking the action on.
        /// </param>
        /// <param name="includeConversationId">
        /// Whether to include a conversation_id with the response. If included, the conversation_signature cannot be used again.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="branchId">
        /// The ID of the branch to use
        /// </param>
        /// <param name="environment">
        /// The environment to use for resolving environment variables (e.g. 'production', 'staging'). Defaults to 'production'.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.ConversationSignedUrlResponseModel>> GetSignedUrlAsResponseAsync(
            string agentId,
            bool? includeConversationId = default,
            string? branchId = default,
            string? environment = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}