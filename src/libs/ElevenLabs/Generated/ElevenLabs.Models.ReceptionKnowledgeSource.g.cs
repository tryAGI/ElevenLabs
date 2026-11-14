
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A file or web page the receptionists learn from.
    /// </summary>
    public sealed partial class ReceptionKnowledgeSource
    {
        /// <summary>
        /// Whether the source is an uploaded file or a web page or site.<br/>
        /// Default Value: file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.KnowledgeSourceTypeJsonConverter))]
        public global::ElevenLabs.KnowledgeSourceType? SourceType { get; set; }

        /// <summary>
        /// The page or site URL for 'url' sources.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_url")]
        public string? SourceUrl { get; set; }

        /// <summary>
        /// When the URL was last read, as a Unix timestamp in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_scraped_at_unix")]
        public int? LastScrapedAtUnix { get; set; }

        /// <summary>
        /// The uploaded file's name for 'file' sources; empty for URLs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_filename")]
        public string? OriginalFilename { get; set; }

        /// <summary>
        /// The uploaded file's MIME type; empty for URLs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        public string? ContentType { get; set; }

        /// <summary>
        /// The uploaded file's size in bytes; 0 for URLs.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_size_bytes")]
        public long? FileSizeBytes { get; set; }

        /// <summary>
        /// Where processing stands: 'processing', 'ready' or 'error'.<br/>
        /// Default Value: processing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.KnowledgeSourceStatusJsonConverter))]
        public global::ElevenLabs.KnowledgeSourceStatus? Status { get; set; }

        /// <summary>
        /// Why processing failed, when status is 'error'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Machine-readable cause of the failure, when status is 'error'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failure_reason")]
        public global::ElevenLabs.IngestFailure? FailureReason { get; set; }

        /// <summary>
        /// Whether the whole site was crawled rather than the single page at source_url.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crawl_entire_site")]
        public bool? CrawlEntireSite { get; set; }

        /// <summary>
        /// How many pages were read for 'url' sources.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scraped_pages_count")]
        public int? ScrapedPagesCount { get; set; }

        /// <summary>
        /// A short plain-text preview of the content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_preview")]
        public string? ContentPreview { get; set; }

        /// <summary>
        /// When processing started, as a Unix timestamp in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processing_started_at_unix")]
        public int? ProcessingStartedAtUnix { get; set; }

        /// <summary>
        /// The knowledge source's ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// When this was created, as a Unix timestamp in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_unix")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? CreatedAtUnix { get; set; }

        /// <summary>
        /// When this was last updated, as a Unix timestamp in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at_unix")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? UpdatedAtUnix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReceptionKnowledgeSource" /> class.
        /// </summary>
        /// <param name="id">
        /// The knowledge source's ID.
        /// </param>
        /// <param name="sourceType">
        /// Whether the source is an uploaded file or a web page or site.<br/>
        /// Default Value: file
        /// </param>
        /// <param name="sourceUrl">
        /// The page or site URL for 'url' sources.
        /// </param>
        /// <param name="lastScrapedAtUnix">
        /// When the URL was last read, as a Unix timestamp in seconds.
        /// </param>
        /// <param name="originalFilename">
        /// The uploaded file's name for 'file' sources; empty for URLs.
        /// </param>
        /// <param name="contentType">
        /// The uploaded file's MIME type; empty for URLs.
        /// </param>
        /// <param name="fileSizeBytes">
        /// The uploaded file's size in bytes; 0 for URLs.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="status">
        /// Where processing stands: 'processing', 'ready' or 'error'.<br/>
        /// Default Value: processing
        /// </param>
        /// <param name="errorMessage">
        /// Why processing failed, when status is 'error'.
        /// </param>
        /// <param name="failureReason">
        /// Machine-readable cause of the failure, when status is 'error'.
        /// </param>
        /// <param name="crawlEntireSite">
        /// Whether the whole site was crawled rather than the single page at source_url.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="scrapedPagesCount">
        /// How many pages were read for 'url' sources.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="contentPreview">
        /// A short plain-text preview of the content.
        /// </param>
        /// <param name="processingStartedAtUnix">
        /// When processing started, as a Unix timestamp in seconds.
        /// </param>
        /// <param name="createdAtUnix">
        /// When this was created, as a Unix timestamp in seconds.
        /// </param>
        /// <param name="updatedAtUnix">
        /// When this was last updated, as a Unix timestamp in seconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReceptionKnowledgeSource(
            string id,
            global::ElevenLabs.KnowledgeSourceType? sourceType,
            string? sourceUrl,
            int? lastScrapedAtUnix,
            string? originalFilename,
            string? contentType,
            long? fileSizeBytes,
            global::ElevenLabs.KnowledgeSourceStatus? status,
            string? errorMessage,
            global::ElevenLabs.IngestFailure? failureReason,
            bool? crawlEntireSite,
            int? scrapedPagesCount,
            string? contentPreview,
            int? processingStartedAtUnix,
            global::System.DateTimeOffset? createdAtUnix,
            global::System.DateTimeOffset? updatedAtUnix)
        {
            this.SourceType = sourceType;
            this.SourceUrl = sourceUrl;
            this.LastScrapedAtUnix = lastScrapedAtUnix;
            this.OriginalFilename = originalFilename;
            this.ContentType = contentType;
            this.FileSizeBytes = fileSizeBytes;
            this.Status = status;
            this.ErrorMessage = errorMessage;
            this.FailureReason = failureReason;
            this.CrawlEntireSite = crawlEntireSite;
            this.ScrapedPagesCount = scrapedPagesCount;
            this.ContentPreview = contentPreview;
            this.ProcessingStartedAtUnix = processingStartedAtUnix;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAtUnix = createdAtUnix;
            this.UpdatedAtUnix = updatedAtUnix;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReceptionKnowledgeSource" /> class.
        /// </summary>
        public ReceptionKnowledgeSource()
        {
        }

    }
}