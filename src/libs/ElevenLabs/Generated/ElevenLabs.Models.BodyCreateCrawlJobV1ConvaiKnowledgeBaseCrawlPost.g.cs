
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyCreateCrawlJobV1ConvaiKnowledgeBaseCrawlPost
    {
        /// <summary>
        /// URL to a page of documentation that the agent will have access to in order to interact with users.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Maximum depth for crawling (1-5), defaults to 3.<br/>
        /// Default Value: 3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_depth")]
        public int? MaxDepth { get; set; }

        /// <summary>
        /// Maximum number of pages to crawl (1-10,000), defaults to 1000.<br/>
        /// Default Value: 1000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_pages")]
        public int? MaxPages { get; set; }

        /// <summary>
        /// If set, only URLs that match this pattern are included.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern")]
        public string? Pattern { get; set; }

        /// <summary>
        /// List of URLs to crawl from sitemap (optional, overrides automatic URL discovery).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sitemap_urls")]
        public global::System.Collections.Generic.IList<string>? SitemapUrls { get; set; }

        /// <summary>
        /// If set, the created document or folder will be placed inside the given folder.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_folder_id")]
        public string? ParentFolderId { get; set; }

        /// <summary>
        /// Whether to enable auto-sync for this URL document.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_auto_sync")]
        public bool? EnableAutoSync { get; set; }

        /// <summary>
        /// Whether to automatically remove the document if the URL becomes unavailable. Only applicable when auto-sync is enabled.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_remove")]
        public bool? AutoRemove { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateCrawlJobV1ConvaiKnowledgeBaseCrawlPost" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyCreateCrawlJobV1ConvaiKnowledgeBaseCrawlPost(
            string url,
            int? maxDepth,
            int? maxPages,
            string? pattern,
            global::System.Collections.Generic.IList<string>? sitemapUrls,
            string? parentFolderId,
            bool? enableAutoSync,
            bool? autoRemove)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.MaxDepth = maxDepth;
            this.MaxPages = maxPages;
            this.Pattern = pattern;
            this.SitemapUrls = sitemapUrls;
            this.ParentFolderId = parentFolderId;
            this.EnableAutoSync = enableAutoSync;
            this.AutoRemove = autoRemove;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateCrawlJobV1ConvaiKnowledgeBaseCrawlPost" /> class.
        /// </summary>
        public BodyCreateCrawlJobV1ConvaiKnowledgeBaseCrawlPost()
        {
        }

    }
}