
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerationNode
    {
        /// <summary>
        /// Model-specific parameters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_parameters")]
        public object? ModelParameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationNode" /> class.
        /// </summary>
        /// <param name="modelParameters">
        /// Model-specific parameters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationNode(
            object? modelParameters)
        {
            this.ModelParameters = modelParameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationNode" /> class.
        /// </summary>
        public GenerationNode()
        {
        }

    }
}