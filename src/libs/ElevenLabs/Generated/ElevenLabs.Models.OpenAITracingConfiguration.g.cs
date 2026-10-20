
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Only ``group_id`` is acted on; ``workflow_name`` and ``metadata`` are kept so the echoed session matches the request.
    /// </summary>
    public sealed partial class OpenAITracingConfiguration
    {
        /// <summary>
        /// Adds conversation to the group (case-insensitive, up to 64 chars).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_id")]
        public string? GroupId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_name")]
        public string? WorkflowName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAITracingConfiguration" /> class.
        /// </summary>
        /// <param name="groupId">
        /// Adds conversation to the group (case-insensitive, up to 64 chars).
        /// </param>
        /// <param name="workflowName"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAITracingConfiguration(
            string? groupId,
            string? workflowName,
            object? metadata)
        {
            this.GroupId = groupId;
            this.WorkflowName = workflowName;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAITracingConfiguration" /> class.
        /// </summary>
        public OpenAITracingConfiguration()
        {
        }

    }
}