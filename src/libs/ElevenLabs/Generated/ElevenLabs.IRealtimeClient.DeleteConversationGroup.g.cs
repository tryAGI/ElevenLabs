#nullable enable

namespace ElevenLabs
{
    public partial interface IRealtimeClient
    {
        /// <summary>
        /// Delete Realtime Conversation Group<br/>
        /// Delete a realtime conversation group. Every conversation in it becomes ungrouped, so access granted through the group is revoked.
        /// </summary>
        /// <param name="conversationGroupId">
        /// The id of a realtime conversation group.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteConversationGroupAsync(
            string conversationGroupId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Realtime Conversation Group<br/>
        /// Delete a realtime conversation group. Every conversation in it becomes ungrouped, so access granted through the group is revoked.
        /// </summary>
        /// <param name="conversationGroupId">
        /// The id of a realtime conversation group.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<string>> DeleteConversationGroupAsResponseAsync(
            string conversationGroupId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}