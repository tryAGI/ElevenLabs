#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Get Conversation Turn<br/>
        /// Get the status and output of a turn. The status comes from the stored transcript, so a turn that failed after the agent started can show as completed. Only the `stream_ended` event has the real outcome. This endpoint is in alpha and may change.
        /// </summary>
        /// <param name="conversationId">
        /// The Conversation ID
        /// </param>
        /// <param name="turnId">
        /// The Turn ID
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "ELEVENLABS_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::ElevenLabs.ConversationTurn> GetTurnAsync(
            string conversationId,
            string turnId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Conversation Turn<br/>
        /// Get the status and output of a turn. The status comes from the stored transcript, so a turn that failed after the agent started can show as completed. Only the `stream_ended` event has the real outcome. This endpoint is in alpha and may change.
        /// </summary>
        /// <param name="conversationId">
        /// The Conversation ID
        /// </param>
        /// <param name="turnId">
        /// The Turn ID
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "ELEVENLABS_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.ConversationTurn>> GetTurnAsResponseAsync(
            string conversationId,
            string turnId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}