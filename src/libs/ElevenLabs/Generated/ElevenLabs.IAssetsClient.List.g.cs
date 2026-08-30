#nullable enable

namespace ElevenLabs
{
    public partial interface IAssetsClient
    {
        /// <summary>
        /// List Assets<br/>
        /// List assets in the workspace, most recently created first.
        /// </summary>
        /// <param name="pageSize">
        /// Number of assets to return.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="cursor">
        /// Token from a previous response's `next_cursor`. Omit to fetch the first page.
        /// </param>
        /// <param name="search">
        /// Optional free-text search filter over asset names.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AssetListResponse> ListAsync(
            int? pageSize = default,
            string? cursor = default,
            string? search = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Assets<br/>
        /// List assets in the workspace, most recently created first.
        /// </summary>
        /// <param name="pageSize">
        /// Number of assets to return.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="cursor">
        /// Token from a previous response's `next_cursor`. Omit to fetch the first page.
        /// </param>
        /// <param name="search">
        /// Optional free-text search filter over asset names.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.AssetListResponse>> ListAsResponseAsync(
            int? pageSize = default,
            string? cursor = default,
            string? search = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps ListAsync as an IAsyncEnumerable&lt;global::ElevenLabs.AssetResponse&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="pageSize">
        /// Number of assets to return.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="search">
        /// Optional free-text search filter over asset names.
        /// </param>
        /// <param name="cursor">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::ElevenLabs.AssetResponse> ListAutoPagingAsync(
              int? pageSize = default,
            string? search = default,
            string? cursor = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}