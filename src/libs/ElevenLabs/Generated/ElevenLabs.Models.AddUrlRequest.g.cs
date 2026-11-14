
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A web page or site to learn from.
    /// </summary>
    public sealed partial class AddUrlRequest
    {
        /// <summary>
        /// The HTTPS page or site to read.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Crawl the whole site instead of only the page at url.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crawl_entire_site")]
        public bool? CrawlEntireSite { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddUrlRequest" /> class.
        /// </summary>
        /// <param name="url">
        /// The HTTPS page or site to read.
        /// </param>
        /// <param name="crawlEntireSite">
        /// Crawl the whole site instead of only the page at url.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddUrlRequest(
            string url,
            bool? crawlEntireSite)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.CrawlEntireSite = crawlEntireSite;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddUrlRequest" /> class.
        /// </summary>
        public AddUrlRequest()
        {
        }

    }
}