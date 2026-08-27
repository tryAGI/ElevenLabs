
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WorkflowToolLocator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolId { get; set; }

        /// <summary>
        /// Per-node parameter overrides applied on top of the tool's own configuration. Keys are dotted parameter paths (webhook tools prefix keys with path_params./query_params./request_body.). These take precedence over any overrides already defined on the tool itself.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema_overrides")]
        public object? SchemaOverrides { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowToolLocator" /> class.
        /// </summary>
        /// <param name="toolId"></param>
        /// <param name="schemaOverrides">
        /// Per-node parameter overrides applied on top of the tool's own configuration. Keys are dotted parameter paths (webhook tools prefix keys with path_params./query_params./request_body.). These take precedence over any overrides already defined on the tool itself.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowToolLocator(
            string toolId,
            object? schemaOverrides)
        {
            this.ToolId = toolId ?? throw new global::System.ArgumentNullException(nameof(toolId));
            this.SchemaOverrides = schemaOverrides;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowToolLocator" /> class.
        /// </summary>
        public WorkflowToolLocator()
        {
        }

    }
}