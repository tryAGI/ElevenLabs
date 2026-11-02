
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WorkflowEdgeModelOutput
    {
        /// <summary>
        /// ID of the source node.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        /// ID of the target node.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Target { get; set; }

        /// <summary>
        /// Condition that must be met for the edge to be traversed in the forward direction (source to target).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forward_condition")]
        public global::ElevenLabs.ForwardConditionVariant12? ForwardCondition { get; set; }

        /// <summary>
        /// Condition that must be met for the edge to be traversed in the backward direction (target to source).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backward_condition")]
        public global::ElevenLabs.BackwardConditionVariant12? BackwardCondition { get; set; }

        /// <summary>
        /// Points the edge is routed through between its source and target, in order. Layout only, no effect on execution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reroutes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.PositionOutput> Reroutes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowEdgeModelOutput" /> class.
        /// </summary>
        /// <param name="source">
        /// ID of the source node.
        /// </param>
        /// <param name="target">
        /// ID of the target node.
        /// </param>
        /// <param name="reroutes">
        /// Points the edge is routed through between its source and target, in order. Layout only, no effect on execution.
        /// </param>
        /// <param name="forwardCondition">
        /// Condition that must be met for the edge to be traversed in the forward direction (source to target).
        /// </param>
        /// <param name="backwardCondition">
        /// Condition that must be met for the edge to be traversed in the backward direction (target to source).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowEdgeModelOutput(
            string source,
            string target,
            global::System.Collections.Generic.IList<global::ElevenLabs.PositionOutput> reroutes,
            global::ElevenLabs.ForwardConditionVariant12? forwardCondition,
            global::ElevenLabs.BackwardConditionVariant12? backwardCondition)
        {
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Target = target ?? throw new global::System.ArgumentNullException(nameof(target));
            this.ForwardCondition = forwardCondition;
            this.BackwardCondition = backwardCondition;
            this.Reroutes = reroutes ?? throw new global::System.ArgumentNullException(nameof(reroutes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowEdgeModelOutput" /> class.
        /// </summary>
        public WorkflowEdgeModelOutput()
        {
        }

    }
}