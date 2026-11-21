
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentMessagesOverrides
    {
        /// <summary>
        /// The prompt for the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// The LLM to query with the prompt and the chat history. If using data residency, the LLM must be supported in the data residency environment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm")]
        public global::ElevenLabs.Llm? Llm { get; set; }

        /// <summary>
        /// Language of the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// If set, only these tools are available in the conversation, including tools on workflow nodes. Each ID must be attached to the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_ids")]
        public global::System.Collections.Generic.IList<string>? ToolIds { get; set; }

        /// <summary>
        /// If set, the agent uses only these native MCP servers. Each ID must be attached to the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("native_mcp_server_ids")]
        public global::System.Collections.Generic.IList<string>? NativeMcpServerIds { get; set; }

        /// <summary>
        /// If set, the agent uses only these knowledge base documents. Each ID must be attached to the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge_base_ids")]
        public global::System.Collections.Generic.IList<string>? KnowledgeBaseIds { get; set; }

        /// <summary>
        /// If set, only these procedures are available to the starting agent. Each ID must be attached to that agent. An empty list disables all of that agent's procedures. Not applied after an agent transfer. Requires enable_procedure_ids_from_client.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("procedure_ids")]
        public global::System.Collections.Generic.IList<string>? ProcedureIds { get; set; }

        /// <summary>
        /// Extra fields for the request body that goes to the custom LLM.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_llm_extra_body")]
        public object? CustomLlmExtraBody { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentMessagesOverrides" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt for the agent
        /// </param>
        /// <param name="llm">
        /// The LLM to query with the prompt and the chat history. If using data residency, the LLM must be supported in the data residency environment
        /// </param>
        /// <param name="language">
        /// Language of the agent
        /// </param>
        /// <param name="toolIds">
        /// If set, only these tools are available in the conversation, including tools on workflow nodes. Each ID must be attached to the agent.
        /// </param>
        /// <param name="nativeMcpServerIds">
        /// If set, the agent uses only these native MCP servers. Each ID must be attached to the agent.
        /// </param>
        /// <param name="knowledgeBaseIds">
        /// If set, the agent uses only these knowledge base documents. Each ID must be attached to the agent.
        /// </param>
        /// <param name="procedureIds">
        /// If set, only these procedures are available to the starting agent. Each ID must be attached to that agent. An empty list disables all of that agent's procedures. Not applied after an agent transfer. Requires enable_procedure_ids_from_client.
        /// </param>
        /// <param name="customLlmExtraBody">
        /// Extra fields for the request body that goes to the custom LLM.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentMessagesOverrides(
            string? prompt,
            global::ElevenLabs.Llm? llm,
            string? language,
            global::System.Collections.Generic.IList<string>? toolIds,
            global::System.Collections.Generic.IList<string>? nativeMcpServerIds,
            global::System.Collections.Generic.IList<string>? knowledgeBaseIds,
            global::System.Collections.Generic.IList<string>? procedureIds,
            object? customLlmExtraBody)
        {
            this.Prompt = prompt;
            this.Llm = llm;
            this.Language = language;
            this.ToolIds = toolIds;
            this.NativeMcpServerIds = nativeMcpServerIds;
            this.KnowledgeBaseIds = knowledgeBaseIds;
            this.ProcedureIds = procedureIds;
            this.CustomLlmExtraBody = customLlmExtraBody;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentMessagesOverrides" /> class.
        /// </summary>
        public AgentMessagesOverrides()
        {
        }

    }
}