
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptAgentAPIModelOverride
    {
        /// <summary>
        /// The prompt for the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// A list of Native MCP server ids to be used by the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("native_mcp_server_ids")]
        public global::System.Collections.Generic.IList<string>? NativeMcpServerIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAgentAPIModelOverride" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt for the agent
        /// </param>
        /// <param name="nativeMcpServerIds">
        /// A list of Native MCP server ids to be used by the agent
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptAgentAPIModelOverride(
            string? prompt,
            global::System.Collections.Generic.IList<string>? nativeMcpServerIds)
        {
            this.Prompt = prompt;
            this.NativeMcpServerIds = nativeMcpServerIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAgentAPIModelOverride" /> class.
        /// </summary>
        public PromptAgentAPIModelOverride()
        {
        }
    }
}