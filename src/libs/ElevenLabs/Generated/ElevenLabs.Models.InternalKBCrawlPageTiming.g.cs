
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Per-document timing data for one crawled page.
    /// </summary>
    public sealed partial class InternalKBCrawlPageTiming
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("doc_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DocId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read_ms")]
        public int? ReadMs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index_ms")]
        public int? IndexMs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_len")]
        public int? HtmlLen { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipped")]
        public bool? Skipped { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public bool? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalKBCrawlPageTiming" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="docId"></param>
        /// <param name="readMs"></param>
        /// <param name="indexMs"></param>
        /// <param name="htmlLen"></param>
        /// <param name="skipped">
        /// Default Value: false
        /// </param>
        /// <param name="error">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InternalKBCrawlPageTiming(
            string url,
            string docId,
            int? readMs,
            int? indexMs,
            int? htmlLen,
            bool? skipped,
            bool? error)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.DocId = docId ?? throw new global::System.ArgumentNullException(nameof(docId));
            this.ReadMs = readMs;
            this.IndexMs = indexMs;
            this.HtmlLen = htmlLen;
            this.Skipped = skipped;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalKBCrawlPageTiming" /> class.
        /// </summary>
        public InternalKBCrawlPageTiming()
        {
        }

    }
}