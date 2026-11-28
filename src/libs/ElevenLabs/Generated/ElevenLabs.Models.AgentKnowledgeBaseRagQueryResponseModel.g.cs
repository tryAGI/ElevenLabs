
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"chunks":[{"chunk_id":"chunk_498cjVigY5qzO86Huf0OWal","content_format":"html","document_id":"doc_J3Pbu5gP6NNKBscdCdwB","document_name":"Account FAQ","document_type":"url","source_url":"https://example.com/account-faq?utm_medium=agents_citation\u0026utm_source=elevenlabs","text":"To reset your password, open Settings and choose Security...","vector_distance":0.21}],"retrieval_query":"How do I reset my password?","strategy":"semantic"}
    /// </summary>
    public sealed partial class AgentKnowledgeBaseRagQueryResponseModel
    {
        /// <summary>
        /// Retrieval strategy that ran.<br/>
        /// Default Value: semantic
        /// </summary>
        /// <default>global::ElevenLabs.SearchStrategy.Semantic</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("strategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.SearchStrategyJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.SearchStrategy Strategy { get; set; } = global::ElevenLabs.SearchStrategy.Semantic;

        /// <summary>
        /// Raw query used for retrieval (echoes the request query), or null for the cat and ls strategies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retrieval_query")]
        public string? RetrievalQuery { get; set; }

        /// <summary>
        /// Ranked chunks the agent would retrieve with semantic or keyword search, after distance and length filtering. Empty for the cat and ls strategies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.AgentKnowledgeBaseRagChunkResponseModel> Chunks { get; set; }

        /// <summary>
        /// Document read by the cat strategy, or null when the reference matched no document or another strategy ran.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document")]
        public global::ElevenLabs.AgentKnowledgeBaseRagDocumentResponseModel? Document { get; set; }

        /// <summary>
        /// Entries listed by the ls strategy, or null when the reference matched nothing or another strategy ran.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("listing")]
        public global::ElevenLabs.AgentKnowledgeBaseRagListingResponseModel? Listing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentKnowledgeBaseRagQueryResponseModel" /> class.
        /// </summary>
        /// <param name="strategy">
        /// Retrieval strategy that ran.<br/>
        /// Default Value: semantic
        /// </param>
        /// <param name="chunks">
        /// Ranked chunks the agent would retrieve with semantic or keyword search, after distance and length filtering. Empty for the cat and ls strategies.
        /// </param>
        /// <param name="retrievalQuery">
        /// Raw query used for retrieval (echoes the request query), or null for the cat and ls strategies.
        /// </param>
        /// <param name="document">
        /// Document read by the cat strategy, or null when the reference matched no document or another strategy ran.
        /// </param>
        /// <param name="listing">
        /// Entries listed by the ls strategy, or null when the reference matched nothing or another strategy ran.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentKnowledgeBaseRagQueryResponseModel(
            global::ElevenLabs.SearchStrategy strategy,
            global::System.Collections.Generic.IList<global::ElevenLabs.AgentKnowledgeBaseRagChunkResponseModel> chunks,
            string? retrievalQuery,
            global::ElevenLabs.AgentKnowledgeBaseRagDocumentResponseModel? document,
            global::ElevenLabs.AgentKnowledgeBaseRagListingResponseModel? listing)
        {
            this.Strategy = strategy;
            this.RetrievalQuery = retrievalQuery;
            this.Chunks = chunks ?? throw new global::System.ArgumentNullException(nameof(chunks));
            this.Document = document;
            this.Listing = listing;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentKnowledgeBaseRagQueryResponseModel" /> class.
        /// </summary>
        public AgentKnowledgeBaseRagQueryResponseModel()
        {
        }

    }
}