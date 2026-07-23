
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetCrawlJobResponseModel
    {
        /// <summary>
        /// Default Value: discovery
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.CrawlTypeJsonConverter))]
        public global::ElevenLabs.CrawlType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SeedUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern")]
        public string? Pattern { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_depth")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxDepth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_pages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxPages { get; set; }

        /// <summary>
        /// Default Value: queued
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.CrawlStatusJsonConverter))]
        public global::ElevenLabs.CrawlStatus? Status { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages_identified")]
        public int? PagesIdentified { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages_scraped")]
        public int? PagesScraped { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages_skipped")]
        public int? PagesSkipped { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages_failed")]
        public int? PagesFailed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("root_folder_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RootFolderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCrawlJobResponseModel" /> class.
        /// </summary>
        /// <param name="seedUrl"></param>
        /// <param name="maxDepth"></param>
        /// <param name="maxPages"></param>
        /// <param name="rootFolderId"></param>
        /// <param name="updatedAt"></param>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="type">
        /// Default Value: discovery
        /// </param>
        /// <param name="pattern"></param>
        /// <param name="status">
        /// Default Value: queued
        /// </param>
        /// <param name="pagesIdentified">
        /// Default Value: 0
        /// </param>
        /// <param name="pagesScraped">
        /// Default Value: 0
        /// </param>
        /// <param name="pagesSkipped">
        /// Default Value: 0
        /// </param>
        /// <param name="pagesFailed">
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetCrawlJobResponseModel(
            string seedUrl,
            int maxDepth,
            int maxPages,
            string rootFolderId,
            int updatedAt,
            string id,
            int createdAt,
            global::ElevenLabs.CrawlType? type,
            string? pattern,
            global::ElevenLabs.CrawlStatus? status,
            int? pagesIdentified,
            int? pagesScraped,
            int? pagesSkipped,
            int? pagesFailed)
        {
            this.Type = type;
            this.SeedUrl = seedUrl ?? throw new global::System.ArgumentNullException(nameof(seedUrl));
            this.Pattern = pattern;
            this.MaxDepth = maxDepth;
            this.MaxPages = maxPages;
            this.Status = status;
            this.PagesIdentified = pagesIdentified;
            this.PagesScraped = pagesScraped;
            this.PagesSkipped = pagesSkipped;
            this.PagesFailed = pagesFailed;
            this.RootFolderId = rootFolderId ?? throw new global::System.ArgumentNullException(nameof(rootFolderId));
            this.UpdatedAt = updatedAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCrawlJobResponseModel" /> class.
        /// </summary>
        public GetCrawlJobResponseModel()
        {
        }

    }
}