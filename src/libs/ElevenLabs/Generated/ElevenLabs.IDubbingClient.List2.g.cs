#nullable enable

namespace ElevenLabs
{
    public partial interface IDubbingClient
    {
        /// <summary>
        /// List Dubbing Language Targets<br/>
        /// List a project's language targets (cursor-paginated).
        /// </summary>
        /// <param name="projectId">
        /// Identifier of the parent dubbing project.
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor from a previous response's next_cursor.
        /// </param>
        /// <param name="pageSize">
        /// Number of language targets per page (max 100).<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="status">
        /// Filter to targets in this status (queued, processing, completed, stale, failed).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.DubbingLanguageListResponse> List2Async(
            string projectId,
            string? cursor = default,
            int? pageSize = default,
            string? status = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Dubbing Language Targets<br/>
        /// List a project's language targets (cursor-paginated).
        /// </summary>
        /// <param name="projectId">
        /// Identifier of the parent dubbing project.
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor from a previous response's next_cursor.
        /// </param>
        /// <param name="pageSize">
        /// Number of language targets per page (max 100).<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="status">
        /// Filter to targets in this status (queued, processing, completed, stale, failed).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.DubbingLanguageListResponse>> List2AsResponseAsync(
            string projectId,
            string? cursor = default,
            int? pageSize = default,
            string? status = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps List2Async as an IAsyncEnumerable&lt;global::ElevenLabs.DubbingLanguageResponse&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="projectId">
        /// Identifier of the parent dubbing project.
        /// </param>
        /// <param name="pageSize">
        /// Number of language targets per page (max 100).<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="status">
        /// Filter to targets in this status (queued, processing, completed, stale, failed).
        /// </param> 
        /// <param name="cursor">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::ElevenLabs.DubbingLanguageResponse> List2AutoPagingAsync(
            string projectId,             int? pageSize = default,
            string? status = default,
            string? cursor = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}