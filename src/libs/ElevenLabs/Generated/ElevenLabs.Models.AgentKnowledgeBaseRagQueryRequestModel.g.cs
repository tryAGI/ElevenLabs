
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentKnowledgeBaseRagQueryRequestModel
    {
        /// <summary>
        /// Retrieval strategy to run, as in the agent's knowledge_base tool: semantic or keyword search for a query, cat to read one document in full, or ls to list the entries of a folder. Any strategy runs, whether or not the agent has it enabled.<br/>
        /// Default Value: semantic
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.SearchStrategyJsonConverter))]
        public global::ElevenLabs.SearchStrategy? Strategy { get; set; }

        /// <summary>
        /// Query to search the knowledge base for. Required for the semantic and keyword strategies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// IDs or names of knowledge base documents or folders. Semantic and keyword search only search these entries; cat reads the single document given; ls lists the single folder given, or the top level of the knowledge base when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documents")]
        public global::System.Collections.Generic.IList<string>? Documents { get; set; }

        /// <summary>
        /// When true (the default), retrieval uses the agent's own RAG settings, reproducing exactly what the agent would retrieve. Set to false to retrieve with neutral default RAG settings instead (the agent's embedding model is always kept, since it determines which vector index exists). Useful for auditing the knowledge base independently of how a particular agent is tuned.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_agent_defaults")]
        public bool? UseAgentDefaults { get; set; }

        /// <summary>
        /// Optional maximum total character length of document chunks returned. Overrides the selected RAG settings for this query only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_documents_length")]
        public int? MaxDocumentsLength { get; set; }

        /// <summary>
        /// Optional maximum number of document chunks retrieved. Overrides the selected RAG settings for this query only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_retrieved_rag_chunks_count")]
        public int? MaxRetrievedRagChunksCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentKnowledgeBaseRagQueryRequestModel" /> class.
        /// </summary>
        /// <param name="strategy">
        /// Retrieval strategy to run, as in the agent's knowledge_base tool: semantic or keyword search for a query, cat to read one document in full, or ls to list the entries of a folder. Any strategy runs, whether or not the agent has it enabled.<br/>
        /// Default Value: semantic
        /// </param>
        /// <param name="query">
        /// Query to search the knowledge base for. Required for the semantic and keyword strategies.
        /// </param>
        /// <param name="documents">
        /// IDs or names of knowledge base documents or folders. Semantic and keyword search only search these entries; cat reads the single document given; ls lists the single folder given, or the top level of the knowledge base when omitted.
        /// </param>
        /// <param name="useAgentDefaults">
        /// When true (the default), retrieval uses the agent's own RAG settings, reproducing exactly what the agent would retrieve. Set to false to retrieve with neutral default RAG settings instead (the agent's embedding model is always kept, since it determines which vector index exists). Useful for auditing the knowledge base independently of how a particular agent is tuned.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="maxDocumentsLength">
        /// Optional maximum total character length of document chunks returned. Overrides the selected RAG settings for this query only.
        /// </param>
        /// <param name="maxRetrievedRagChunksCount">
        /// Optional maximum number of document chunks retrieved. Overrides the selected RAG settings for this query only.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentKnowledgeBaseRagQueryRequestModel(
            global::ElevenLabs.SearchStrategy? strategy,
            string? query,
            global::System.Collections.Generic.IList<string>? documents,
            bool? useAgentDefaults,
            int? maxDocumentsLength,
            int? maxRetrievedRagChunksCount)
        {
            this.Strategy = strategy;
            this.Query = query;
            this.Documents = documents;
            this.UseAgentDefaults = useAgentDefaults;
            this.MaxDocumentsLength = maxDocumentsLength;
            this.MaxRetrievedRagChunksCount = maxRetrievedRagChunksCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentKnowledgeBaseRagQueryRequestModel" /> class.
        /// </summary>
        public AgentKnowledgeBaseRagQueryRequestModel()
        {
        }

    }
}