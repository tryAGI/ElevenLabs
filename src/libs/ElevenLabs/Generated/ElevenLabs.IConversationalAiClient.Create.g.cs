#nullable enable

namespace ElevenLabs
{
    public partial interface IConversationalAiClient
    {
        /// <summary>
        /// Create Crawl Job<br/>
        /// Create a crawl job to crawl the given URL with specified depth and page limits.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.CreateCrawlJobResponseModel> CreateAsync(

            global::ElevenLabs.BodyCreateCrawlJobV1ConvaiKnowledgeBaseCrawlPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Crawl Job<br/>
        /// Create a crawl job to crawl the given URL with specified depth and page limits.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.CreateCrawlJobResponseModel>> CreateAsResponseAsync(

            global::ElevenLabs.BodyCreateCrawlJobV1ConvaiKnowledgeBaseCrawlPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Crawl Job<br/>
        /// Create a crawl job to crawl the given URL with specified depth and page limits.
        /// </summary>
        /// <param name="url">
        /// URL to a page of documentation that the agent will have access to in order to interact with users.
        /// </param>
        /// <param name="maxDepth">
        /// Maximum depth for crawling (1-5), defaults to 3.<br/>
        /// Default Value: 3
        /// </param>
        /// <param name="maxPages">
        /// Maximum number of pages to crawl (1-10,000), defaults to 1000.<br/>
        /// Default Value: 1000
        /// </param>
        /// <param name="pattern">
        /// If set, only URLs that match this pattern are included.
        /// </param>
        /// <param name="sitemapUrls">
        /// List of URLs to crawl from sitemap (optional, overrides automatic URL discovery).
        /// </param>
        /// <param name="parentFolderId">
        /// If set, the created document or folder will be placed inside the given folder.
        /// </param>
        /// <param name="enableAutoSync">
        /// Whether to enable auto-sync for this URL document.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="autoRemove">
        /// Whether to automatically remove the document if the URL becomes unavailable. Only applicable when auto-sync is enabled.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.CreateCrawlJobResponseModel> CreateAsync(
            string url,
            int? maxDepth = default,
            int? maxPages = default,
            string? pattern = default,
            global::System.Collections.Generic.IList<string>? sitemapUrls = default,
            string? parentFolderId = default,
            bool? enableAutoSync = default,
            bool? autoRemove = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}