
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptAgentAPIModelInput
    {
        /// <summary>
        /// The prompt for the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.LLMJsonConverter))]
        public global::ElevenLabs.LLM? Llm { get; set; }

        /// <summary>
        /// The temperature for the LLM<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// If greater than 0, maximum number of tokens the LLM can predict<br/>
        /// Default Value: -1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// A list of IDs of tools used by the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_ids")]
        public global::System.Collections.Generic.IList<string>? ToolIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("built_in_tools")]
        public global::ElevenLabs.BuiltInToolsInput? BuiltInTools { get; set; }

        /// <summary>
        /// A list of MCP server ids to be used by the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_server_ids")]
        public global::System.Collections.Generic.IList<string>? McpServerIds { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_llm")]
        public global::ElevenLabs.CustomLLM? CustomLlm { get; set; }

        /// <summary>
        /// Whether to ignore the default personality<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignore_default_personality")]
        public bool? IgnoreDefaultPersonality { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rag")]
        public global::ElevenLabs.RagConfig? Rag { get; set; }

        /// <summary>
        /// Timezone for displaying current time in system prompt. If set, the current time will be included in the system prompt using this timezone. Must be a valid timezone name (e.g., 'America/New_York', 'Europe/London', 'UTC').
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// A list of tools that the agent can use over the course of the conversation, use tool_ids instead
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem2>? Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAgentAPIModelInput" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt for the agent
        /// </param>
        /// <param name="llm"></param>
        /// <param name="temperature">
        /// The temperature for the LLM<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="maxTokens">
        /// If greater than 0, maximum number of tokens the LLM can predict<br/>
        /// Default Value: -1
        /// </param>
        /// <param name="toolIds">
        /// A list of IDs of tools used by the agent
        /// </param>
        /// <param name="builtInTools"></param>
        /// <param name="mcpServerIds">
        /// A list of MCP server ids to be used by the agent
        /// </param>
        /// <param name="nativeMcpServerIds">
        /// A list of Native MCP server ids to be used by the agent
        /// </param>
        /// <param name="knowledgeBase">
        /// A list of knowledge bases to be used by the agent
        /// </param>
        /// <param name="customLlm"></param>
        /// <param name="ignoreDefaultPersonality">
        /// Whether to ignore the default personality<br/>
        /// Default Value: false
        /// </param>
        /// <param name="rag"></param>
        /// <param name="timezone">
        /// Timezone for displaying current time in system prompt. If set, the current time will be included in the system prompt using this timezone. Must be a valid timezone name (e.g., 'America/New_York', 'Europe/London', 'UTC').
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptAgentAPIModelInput(
            string? prompt,
            global::ElevenLabs.LLM? llm,
            double? temperature,
            int? maxTokens,
            global::System.Collections.Generic.IList<string>? toolIds,
            global::ElevenLabs.BuiltInToolsInput? builtInTools,
            global::System.Collections.Generic.IList<string>? mcpServerIds,
            global::System.Collections.Generic.IList<string>? nativeMcpServerIds,
            global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseLocator>? knowledgeBase,
            global::ElevenLabs.CustomLLM? customLlm,
            bool? ignoreDefaultPersonality,
            global::ElevenLabs.RagConfig? rag,
            string? timezone)
        {
            this.Prompt = prompt;
            this.Llm = llm;
            this.Temperature = temperature;
            this.MaxTokens = maxTokens;
            this.ToolIds = toolIds;
            this.BuiltInTools = builtInTools;
            this.McpServerIds = mcpServerIds;
            this.NativeMcpServerIds = nativeMcpServerIds;
            this.KnowledgeBase = knowledgeBase;
            this.CustomLlm = customLlm;
            this.IgnoreDefaultPersonality = ignoreDefaultPersonality;
            this.Rag = rag;
            this.Timezone = timezone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAgentAPIModelInput" /> class.
        /// </summary>
        public PromptAgentAPIModelInput()
        {
        }
    }
}