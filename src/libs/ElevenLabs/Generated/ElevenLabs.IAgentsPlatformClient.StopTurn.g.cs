#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Stop Conversation Turn<br/>
        /// Stop the latest turn of a conversation, and wait until it ends. The turn then has the `interrupted` status, or its own status if it ended before the stop. If the turn does not end in time, the endpoint returns 202 and `in_progress`. This endpoint is in alpha and may change.
        /// </summary>
        /// <param name="conversationId">
        /// The Conversation ID
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "ELEVENLABS_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::ElevenLabs.ConversationTurn> StopTurnAsync(
            string conversationId,

            global::ElevenLabs.StopConversationTurnRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stop Conversation Turn<br/>
        /// Stop the latest turn of a conversation, and wait until it ends. The turn then has the `interrupted` status, or its own status if it ended before the stop. If the turn does not end in time, the endpoint returns 202 and `in_progress`. This endpoint is in alpha and may change.
        /// </summary>
        /// <param name="conversationId">
        /// The Conversation ID
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "ELEVENLABS_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.ConversationTurn>> StopTurnAsResponseAsync(
            string conversationId,

            global::ElevenLabs.StopConversationTurnRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stop Conversation Turn<br/>
        /// Stop the latest turn of a conversation, and wait until it ends. The turn then has the `interrupted` status, or its own status if it ended before the stop. If the turn does not end in time, the endpoint returns 202 and `in_progress`. This endpoint is in alpha and may change.
        /// </summary>
        /// <param name="conversationId">
        /// The Conversation ID
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "ELEVENLABS_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::ElevenLabs.ConversationTurn> StopTurnAsync(
            string conversationId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}