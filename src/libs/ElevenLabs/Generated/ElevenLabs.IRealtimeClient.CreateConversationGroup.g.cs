#nullable enable

namespace ElevenLabs
{
    public partial interface IRealtimeClient
    {
        /// <summary>
        /// Create Realtime Conversation Group<br/>
        /// Create a realtime conversation group owned by the current user.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.RealtimeConversationGroupResponseModel> CreateConversationGroupAsync(

            global::ElevenLabs.CreateRealtimeConversationGroupRequestModel request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Realtime Conversation Group<br/>
        /// Create a realtime conversation group owned by the current user.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.RealtimeConversationGroupResponseModel>> CreateConversationGroupAsResponseAsync(

            global::ElevenLabs.CreateRealtimeConversationGroupRequestModel request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Realtime Conversation Group<br/>
        /// Create a realtime conversation group owned by the current user.
        /// </summary>
        /// <param name="title">
        /// Name of the conversation group. Names are unique per workspace, ignoring case and extra whitespace, and at most 64 characters.
        /// </param>
        /// <param name="description">
        /// Optional description of the conversation group.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.RealtimeConversationGroupResponseModel> CreateConversationGroupAsync(
            string title,
            string? description = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}