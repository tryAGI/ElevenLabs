#nullable enable

namespace ElevenLabs
{
    public partial interface IConversationalAiClient
    {
        /// <summary>
        /// List Ongoing And Recent Crawl Jobs Created By A User<br/>
        /// Get a list of ongoing and recent crawl jobs for the user.
        /// </summary>
        /// <param name="includeJobIds">
        /// Ids of additional crawl jobs to retrieve
        /// </param>
        /// <param name="pageSize">
        /// How many documents to return at maximum. Can not exceed 100, defaults to 30.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ListCrawlJobsResponseModel> ListAsync(
            global::System.Collections.Generic.IList<string>? includeJobIds = default,
            int? pageSize = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Ongoing And Recent Crawl Jobs Created By A User<br/>
        /// Get a list of ongoing and recent crawl jobs for the user.
        /// </summary>
        /// <param name="includeJobIds">
        /// Ids of additional crawl jobs to retrieve
        /// </param>
        /// <param name="pageSize">
        /// How many documents to return at maximum. Can not exceed 100, defaults to 30.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.ListCrawlJobsResponseModel>> ListAsResponseAsync(
            global::System.Collections.Generic.IList<string>? includeJobIds = default,
            int? pageSize = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps ListAsync as an IAsyncEnumerable&lt;global::ElevenLabs.GetCrawlJobResponseModel&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="includeJobIds">
        /// Ids of additional crawl jobs to retrieve
        /// </param>
        /// <param name="pageSize">
        /// How many documents to return at maximum. Can not exceed 100, defaults to 30.<br/>
        /// Default Value: 30
        /// </param> 
        /// <param name="cursor">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::ElevenLabs.GetCrawlJobResponseModel> ListAutoPagingAsync(
              global::System.Collections.Generic.IList<string>? includeJobIds = default,
            int? pageSize = default,
            string? cursor = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}