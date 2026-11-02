#nullable enable

namespace ElevenLabs
{
    public partial interface IRealtimeClient
    {
        /// <summary>
        /// Clear Realtime Conversation Group<br/>
        /// Remove a realtime conversation from its conversation group.
        /// </summary>
        /// <param name="conversationId">
        /// The id of a realtime conversation.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ClearConversationGroupAsync(
            string conversationId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Clear Realtime Conversation Group<br/>
        /// Remove a realtime conversation from its conversation group.
        /// </summary>
        /// <param name="conversationId">
        /// The id of a realtime conversation.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<string>> ClearConversationGroupAsResponseAsync(
            string conversationId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}