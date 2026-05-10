
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ASTLLMNodeOutput
    {
        /// <summary>
        /// Default Value: llm
        /// </summary>
        /// <default>"llm"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "llm";

        /// <summary>
        /// JSON schema describing the value that the LLM should extract.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.LLMLiteralJsonSchemaProperty ValueSchema { get; set; }

        /// <summary>
        /// The prompt to evaluate to a boolean value. Deprecated. Use a boolean schema instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTLLMNodeOutput" /> class.
        /// </summary>
        /// <param name="valueSchema">
        /// JSON schema describing the value that the LLM should extract.
        /// </param>
        /// <param name="prompt">
        /// The prompt to evaluate to a boolean value. Deprecated. Use a boolean schema instead.
        /// </param>
        /// <param name="type">
        /// Default Value: llm
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ASTLLMNodeOutput(
            global::ElevenLabs.LLMLiteralJsonSchemaProperty valueSchema,
            string prompt,
            string type = "llm")
        {
            this.Type = type;
            this.ValueSchema = valueSchema ?? throw new global::System.ArgumentNullException(nameof(valueSchema));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTLLMNodeOutput" /> class.
        /// </summary>
        public ASTLLMNodeOutput()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ASTLLMNodeOutput"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ASTLLMNodeOutput FromValueSchema(global::ElevenLabs.LLMLiteralJsonSchemaProperty valueSchema)
        {
            return new ASTLLMNodeOutput
            {
                ValueSchema = valueSchema,
            };
        }

    }
}