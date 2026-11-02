#nullable enable

namespace ElevenLabs
{
    public partial interface IRealtimeClient
    {
        /// <summary>
        /// Set Realtime Conversation Group<br/>
        /// Place a realtime conversation in a conversation group, moving it out of its current group if it has one.
        /// </summary>
        /// <param name="conversationId">
        /// The id of a realtime conversation.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> SetConversationGroupAsync(
            string conversationId,

            global::ElevenLabs.SetConversationGroupRequestModel request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set Realtime Conversation Group<br/>
        /// Place a realtime conversation in a conversation group, moving it out of its current group if it has one.
        /// </summary>
        /// <param name="conversationId">
        /// The id of a realtime conversation.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<string>> SetConversationGroupAsResponseAsync(
            string conversationId,

            global::ElevenLabs.SetConversationGroupRequestModel request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set Realtime Conversation Group<br/>
        /// Place a realtime conversation in a conversation group, moving it out of its current group if it has one.
        /// </summary>
        /// <param name="conversationId">
        /// The id of a realtime conversation.
        /// </param>
        /// <param name="conversationGroupId">
        /// The conversation group to place the conversation in. A conversation belongs to at most one group, so this moves it out of any current group.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> SetConversationGroupAsync(
            string conversationId,
            string conversationGroupId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}