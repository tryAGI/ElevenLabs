
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Derived approval state for a currently discovered MCP tool.
    /// </summary>
    public sealed partial class MCPToolApprovalStatus
    {
        /// <summary>
        /// Canonical MCP tool identifier in the form mcp:&lt;server_id&gt;:&lt;tool_name&gt;
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolId { get; set; }

        /// <summary>
        /// Whether a stored approval exists and still matches the live tool definition
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.MCPToolApprovalStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.MCPToolApprovalState State { get; set; }

        /// <summary>
        /// Stored execution policy. Set when the tool has an approval.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approval_policy")]
        public global::ElevenLabs.MCPToolApprovalPolicy? ApprovalPolicy { get; set; }

        /// <summary>
        /// Previously approved definition, included when the tool needs review and a snapshot exists.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approved_definition")]
        public global::ElevenLabs.MCPApprovedToolDefinition? ApprovedDefinition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolApprovalStatus" /> class.
        /// </summary>
        /// <param name="toolId">
        /// Canonical MCP tool identifier in the form mcp:&lt;server_id&gt;:&lt;tool_name&gt;
        /// </param>
        /// <param name="state">
        /// Whether a stored approval exists and still matches the live tool definition
        /// </param>
        /// <param name="approvalPolicy">
        /// Stored execution policy. Set when the tool has an approval.
        /// </param>
        /// <param name="approvedDefinition">
        /// Previously approved definition, included when the tool needs review and a snapshot exists.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPToolApprovalStatus(
            string toolId,
            global::ElevenLabs.MCPToolApprovalState state,
            global::ElevenLabs.MCPToolApprovalPolicy? approvalPolicy,
            global::ElevenLabs.MCPApprovedToolDefinition? approvedDefinition)
        {
            this.ToolId = toolId ?? throw new global::System.ArgumentNullException(nameof(toolId));
            this.State = state;
            this.ApprovalPolicy = approvalPolicy;
            this.ApprovedDefinition = approvedDefinition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolApprovalStatus" /> class.
        /// </summary>
        public MCPToolApprovalStatus()
        {
        }

    }
}