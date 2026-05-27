#nullable enable

namespace ElevenLabs
{
    public partial interface ISpeechEngineClient
    {
        /// <summary>
        /// List Speech Engines<br/>
        /// Returns a paginated list of Speech Engine resources.
        /// </summary>
        /// <param name="pageSize">
        /// How many Speech Engines to return at maximum. Can not exceed 100, defaults to 30.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="search">
        /// Search term to filter Speech Engines by name
        /// </param>
        /// <param name="sortDirection">
        /// The direction to sort the results<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="sortBy">
        /// The field to sort the results by
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ListSpeechEnginesResponse> ListAsync(
            int? pageSize = default,
            string? search = default,
            global::ElevenLabs.SortDirection? sortDirection = default,
            global::ElevenLabs.AgentSortBy? sortBy = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Speech Engines<br/>
        /// Returns a paginated list of Speech Engine resources.
        /// </summary>
        /// <param name="pageSize">
        /// How many Speech Engines to return at maximum. Can not exceed 100, defaults to 30.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="search">
        /// Search term to filter Speech Engines by name
        /// </param>
        /// <param name="sortDirection">
        /// The direction to sort the results<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="sortBy">
        /// The field to sort the results by
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.ListSpeechEnginesResponse>> ListAsResponseAsync(
            int? pageSize = default,
            string? search = default,
            global::ElevenLabs.SortDirection? sortDirection = default,
            global::ElevenLabs.AgentSortBy? sortBy = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps ListAsync as an IAsyncEnumerable&lt;global::ElevenLabs.SpeechEngineSummaryResponse&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="pageSize">
        /// How many Speech Engines to return at maximum. Can not exceed 100, defaults to 30.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="search">
        /// Search term to filter Speech Engines by name
        /// </param>
        /// <param name="sortDirection">
        /// The direction to sort the results<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="sortBy">
        /// The field to sort the results by
        /// </param> 
        /// <param name="cursor">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::ElevenLabs.SpeechEngineSummaryResponse> ListAutoPagingAsync(
              int? pageSize = default,
            string? search = default,
            global::ElevenLabs.SortDirection? sortDirection = default,
            global::ElevenLabs.AgentSortBy? sortBy = default,
            string? cursor = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}