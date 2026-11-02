
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LLMAnyOfJsonSchemaPropertyInput
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("any_of")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.LLMObjectJsonSchemaPropertyInput> AnyOf { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMAnyOfJsonSchemaPropertyInput" /> class.
        /// </summary>
        /// <param name="anyOf"></param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LLMAnyOfJsonSchemaPropertyInput(
            global::System.Collections.Generic.IList<global::ElevenLabs.LLMObjectJsonSchemaPropertyInput> anyOf,
            string? description)
        {
            this.AnyOf = anyOf ?? throw new global::System.ArgumentNullException(nameof(anyOf));
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMAnyOfJsonSchemaPropertyInput" /> class.
        /// </summary>
        public LLMAnyOfJsonSchemaPropertyInput()
        {
        }

    }
}