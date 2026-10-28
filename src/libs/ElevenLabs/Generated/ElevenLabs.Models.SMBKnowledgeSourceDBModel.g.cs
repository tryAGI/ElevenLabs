
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Database model for knowledge sources (files and URLs).<br/>
    /// Inherits:<br/>
    /// - id, workspace_id, from_db, to_db from BaseMongoDBModel<br/>
    /// - owner_user_id from NonSharableCollectionMixin<br/>
    /// - created_at_unix, updated_at_unix from SMBResourceDBModel<br/>
    /// - source_type, source_url, etc. from SMBKnowledgeSourceBase
    /// </summary>
    public sealed partial class SMBKnowledgeSourceDBModel
    {
        /// <summary>
        /// Type of knowledge source.<br/>
        /// Default Value: file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.KnowledgeSourceTypeJsonConverter))]
        public global::ElevenLabs.KnowledgeSourceType? SourceType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_url")]
        public string? SourceUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_scraped_at_unix")]
        public int? LastScrapedAtUnix { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_filename")]
        public string? OriginalFilename { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        public string? ContentType { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_size_bytes")]
        public long? FileSizeBytes { get; set; }

        /// <summary>
        /// Processing status for knowledge sources.<br/>
        /// Simple three-state machine:<br/>
        /// - PROCESSING: Any active work (uploading, crawling, extracting, etc.)<br/>
        /// - READY: Processing complete, results available<br/>
        /// - ERROR: Something went wrong (user can retry)<br/>
        /// Detailed progress is tracked via the `progress` field.<br/>
        /// Default Value: processing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.KnowledgeSourceStatusJsonConverter))]
        public global::ElevenLabs.KnowledgeSourceStatus? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failure_reason")]
        public global::ElevenLabs.IngestFailure? FailureReason { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crawl_entire_site")]
        public bool? CrawlEntireSite { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scraped_pages_count")]
        public int? ScrapedPagesCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_preview")]
        public string? ContentPreview { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processing_started_at_unix")]
        public int? ProcessingStartedAtUnix { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Unix timestamp (seconds since epoch)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_unix")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? CreatedAtUnix { get; set; }

        /// <summary>
        /// Unix timestamp (seconds since epoch)
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
        /// Initializes a new instance of the <see cref="SMBKnowledgeSourceDBModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="sourceType">
        /// Type of knowledge source.<br/>
        /// Default Value: file
        /// </param>
        /// <param name="sourceUrl"></param>
        /// <param name="lastScrapedAtUnix"></param>
        /// <param name="originalFilename"></param>
        /// <param name="contentType"></param>
        /// <param name="fileSizeBytes">
        /// Default Value: 0
        /// </param>
        /// <param name="status">
        /// Processing status for knowledge sources.<br/>
        /// Simple three-state machine:<br/>
        /// - PROCESSING: Any active work (uploading, crawling, extracting, etc.)<br/>
        /// - READY: Processing complete, results available<br/>
        /// - ERROR: Something went wrong (user can retry)<br/>
        /// Detailed progress is tracked via the `progress` field.<br/>
        /// Default Value: processing
        /// </param>
        /// <param name="errorMessage"></param>
        /// <param name="failureReason"></param>
        /// <param name="crawlEntireSite">
        /// Default Value: false
        /// </param>
        /// <param name="scrapedPagesCount">
        /// Default Value: 0
        /// </param>
        /// <param name="contentPreview"></param>
        /// <param name="processingStartedAtUnix"></param>
        /// <param name="createdAtUnix">
        /// Unix timestamp (seconds since epoch)
        /// </param>
        /// <param name="updatedAtUnix">
        /// Unix timestamp (seconds since epoch)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SMBKnowledgeSourceDBModel(
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
        /// Initializes a new instance of the <see cref="SMBKnowledgeSourceDBModel" /> class.
        /// </summary>
        public SMBKnowledgeSourceDBModel()
        {
        }

    }
}