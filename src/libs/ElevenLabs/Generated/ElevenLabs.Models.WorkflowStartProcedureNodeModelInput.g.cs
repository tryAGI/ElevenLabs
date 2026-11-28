
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
    public sealed partial class WorkflowStartProcedureNodeModelInput
    {
        /// <summary>
        /// Default Value: start_procedure
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Position of the node in the workflow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        public global::ElevenLabs.PositionInput? Position { get; set; }

        /// <summary>
        /// The ids of outgoing edges in the order they should be evaluated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edge_order")]
        public global::System.Collections.Generic.IList<string>? EdgeOrder { get; set; }

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
        /// Initializes a new instance of the <see cref="WorkflowStartProcedureNodeModelInput" /> class.
        /// </summary>
        /// <param name="procedureId">
        /// ID of the procedure to start when the workflow reaches this node.
        /// </param>
        /// <param name="type">
        /// Default Value: start_procedure
        /// </param>
        /// <param name="position">
        /// Position of the node in the workflow.
        /// </param>
        /// <param name="edgeOrder">
        /// The ids of outgoing edges in the order they should be evaluated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowStartProcedureNodeModelInput(
            string procedureId,
            string? type,
            global::ElevenLabs.PositionInput? position,
            global::System.Collections.Generic.IList<string>? edgeOrder)
        {
            this.Type = type;
            this.Position = position;
            this.EdgeOrder = edgeOrder;
            this.ProcedureId = procedureId ?? throw new global::System.ArgumentNullException(nameof(procedureId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowStartProcedureNodeModelInput" /> class.
        /// </summary>
        public WorkflowStartProcedureNodeModelInput()
        {
        }

    }
}