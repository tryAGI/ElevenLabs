
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// An MCP tool configuration that can be used to call MCP servers
    /// </summary>
    public sealed partial class MCPToolConfigInput
    {
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
        /// Configuration for extracting values from tool responses and assigning them to dynamic variables
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignments")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableAssignment>? Assignments { get; set; }

        /// <summary>
        /// Default Value: mcp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.MCPToolConfigInputTypeJsonConverter))]
        public global::ElevenLabs.MCPToolConfigInputType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.IntegrationTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.IntegrationType IntegrationType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::ElevenLabs.ObjectJsonSchemaPropertyInput? Parameters { get; set; }

        /// <summary>
        /// Defines the MCP server-level approval policy for tool execution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approval_policy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.MCPApprovalPolicyJsonConverter))]
        public global::ElevenLabs.MCPApprovalPolicy? ApprovalPolicy { get; set; }

        /// <summary>
        /// The name of the MCP tool to call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_tool_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string McpToolName { get; set; }

        /// <summary>
        /// The description of the MCP tool to call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_tool_description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string McpToolDescription { get; set; }

        /// <summary>
        /// The id of the MCP server to call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_server_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string McpServerId { get; set; }

        /// <summary>
        /// The name of the MCP server to call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_server_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string McpServerName { get; set; }

        /// <summary>
        /// Original inputSchema dict for consistent hashing (pure MCP format)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_input_schema")]
        public object? McpInputSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolConfigInput" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="responseTimeoutSecs">
        /// The maximum time in seconds to wait for the tool call to complete.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="assignments">
        /// Configuration for extracting values from tool responses and assigning them to dynamic variables
        /// </param>
        /// <param name="type">
        /// Default Value: mcp
        /// </param>
        /// <param name="integrationType"></param>
        /// <param name="parameters"></param>
        /// <param name="approvalPolicy">
        /// Defines the MCP server-level approval policy for tool execution.
        /// </param>
        /// <param name="mcpToolName">
        /// The name of the MCP tool to call
        /// </param>
        /// <param name="mcpToolDescription">
        /// The description of the MCP tool to call
        /// </param>
        /// <param name="mcpServerId">
        /// The id of the MCP server to call
        /// </param>
        /// <param name="mcpServerName">
        /// The name of the MCP server to call
        /// </param>
        /// <param name="mcpInputSchema">
        /// Original inputSchema dict for consistent hashing (pure MCP format)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPToolConfigInput(
            string name,
            string description,
            global::ElevenLabs.IntegrationType integrationType,
            string mcpToolName,
            string mcpToolDescription,
            string mcpServerId,
            string mcpServerName,
            int? responseTimeoutSecs,
            global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableAssignment>? assignments,
            global::ElevenLabs.MCPToolConfigInputType? type,
            global::ElevenLabs.ObjectJsonSchemaPropertyInput? parameters,
            global::ElevenLabs.MCPApprovalPolicy? approvalPolicy,
            object? mcpInputSchema)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.IntegrationType = integrationType;
            this.McpToolName = mcpToolName ?? throw new global::System.ArgumentNullException(nameof(mcpToolName));
            this.McpToolDescription = mcpToolDescription ?? throw new global::System.ArgumentNullException(nameof(mcpToolDescription));
            this.McpServerId = mcpServerId ?? throw new global::System.ArgumentNullException(nameof(mcpServerId));
            this.McpServerName = mcpServerName ?? throw new global::System.ArgumentNullException(nameof(mcpServerName));
            this.ResponseTimeoutSecs = responseTimeoutSecs;
            this.Assignments = assignments;
            this.Type = type;
            this.Parameters = parameters;
            this.ApprovalPolicy = approvalPolicy;
            this.McpInputSchema = mcpInputSchema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolConfigInput" /> class.
        /// </summary>
        public MCPToolConfigInput()
        {
        }
    }
}