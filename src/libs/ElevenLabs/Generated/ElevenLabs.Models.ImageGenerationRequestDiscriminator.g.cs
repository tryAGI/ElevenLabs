
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ImageGenerationRequestDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ImageGenerationRequestDiscriminatorModelIdJsonConverter))]
        public global::ElevenLabs.ImageGenerationRequestDiscriminatorModelId? ModelId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationRequestDiscriminator" /> class.
        /// </summary>
        /// <param name="modelId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageGenerationRequestDiscriminator(
            global::ElevenLabs.ImageGenerationRequestDiscriminatorModelId? modelId)
        {
            this.ModelId = modelId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationRequestDiscriminator" /> class.
        /// </summary>
        public ImageGenerationRequestDiscriminator()
        {
        }

    }
}