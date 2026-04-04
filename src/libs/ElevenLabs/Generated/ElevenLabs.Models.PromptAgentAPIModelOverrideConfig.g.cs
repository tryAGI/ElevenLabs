
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptAgentAPIModelOverrideConfig
    {
        /// <summary>
        /// Whether to allow overriding the prompt field.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public bool? Prompt { get; set; }

        /// <summary>
        /// Whether to allow overriding the llm field.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm")]
        public bool? Llm { get; set; }

        /// <summary>
        /// Whether to allow overriding the tool_ids field.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_ids")]
        public bool? ToolIds { get; set; }

        /// <summary>
        /// Whether to allow overriding the native_mcp_server_ids field.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("native_mcp_server_ids")]
        public bool? NativeMcpServerIds { get; set; }

        /// <summary>
        /// Whether to allow overriding the knowledge_base field.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge_base")]
        public bool? KnowledgeBase { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAgentAPIModelOverrideConfig" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Whether to allow overriding the prompt field.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="llm">
        /// Whether to allow overriding the llm field.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="toolIds">
        /// Whether to allow overriding the tool_ids field.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="nativeMcpServerIds">
        /// Whether to allow overriding the native_mcp_server_ids field.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="knowledgeBase">
        /// Whether to allow overriding the knowledge_base field.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptAgentAPIModelOverrideConfig(
            bool? prompt,
            bool? llm,
            bool? toolIds,
            bool? nativeMcpServerIds,
            bool? knowledgeBase)
        {
            this.Prompt = prompt;
            this.Llm = llm;
            this.ToolIds = toolIds;
            this.NativeMcpServerIds = nativeMcpServerIds;
            this.KnowledgeBase = knowledgeBase;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAgentAPIModelOverrideConfig" /> class.
        /// </summary>
        public PromptAgentAPIModelOverrideConfig()
        {
        }
    }
}