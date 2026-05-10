
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KnowledgeBaseContentSearchResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.DocumentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.Document Document { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_snippet")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.SearchHighlightSegment>? SearchSnippet { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseContentSearchResult" /> class.
        /// </summary>
        /// <param name="document"></param>
        /// <param name="score"></param>
        /// <param name="searchSnippet"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeBaseContentSearchResult(
            global::ElevenLabs.Document document,
            double score,
            global::System.Collections.Generic.IList<global::ElevenLabs.SearchHighlightSegment>? searchSnippet)
        {
            this.Document = document;
            this.SearchSnippet = searchSnippet;
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseContentSearchResult" /> class.
        /// </summary>
        public KnowledgeBaseContentSearchResult()
        {
        }

    }
}