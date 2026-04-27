
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PreviewNodeModelInput
    {
        /// <summary>
        /// The node type to preview the model for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeType { get; set; }

        /// <summary>
        /// The model ID to preview.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewNodeModelInput" /> class.
        /// </summary>
        /// <param name="nodeType">
        /// The node type to preview the model for.
        /// </param>
        /// <param name="modelId">
        /// The model ID to preview.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PreviewNodeModelInput(
            string nodeType,
            string modelId)
        {
            this.NodeType = nodeType ?? throw new global::System.ArgumentNullException(nameof(nodeType));
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewNodeModelInput" /> class.
        /// </summary>
        public PreviewNodeModelInput()
        {
        }
    }
}