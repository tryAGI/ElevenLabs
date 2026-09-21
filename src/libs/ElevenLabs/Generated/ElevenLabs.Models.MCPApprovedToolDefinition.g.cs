
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Snapshot of the MCP tool definition that was approved.
    /// </summary>
    public sealed partial class MCPApprovedToolDefinition
    {
        /// <summary>
        /// The MCP server-provided tool description at approval time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The MCP server-provided JSON input schema at approval time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_schema")]
        public object? InputSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPApprovedToolDefinition" /> class.
        /// </summary>
        /// <param name="description">
        /// The MCP server-provided tool description at approval time
        /// </param>
        /// <param name="inputSchema">
        /// The MCP server-provided JSON input schema at approval time
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPApprovedToolDefinition(
            string? description,
            object? inputSchema)
        {
            this.Description = description;
            this.InputSchema = inputSchema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPApprovedToolDefinition" /> class.
        /// </summary>
        public MCPApprovedToolDefinition()
        {
        }

    }
}