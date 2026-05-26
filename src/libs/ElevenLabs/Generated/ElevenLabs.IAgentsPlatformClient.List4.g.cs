#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// List Conversation Tags<br/>
        /// List conversation tags for the workspace, ordered by most recently created first.
        /// </summary>
        /// <param name="pageSize">
        /// How many conversation tags to return. Can not exceed 100.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetConversationTagsPageResponseModel> List4Async(
            int? pageSize = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Conversation Tags<br/>
        /// List conversation tags for the workspace, ordered by most recently created first.
        /// </summary>
        /// <param name="pageSize">
        /// How many conversation tags to return. Can not exceed 100.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.GetConversationTagsPageResponseModel>> List4AsResponseAsync(
            int? pageSize = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps List4Async as an IAsyncEnumerable<global::ElevenLabs.ConversationTagResponseModel> that auto-pages over the response.
        /// </summary>
        /// <param name="pageSize">
        /// How many conversation tags to return. Can not exceed 100.<br/>
        /// Default Value: 100
        /// </param> 
        /// <param name="cursor">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::ElevenLabs.ConversationTagResponseModel> List4AutoPagingAsync(
              int? pageSize = default,
            string? cursor = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}