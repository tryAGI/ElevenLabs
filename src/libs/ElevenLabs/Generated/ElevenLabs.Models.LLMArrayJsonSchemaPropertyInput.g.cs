
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LLMArrayJsonSchemaPropertyInput
    {
        /// <summary>
        /// Default Value: array
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.LLMLiteralJsonSchemaProperty, global::ElevenLabs.LLMObjectJsonSchemaPropertyInput, global::ElevenLabs.LLMArrayJsonSchemaPropertyInput, global::ElevenLabs.LLMAnyOfJsonSchemaPropertyInput>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.OneOf<global::ElevenLabs.LLMLiteralJsonSchemaProperty, global::ElevenLabs.LLMObjectJsonSchemaPropertyInput, global::ElevenLabs.LLMArrayJsonSchemaPropertyInput, global::ElevenLabs.LLMAnyOfJsonSchemaPropertyInput> Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMArrayJsonSchemaPropertyInput" /> class.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="type">
        /// Default Value: array
        /// </param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LLMArrayJsonSchemaPropertyInput(
            global::ElevenLabs.OneOf<global::ElevenLabs.LLMLiteralJsonSchemaProperty, global::ElevenLabs.LLMObjectJsonSchemaPropertyInput, global::ElevenLabs.LLMArrayJsonSchemaPropertyInput, global::ElevenLabs.LLMAnyOfJsonSchemaPropertyInput> items,
            string? type,
            string? description)
        {
            this.Type = type;
            this.Description = description;
            this.Items = items;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMArrayJsonSchemaPropertyInput" /> class.
        /// </summary>
        public LLMArrayJsonSchemaPropertyInput()
        {
        }

    }
}