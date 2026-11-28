
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WorkflowUpdateStateNodeModelInput
    {
        /// <summary>
        /// Default Value: update_state
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
        /// Human-readable label for the node used throughout the UI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// List of state updates to apply.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updates")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.StateUpdateInput> Updates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowUpdateStateNodeModelInput" /> class.
        /// </summary>
        /// <param name="label">
        /// Human-readable label for the node used throughout the UI.
        /// </param>
        /// <param name="updates">
        /// List of state updates to apply.
        /// </param>
        /// <param name="type">
        /// Default Value: update_state
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
        public WorkflowUpdateStateNodeModelInput(
            string label,
            global::System.Collections.Generic.IList<global::ElevenLabs.StateUpdateInput> updates,
            string? type,
            global::ElevenLabs.PositionInput? position,
            global::System.Collections.Generic.IList<string>? edgeOrder)
        {
            this.Type = type;
            this.Position = position;
            this.EdgeOrder = edgeOrder;
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Updates = updates ?? throw new global::System.ArgumentNullException(nameof(updates));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowUpdateStateNodeModelInput" /> class.
        /// </summary>
        public WorkflowUpdateStateNodeModelInput()
        {
        }

    }
}