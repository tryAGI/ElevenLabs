#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Update Conversation Tag<br/>
        /// Update a conversation tag's title and/or description. Restricted to the tag owner or a workspace admin.
        /// </summary>
        /// <param name="tagId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ConversationTagResponseModel> Update3Async(
            string tagId,

            global::ElevenLabs.PatchConversationTagRequestModel request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Conversation Tag<br/>
        /// Update a conversation tag's title and/or description. Restricted to the tag owner or a workspace admin.
        /// </summary>
        /// <param name="tagId"></param>
        /// <param name="title">
        /// If provided, replaces the tag title. Omit to leave unchanged.
        /// </param>
        /// <param name="description">
        /// If provided, replaces the tag description. Omit to leave unchanged.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ConversationTagResponseModel> Update3Async(
            string tagId,
            string? title = default,
            string? description = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}