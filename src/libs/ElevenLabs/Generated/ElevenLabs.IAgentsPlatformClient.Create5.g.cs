#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Create Conversation<br/>
        /// Create a text conversation with an agent. This does not run the agent, and the agent sends no first message. This endpoint is in alpha and may change.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "ELEVENLABS_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::ElevenLabs.CreateAgentConversationResponse> Create5Async(

            global::ElevenLabs.CreateAgentConversationRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Conversation<br/>
        /// Create a text conversation with an agent. This does not run the agent, and the agent sends no first message. This endpoint is in alpha and may change.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "ELEVENLABS_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.CreateAgentConversationResponse>> Create5AsResponseAsync(

            global::ElevenLabs.CreateAgentConversationRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Conversation<br/>
        /// Create a text conversation with an agent. This does not run the agent, and the agent sends no first message. This endpoint is in alpha and may change.
        /// </summary>
        /// <param name="agent">
        /// The agent that runs the turns.
        /// </param>
        /// <param name="environment">
        /// The environment to use for resolving environment variables (e.g. 'production', 'staging'). Defaults to the branch's environment, then 'production'.
        /// </param>
        /// <param name="userId">
        /// ID of the end user participating in this conversation (for agent owner's user identification)
        /// </param>
        /// <param name="dynamicVariables"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "ELEVENLABS_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::ElevenLabs.CreateAgentConversationResponse> Create5Async(
            global::ElevenLabs.AgentMessagesPersistedAgent agent,
            string? environment = default,
            string? userId = default,
            object? dynamicVariables = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}