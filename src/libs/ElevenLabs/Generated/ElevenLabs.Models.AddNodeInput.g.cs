
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddNodeInput
    {
        /// <summary>
        /// The type of node to create.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.FlowNodeTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.FlowNodeType Type { get; set; }

        /// <summary>
        /// Optional display label for the node.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Model ID to use. If not set, the default model for the node type is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public global::ElevenLabs.ModelID? ModelId { get; set; }

        /// <summary>
        /// Initial model parameters. Use get_model_schema to see valid parameters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_parameters")]
        public object? ModelParameters { get; set; }

        /// <summary>
        /// Optional prompt text for the node.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Existing node IDs that should feed INTO this new node. Pass these when you already know the upstream wiring — the canvas places the new node correctly on creation instead of parking it first and reflowing later.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connect_from")]
        public global::System.Collections.Generic.IList<string>? ConnectFrom { get; set; }

        /// <summary>
        /// Existing node IDs that this new node should feed INTO. Same purpose as connect_from but for downstream wiring.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connect_to")]
        public global::System.Collections.Generic.IList<string>? ConnectTo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddNodeInput" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of node to create.
        /// </param>
        /// <param name="label">
        /// Optional display label for the node.
        /// </param>
        /// <param name="modelId">
        /// Model ID to use. If not set, the default model for the node type is used.
        /// </param>
        /// <param name="modelParameters">
        /// Initial model parameters. Use get_model_schema to see valid parameters.
        /// </param>
        /// <param name="prompt">
        /// Optional prompt text for the node.
        /// </param>
        /// <param name="connectFrom">
        /// Existing node IDs that should feed INTO this new node. Pass these when you already know the upstream wiring — the canvas places the new node correctly on creation instead of parking it first and reflowing later.
        /// </param>
        /// <param name="connectTo">
        /// Existing node IDs that this new node should feed INTO. Same purpose as connect_from but for downstream wiring.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddNodeInput(
            global::ElevenLabs.FlowNodeType type,
            string? label,
            global::ElevenLabs.ModelID? modelId,
            object? modelParameters,
            string? prompt,
            global::System.Collections.Generic.IList<string>? connectFrom,
            global::System.Collections.Generic.IList<string>? connectTo)
        {
            this.Type = type;
            this.Label = label;
            this.ModelId = modelId;
            this.ModelParameters = modelParameters;
            this.Prompt = prompt;
            this.ConnectFrom = connectFrom;
            this.ConnectTo = connectTo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddNodeInput" /> class.
        /// </summary>
        public AddNodeInput()
        {
        }
    }
}