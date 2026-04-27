
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MutationResult
    {
        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node")]
        public global::ElevenLabs.NodeVariant1? Node { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_ids")]
        public global::System.Collections.Generic.IList<string>? NodeIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_nodes")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.CreatedNodesVariant1Item>? CreatedNodes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edges")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.EdgeData>? Edges { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canvas_summary")]
        public global::ElevenLabs.CanvasSummary? CanvasSummary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::System.Collections.Generic.IList<string>? Errors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_error")]
        public global::ElevenLabs.ValidationErrorDetail? ValidationError { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_ports")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.PortDefinition>? InputPorts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orphaned_edges")]
        public global::System.Collections.Generic.IList<string>? OrphanedEdges { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MutationResult" /> class.
        /// </summary>
        /// <param name="success">
        /// Default Value: true
        /// </param>
        /// <param name="node"></param>
        /// <param name="nodeIds"></param>
        /// <param name="createdNodes"></param>
        /// <param name="edges"></param>
        /// <param name="canvasSummary"></param>
        /// <param name="errors"></param>
        /// <param name="validationError"></param>
        /// <param name="inputPorts"></param>
        /// <param name="orphanedEdges"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MutationResult(
            bool? success,
            global::ElevenLabs.NodeVariant1? node,
            global::System.Collections.Generic.IList<string>? nodeIds,
            global::System.Collections.Generic.IList<global::ElevenLabs.CreatedNodesVariant1Item>? createdNodes,
            global::System.Collections.Generic.IList<global::ElevenLabs.EdgeData>? edges,
            global::ElevenLabs.CanvasSummary? canvasSummary,
            global::System.Collections.Generic.IList<string>? errors,
            global::ElevenLabs.ValidationErrorDetail? validationError,
            global::System.Collections.Generic.IList<global::ElevenLabs.PortDefinition>? inputPorts,
            global::System.Collections.Generic.IList<string>? orphanedEdges)
        {
            this.Success = success;
            this.Node = node;
            this.NodeIds = nodeIds;
            this.CreatedNodes = createdNodes;
            this.Edges = edges;
            this.CanvasSummary = canvasSummary;
            this.Errors = errors;
            this.ValidationError = validationError;
            this.InputPorts = inputPorts;
            this.OrphanedEdges = orphanedEdges;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MutationResult" /> class.
        /// </summary>
        public MutationResult()
        {
        }
    }
}