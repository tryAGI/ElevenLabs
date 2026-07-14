
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentKnowledgeBaseRagQueryRequestModel
    {
        /// <summary>
        /// Query to run against the agent's knowledge base RAG index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentKnowledgeBaseRagQueryRequestModel" /> class.
        /// </summary>
        /// <param name="query">
        /// Query to run against the agent's knowledge base RAG index.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentKnowledgeBaseRagQueryRequestModel(
            string query)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentKnowledgeBaseRagQueryRequestModel" /> class.
        /// </summary>
        public AgentKnowledgeBaseRagQueryRequestModel()
        {
        }

    }
}