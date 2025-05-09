
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A MCP tool is a tool that is used to call a MCP server
    /// </summary>
    public sealed partial class MCPToolConfigOutput
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
        /// The type of tool<br/>
        /// Default Value: mcp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.MCPToolConfigOutputTypeJsonConverter))]
        public global::ElevenLabs.MCPToolConfigOutputType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::ElevenLabs.ObjectJsonSchemaPropertyOutput? Parameters { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolConfigOutput" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPToolConfigOutput(
            string name,
            string description,
            string mcpToolName,
            string mcpServerId,
            string? id,
            global::ElevenLabs.MCPToolConfigOutputType? type,
            global::ElevenLabs.ObjectJsonSchemaPropertyOutput? parameters)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.McpToolName = mcpToolName ?? throw new global::System.ArgumentNullException(nameof(mcpToolName));
            this.McpServerId = mcpServerId ?? throw new global::System.ArgumentNullException(nameof(mcpServerId));
            this.Id = id;
            this.Type = type;
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolConfigOutput" /> class.
        /// </summary>
        public MCPToolConfigOutput()
        {
        }
    }
}