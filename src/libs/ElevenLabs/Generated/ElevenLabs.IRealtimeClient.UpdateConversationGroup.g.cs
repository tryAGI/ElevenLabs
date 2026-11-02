#nullable enable

namespace ElevenLabs
{
    public partial interface IRealtimeClient
    {
        /// <summary>
        /// Update Realtime Conversation Group<br/>
        /// Rename or re-describe a realtime conversation group.
        /// </summary>
        /// <param name="conversationGroupId">
        /// The id of a realtime conversation group.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.RealtimeConversationGroupResponseModel> UpdateConversationGroupAsync(
            string conversationGroupId,

            global::ElevenLabs.UpdateRealtimeConversationGroupRequestModel request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Realtime Conversation Group<br/>
        /// Rename or re-describe a realtime conversation group.
        /// </summary>
        /// <param name="conversationGroupId">
        /// The id of a realtime conversation group.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.RealtimeConversationGroupResponseModel>> UpdateConversationGroupAsResponseAsync(
            string conversationGroupId,

            global::ElevenLabs.UpdateRealtimeConversationGroupRequestModel request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Realtime Conversation Group<br/>
        /// Rename or re-describe a realtime conversation group.
        /// </summary>
        /// <param name="conversationGroupId">
        /// The id of a realtime conversation group.
        /// </param>
        /// <param name="title">
        /// Name of the conversation group. Names are unique per workspace, ignoring case and extra whitespace, and at most 64 characters.
        /// </param>
        /// <param name="description">
        /// New description of the conversation group.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.RealtimeConversationGroupResponseModel> UpdateConversationGroupAsync(
            string conversationGroupId,
            string? title = default,
            string? description = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}