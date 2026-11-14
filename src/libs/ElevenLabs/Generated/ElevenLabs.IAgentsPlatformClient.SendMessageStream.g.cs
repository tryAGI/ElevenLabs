#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Send Conversation Message Stream<br/>
        /// Send input to a conversation, and stream the events of the request as server-sent events. The last event is `stream_ended`, which has the outcome of the turn. This endpoint is in alpha and may change.
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
        global::System.Collections.Generic.IAsyncEnumerable<global::ElevenLabs.StreamEnvelope> SendMessageStreamAsync(
            string conversationId,

            global::ElevenLabs.SendConversationMessageStreamRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Send Conversation Message Stream<br/>
        /// Send input to a conversation, and stream the events of the request as server-sent events. The last event is `stream_ended`, which has the outcome of the turn. This endpoint is in alpha and may change.
        /// </summary>
        /// <param name="conversationId">
        /// The Conversation ID
        /// </param>
        /// <param name="input">
        /// Either one `user_message`, which starts a new turn, or `client_tool_result` items, which answer the `required_actions` of the waiting turn and continue it. Calls that they leave out stay pending. Client tools wait with no timeout. While calls are pending, a `user_message` is rejected. A `user_message` can come with `contextual_update` items, at most one per `context_id`. `client_tool_result` items that answer every pending call can come with `end` updates.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "ELEVENLABS_ALPHA_001")]
#endif
        global::System.Collections.Generic.IAsyncEnumerable<global::ElevenLabs.StreamEnvelope> SendMessageStreamAsync(
            string conversationId,
            global::System.Collections.Generic.IList<global::ElevenLabs.InputItem2> input,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}