
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"knowledge_base":[],"llm":"gemini-2.0-flash-001","prompt":"You are a helpful assistant that can answer questions about the topic of the conversation.","tool_ids":[]}
    /// </summary>
    public sealed partial class PromptAgentAPIModelOverrideOutput
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
        /// A list of IDs of tools used by the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_ids")]
        public global::System.Collections.Generic.IList<string>? ToolIds { get; set; }

        /// <summary>
        /// A list of Native MCP server ids to be used by the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("native_mcp_server_ids")]
        public global::System.Collections.Generic.IList<string>? NativeMcpServerIds { get; set; }

        /// <summary>
        /// A list of knowledge bases to be used by the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge_base")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseLocator>? KnowledgeBase { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAgentAPIModelOverrideOutput" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt for the agent
        /// </param>
        /// <param name="llm">
        /// The LLM to query with the prompt and the chat history. If using data residency, the LLM must be supported in the data residency environment
        /// </param>
        /// <param name="toolIds">
        /// A list of IDs of tools used by the agent
        /// </param>
        /// <param name="nativeMcpServerIds">
        /// A list of Native MCP server ids to be used by the agent
        /// </param>
        /// <param name="knowledgeBase">
        /// A list of knowledge bases to be used by the agent
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptAgentAPIModelOverrideOutput(
            string? prompt,
            global::ElevenLabs.Llm? llm,
            global::System.Collections.Generic.IList<string>? toolIds,
            global::System.Collections.Generic.IList<string>? nativeMcpServerIds,
            global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseLocator>? knowledgeBase)
        {
            this.Prompt = prompt;
            this.Llm = llm;
            this.ToolIds = toolIds;
            this.NativeMcpServerIds = nativeMcpServerIds;
            this.KnowledgeBase = knowledgeBase;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAgentAPIModelOverrideOutput" /> class.
        /// </summary>
        public PromptAgentAPIModelOverrideOutput()
        {
        }
    }
}