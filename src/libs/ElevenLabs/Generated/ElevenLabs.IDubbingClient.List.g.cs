#nullable enable

namespace ElevenLabs
{
    public partial interface IDubbingClient
    {
        /// <summary>
        /// List Dubbing Projects<br/>
        /// List the dubbing projects in your workspace that you can access, newest first, cursor-paginated. Listed projects carry no `language_ids`; fetch a project, or list its language targets, to see them.
        /// </summary>
        /// <param name="cursor">
        /// Pass the `next_cursor` from a previous response to fetch the page after it. Omit for the first page.
        /// </param>
        /// <param name="pageSize">
        /// Number of projects per page. Clamped to between 1 and 100 rather than rejected, so a larger value returns a full page.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="status">
        /// Filter to projects in this status: `queued`, `preparing`, `ready`, or `failed`. Omit to return every status.
        /// </param>
        /// <param name="sortDirection">
        /// Sort by creation time; newest first by default.<br/>
        /// Default Value: DESCENDING
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.DubbingProjectListResponse> ListAsync(
            string? cursor = default,
            int? pageSize = default,
            string? status = default,
            global::ElevenLabs.DubbingProjectListSortDirection? sortDirection = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Dubbing Projects<br/>
        /// List the dubbing projects in your workspace that you can access, newest first, cursor-paginated. Listed projects carry no `language_ids`; fetch a project, or list its language targets, to see them.
        /// </summary>
        /// <param name="cursor">
        /// Pass the `next_cursor` from a previous response to fetch the page after it. Omit for the first page.
        /// </param>
        /// <param name="pageSize">
        /// Number of projects per page. Clamped to between 1 and 100 rather than rejected, so a larger value returns a full page.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="status">
        /// Filter to projects in this status: `queued`, `preparing`, `ready`, or `failed`. Omit to return every status.
        /// </param>
        /// <param name="sortDirection">
        /// Sort by creation time; newest first by default.<br/>
        /// Default Value: DESCENDING
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.DubbingProjectListResponse>> ListAsResponseAsync(
            string? cursor = default,
            int? pageSize = default,
            string? status = default,
            global::ElevenLabs.DubbingProjectListSortDirection? sortDirection = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps ListAsync as an IAsyncEnumerable&lt;global::ElevenLabs.DubbingProjectResponse&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="pageSize">
        /// Number of projects per page. Clamped to between 1 and 100 rather than rejected, so a larger value returns a full page.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="status">
        /// Filter to projects in this status: `queued`, `preparing`, `ready`, or `failed`. Omit to return every status.
        /// </param>
        /// <param name="sortDirection">
        /// Sort by creation time; newest first by default.<br/>
        /// Default Value: DESCENDING
        /// </param>
        /// <param name="cursor">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::ElevenLabs.DubbingProjectResponse> ListAutoPagingAsync(
              int? pageSize = default,
            string? status = default,
            global::ElevenLabs.DubbingProjectListSortDirection? sortDirection = default,
            string? cursor = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}