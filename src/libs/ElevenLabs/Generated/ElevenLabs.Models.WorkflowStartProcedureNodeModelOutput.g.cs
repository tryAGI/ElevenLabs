
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Starts one procedure when the workflow reaches it.<br/>
    /// A freeform procedure is injected and traversal continues along the node's<br/>
    /// outgoing edges in the same turn. A structured procedure transfers into its<br/>
    /// compiled island with this node as the return node; when it ends, the<br/>
    /// workflow runner hosts this node and evaluates its outgoing edges.
    /// </summary>
    public sealed partial class WorkflowStartProcedureNodeModelOutput
    {
        /// <summary>
        /// Default Value: start_procedure
        /// </summary>
        /// <default>"start_procedure"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "start_procedure";

        /// <summary>
        /// Position of the node in the workflow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.PositionOutput Position { get; set; }

        /// <summary>
        /// The ids of outgoing edges in the order they should be evaluated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edge_order")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> EdgeOrder { get; set; }

        /// <summary>
        /// ID of the procedure to start when the workflow reaches this node.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("procedure_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProcedureId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowStartProcedureNodeModelOutput" /> class.
        /// </summary>
        /// <param name="position">
        /// Position of the node in the workflow.
        /// </param>
        /// <param name="edgeOrder">
        /// The ids of outgoing edges in the order they should be evaluated.
        /// </param>
        /// <param name="procedureId">
        /// ID of the procedure to start when the workflow reaches this node.
        /// </param>
        /// <param name="type">
        /// Default Value: start_procedure
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowStartProcedureNodeModelOutput(
            global::ElevenLabs.PositionOutput position,
            global::System.Collections.Generic.IList<string> edgeOrder,
            string procedureId,
            string type = "start_procedure")
        {
            this.Type = type;
            this.Position = position ?? throw new global::System.ArgumentNullException(nameof(position));
            this.EdgeOrder = edgeOrder ?? throw new global::System.ArgumentNullException(nameof(edgeOrder));
            this.ProcedureId = procedureId ?? throw new global::System.ArgumentNullException(nameof(procedureId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowStartProcedureNodeModelOutput" /> class.
        /// </summary>
        public WorkflowStartProcedureNodeModelOutput()
        {
        }

    }
}