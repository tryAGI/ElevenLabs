
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ASTLLMNodeInputASTLLMNode
    {
        /// <summary>
        /// Default Value: llm
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// JSON schema describing the value that the LLM should extract.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.LLMLiteralJsonSchemaProperty ValueSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTLLMNodeInputASTLLMNode" /> class.
        /// </summary>
        /// <param name="valueSchema">
        /// JSON schema describing the value that the LLM should extract.
        /// </param>
        /// <param name="type">
        /// Default Value: llm
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ASTLLMNodeInputASTLLMNode(
            global::ElevenLabs.LLMLiteralJsonSchemaProperty valueSchema,
            string? type)
        {
            this.Type = type;
            this.ValueSchema = valueSchema ?? throw new global::System.ArgumentNullException(nameof(valueSchema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTLLMNodeInputASTLLMNode" /> class.
        /// </summary>
        public ASTLLMNodeInputASTLLMNode()
        {
        }
    }
}