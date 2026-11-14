#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Send Conversation Message<br/>
        /// Send input to a conversation, and wait until the agent finishes or waits on client tool results. With `background` set to true, the endpoint returns 202 when the server admits the turn. Then stream the turn's events with `Last-Event-ID` set to the `stream_cursor`. This endpoint is in alpha and may change.
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
        global::System.Threading.Tasks.Task<global::ElevenLabs.ConversationTurn> SendMessageAsync(
            string conversationId,

            global::ElevenLabs.SendConversationMessageRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Send Conversation Message<br/>
        /// Send input to a conversation, and wait until the agent finishes or waits on client tool results. With `background` set to true, the endpoint returns 202 when the server admits the turn. Then stream the turn's events with `Last-Event-ID` set to the `stream_cursor`. This endpoint is in alpha and may change.
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
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.ConversationTurn>> SendMessageAsResponseAsync(
            string conversationId,

            global::ElevenLabs.SendConversationMessageRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Send Conversation Message<br/>
        /// Send input to a conversation, and wait until the agent finishes or waits on client tool results. With `background` set to true, the endpoint returns 202 when the server admits the turn. Then stream the turn's events with `Last-Event-ID` set to the `stream_cursor`. This endpoint is in alpha and may change.
        /// </summary>
        /// <param name="conversationId">
        /// The Conversation ID
        /// </param>
        /// <param name="input">
        /// Either one `user_message`, which starts a new turn, or `client_tool_result` items, which answer the `required_actions` of the waiting turn and continue it. Calls that they leave out stay pending. Client tools wait with no timeout. While calls are pending, a `user_message` is rejected. A `user_message` can come with `contextual_update` items, at most one per `context_id`. `client_tool_result` items that answer every pending call can come with `end` updates.
        /// </param>
        /// <param name="background">
        /// If true, return a 202 handle after the turn is admitted instead of waiting for generation to finish.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "ELEVENLABS_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::ElevenLabs.ConversationTurn> SendMessageAsync(
            string conversationId,
            global::System.Collections.Generic.IList<global::ElevenLabs.InputItem> input,
            bool? background = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}