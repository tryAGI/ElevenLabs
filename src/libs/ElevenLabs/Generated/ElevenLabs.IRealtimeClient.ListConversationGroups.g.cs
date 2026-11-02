#nullable enable

namespace ElevenLabs
{
    public partial interface IRealtimeClient
    {
        /// <summary>
        /// List Realtime Conversation Groups<br/>
        /// List the realtime conversation groups the current user can view.
        /// </summary>
        /// <param name="pageSize">
        /// How many conversation groups to return. Can not exceed 100.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="search">
        /// If specified, only conversation groups whose title or description contains this string (case-insensitive) are returned.
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.RealtimeConversationGroupsResponseModel> ListConversationGroupsAsync(
            int? pageSize = default,
            string? search = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Realtime Conversation Groups<br/>
        /// List the realtime conversation groups the current user can view.
        /// </summary>
        /// <param name="pageSize">
        /// How many conversation groups to return. Can not exceed 100.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="search">
        /// If specified, only conversation groups whose title or description contains this string (case-insensitive) are returned.
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.RealtimeConversationGroupsResponseModel>> ListConversationGroupsAsResponseAsync(
            int? pageSize = default,
            string? search = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps ListConversationGroupsAsync as an IAsyncEnumerable&lt;global::ElevenLabs.RealtimeConversationGroupResponseModel&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="pageSize">
        /// How many conversation groups to return. Can not exceed 100.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="search">
        /// If specified, only conversation groups whose title or description contains this string (case-insensitive) are returned.
        /// </param>
        /// <param name="cursor">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::ElevenLabs.RealtimeConversationGroupResponseModel> ListConversationGroupsAutoPagingAsync(
              int? pageSize = default,
            string? search = default,
            string? cursor = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}