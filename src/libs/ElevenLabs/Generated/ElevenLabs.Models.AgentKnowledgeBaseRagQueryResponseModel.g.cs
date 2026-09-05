
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"chunks":[{"chunk_id":"chunk_498cjVigY5qzO86Huf0OWal","content_format":"html","document_id":"doc_J3Pbu5gP6NNKBscdCdwB","document_name":"Account FAQ","document_type":"url","source_url":"https://example.com/account-faq?utm_medium=agents_citation\u0026utm_source=elevenlabs","text":"To reset your password, open Settings and choose Security...","vector_distance":0.21}],"retrieval_query":"How do I reset my password?"}
    /// </summary>
    public sealed partial class AgentKnowledgeBaseRagQueryResponseModel
    {
        /// <summary>
        /// Raw query used for retrieval (echoes the request query).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retrieval_query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RetrievalQuery { get; set; }

        /// <summary>
        /// Ranked chunks the agent would retrieve, after distance and length filtering.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.AgentKnowledgeBaseRagChunkResponseModel> Chunks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentKnowledgeBaseRagQueryResponseModel" /> class.
        /// </summary>
        /// <param name="retrievalQuery">
        /// Raw query used for retrieval (echoes the request query).
        /// </param>
        /// <param name="chunks">
        /// Ranked chunks the agent would retrieve, after distance and length filtering.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentKnowledgeBaseRagQueryResponseModel(
            string retrievalQuery,
            global::System.Collections.Generic.IList<global::ElevenLabs.AgentKnowledgeBaseRagChunkResponseModel> chunks)
        {
            this.RetrievalQuery = retrievalQuery ?? throw new global::System.ArgumentNullException(nameof(retrievalQuery));
            this.Chunks = chunks ?? throw new global::System.ArgumentNullException(nameof(chunks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentKnowledgeBaseRagQueryResponseModel" /> class.
        /// </summary>
        public AgentKnowledgeBaseRagQueryResponseModel()
        {
        }

    }
}