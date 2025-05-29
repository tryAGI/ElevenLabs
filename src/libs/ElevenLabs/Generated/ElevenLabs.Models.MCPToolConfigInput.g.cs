
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A MCP tool is a tool that is used to call a MCP server
    /// </summary>
    public sealed partial class MCPToolConfigInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// The maximum time in seconds to wait for the tool call to complete.<br/>
        /// Default Value: 20
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_timeout_secs")]
        public int? ResponseTimeoutSecs { get; set; }

        /// <summary>
        /// The type of tool<br/>
        /// Default Value: mcp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.MCPToolConfigInputTypeJsonConverter))]
        public global::ElevenLabs.MCPToolConfigInputType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::ElevenLabs.ObjectJsonSchemaPropertyInput? Parameters { get; set; }

        /// <summary>
        /// The name of the MCP tool to call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_tool_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string McpToolName { get; set; }

        /// <summary>
        /// The id of the MCP server to call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_server_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string McpServerId { get; set; }

        /// <summary>
        /// Defines the approval model for an MCP tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approval_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.MCPApprovalRequiredModelJsonConverter))]
        public global::ElevenLabs.MCPApprovalRequiredModel? ApprovalMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolConfigInput" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="responseTimeoutSecs">
        /// The maximum time in seconds to wait for the tool call to complete.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="type">
        /// The type of tool<br/>
        /// Default Value: mcp
        /// </param>
        /// <param name="parameters"></param>
        /// <param name="mcpToolName">
        /// The name of the MCP tool to call
        /// </param>
        /// <param name="mcpServerId">
        /// The id of the MCP server to call
        /// </param>
        /// <param name="approvalMode">
        /// Defines the approval model for an MCP tool
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPToolConfigInput(
            string name,
            string description,
            string mcpToolName,
            string mcpServerId,
            string? id,
            int? responseTimeoutSecs,
            global::ElevenLabs.MCPToolConfigInputType? type,
            global::ElevenLabs.ObjectJsonSchemaPropertyInput? parameters,
            global::ElevenLabs.MCPApprovalRequiredModel? approvalMode)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.McpToolName = mcpToolName ?? throw new global::System.ArgumentNullException(nameof(mcpToolName));
            this.McpServerId = mcpServerId ?? throw new global::System.ArgumentNullException(nameof(mcpServerId));
            this.Id = id;
            this.ResponseTimeoutSecs = responseTimeoutSecs;
            this.Type = type;
            this.Parameters = parameters;
            this.ApprovalMode = approvalMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolConfigInput" /> class.
        /// </summary>
        public MCPToolConfigInput()
        {
        }
    }
}