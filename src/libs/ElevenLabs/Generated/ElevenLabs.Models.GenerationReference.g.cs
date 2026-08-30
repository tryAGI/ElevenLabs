
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The output of a prior generation on this API.
    /// </summary>
    public sealed partial class GenerationReference
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"generation"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "generation";

        /// <summary>
        /// The ID of the generation whose output to use, as returned when the generation was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GenerationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationReference" /> class.
        /// </summary>
        /// <param name="generationId">
        /// The ID of the generation whose output to use, as returned when the generation was created.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationReference(
            string generationId,
            string type = "generation")
        {
            this.Type = type;
            this.GenerationId = generationId ?? throw new global::System.ArgumentNullException(nameof(generationId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationReference" /> class.
        /// </summary>
        public GenerationReference()
        {
        }

        /// <summary>
        /// Creates a new <see cref="GenerationReference"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static GenerationReference FromGenerationId(string generationId)
        {
            return new GenerationReference
            {
                GenerationId = generationId,
            };
        }

    }
}