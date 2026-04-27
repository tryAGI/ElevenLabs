
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddEdgeSpec
    {
        /// <summary>
        /// ID of the source node.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceNodeId { get; set; }

        /// <summary>
        /// ID of the target node.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetNodeId { get; set; }

        /// <summary>
        /// Target port override. Usually auto-determined from source output type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_port")]
        public string? TargetPort { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddEdgeSpec" /> class.
        /// </summary>
        /// <param name="sourceNodeId">
        /// ID of the source node.
        /// </param>
        /// <param name="targetNodeId">
        /// ID of the target node.
        /// </param>
        /// <param name="targetPort">
        /// Target port override. Usually auto-determined from source output type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddEdgeSpec(
            string sourceNodeId,
            string targetNodeId,
            string? targetPort)
        {
            this.SourceNodeId = sourceNodeId ?? throw new global::System.ArgumentNullException(nameof(sourceNodeId));
            this.TargetNodeId = targetNodeId ?? throw new global::System.ArgumentNullException(nameof(targetNodeId));
            this.TargetPort = targetPort;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddEdgeSpec" /> class.
        /// </summary>
        public AddEdgeSpec()
        {
        }
    }
}