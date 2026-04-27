
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateNodeInput
    {
        /// <summary>
        /// The ID of the node to update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// Switch to a new model. Resets model_parameters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public global::ElevenLabs.ModelID? ModelId { get; set; }

        /// <summary>
        /// Full model parameters. Use get_model_schema to see valid parameters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_parameters")]
        public object? ModelParameters { get; set; }

        /// <summary>
        /// Set prompt text, or a reference dict with template_node_id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, object, object>))]
        public global::ElevenLabs.AnyOf<string, object, object>? Prompt { get; set; }

        /// <summary>
        /// Set the display label.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Set the active generation ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_generation_id")]
        public string? ActiveGenerationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateNodeInput" /> class.
        /// </summary>
        /// <param name="nodeId">
        /// The ID of the node to update.
        /// </param>
        /// <param name="modelId">
        /// Switch to a new model. Resets model_parameters.
        /// </param>
        /// <param name="modelParameters">
        /// Full model parameters. Use get_model_schema to see valid parameters.
        /// </param>
        /// <param name="prompt">
        /// Set prompt text, or a reference dict with template_node_id.
        /// </param>
        /// <param name="label">
        /// Set the display label.
        /// </param>
        /// <param name="activeGenerationId">
        /// Set the active generation ID.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateNodeInput(
            string nodeId,
            global::ElevenLabs.ModelID? modelId,
            object? modelParameters,
            global::ElevenLabs.AnyOf<string, object, object>? prompt,
            string? label,
            string? activeGenerationId)
        {
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.ModelId = modelId;
            this.ModelParameters = modelParameters;
            this.Prompt = prompt;
            this.Label = label;
            this.ActiveGenerationId = activeGenerationId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateNodeInput" /> class.
        /// </summary>
        public UpdateNodeInput()
        {
        }
    }
}