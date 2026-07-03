#nullable enable

namespace ElevenLabs
{
    public partial interface IDubbingClient
    {
        /// <summary>
        /// List Dubbing Projects<br/>
        /// List the workspace's dubbing projects (cursor-paginated).
        /// </summary>
        /// <param name="cursor">
        /// Pagination cursor from a previous response's next_cursor.
        /// </param>
        /// <param name="pageSize">
        /// Number of projects per page (max 100).<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="status">
        /// Filter to projects in this status (preparing, ready, failed).
        /// </param>
        /// <param name="sortDirection">
        /// Sort by creation time (default 'DESCENDING').<br/>
        /// Default Value: DESCENDING
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ProjectListResponse> ListAsync(
            string? cursor = default,
            int? pageSize = default,
            string? status = default,
            global::ElevenLabs.DubbingProjectListSortDirection? sortDirection = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Dubbing Projects<br/>
        /// List the workspace's dubbing projects (cursor-paginated).
        /// </summary>
        /// <param name="cursor">
        /// Pagination cursor from a previous response's next_cursor.
        /// </param>
        /// <param name="pageSize">
        /// Number of projects per page (max 100).<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="status">
        /// Filter to projects in this status (preparing, ready, failed).
        /// </param>
        /// <param name="sortDirection">
        /// Sort by creation time (default 'DESCENDING').<br/>
        /// Default Value: DESCENDING
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.ProjectListResponse>> ListAsResponseAsync(
            string? cursor = default,
            int? pageSize = default,
            string? status = default,
            global::ElevenLabs.DubbingProjectListSortDirection? sortDirection = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps ListAsync as an IAsyncEnumerable&lt;global::ElevenLabs.ProjectResponse&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="pageSize">
        /// Number of projects per page (max 100).<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="status">
        /// Filter to projects in this status (preparing, ready, failed).
        /// </param>
        /// <param name="sortDirection">
        /// Sort by creation time (default 'DESCENDING').<br/>
        /// Default Value: DESCENDING
        /// </param> 
        /// <param name="cursor">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::ElevenLabs.ProjectResponse> ListAutoPagingAsync(
              int? pageSize = default,
            string? status = default,
            global::ElevenLabs.DubbingProjectListSortDirection? sortDirection = default,
            string? cursor = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}