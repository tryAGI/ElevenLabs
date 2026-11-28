#nullable enable

namespace ElevenLabs
{
    public partial interface ISmbClient
    {
        /// <summary>
        /// List Reseller Workspaces<br/>
        /// List workspaces attributed to the caller's reseller, with cursor-based pagination
        /// </summary>
        /// <param name="cursor">
        /// Pagination cursor from previous response
        /// </param>
        /// <param name="pageSize">
        /// Number of workspaces per page<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="search">
        /// Case-insensitive substring of the business name
        /// </param>
        /// <param name="sort">
        /// Order of the workspaces, newest first by default<br/>
        /// Default Value: newest
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ResellerWorkspacesResponse> List11Async(
            string? cursor = default,
            int? pageSize = default,
            string? search = default,
            global::ElevenLabs.ResellerWorkspaceSort? sort = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Reseller Workspaces<br/>
        /// List workspaces attributed to the caller's reseller, with cursor-based pagination
        /// </summary>
        /// <param name="cursor">
        /// Pagination cursor from previous response
        /// </param>
        /// <param name="pageSize">
        /// Number of workspaces per page<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="search">
        /// Case-insensitive substring of the business name
        /// </param>
        /// <param name="sort">
        /// Order of the workspaces, newest first by default<br/>
        /// Default Value: newest
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.ResellerWorkspacesResponse>> List11AsResponseAsync(
            string? cursor = default,
            int? pageSize = default,
            string? search = default,
            global::ElevenLabs.ResellerWorkspaceSort? sort = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps List11Async as an IAsyncEnumerable&lt;global::ElevenLabs.ResellerWorkspaceSummary&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="pageSize">
        /// Number of workspaces per page<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="search">
        /// Case-insensitive substring of the business name
        /// </param>
        /// <param name="sort">
        /// Order of the workspaces, newest first by default<br/>
        /// Default Value: newest
        /// </param>
        /// <param name="cursor">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::ElevenLabs.ResellerWorkspaceSummary> List11AutoPagingAsync(
              int? pageSize = default,
            string? search = default,
            global::ElevenLabs.ResellerWorkspaceSort? sort = default,
            string? cursor = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}