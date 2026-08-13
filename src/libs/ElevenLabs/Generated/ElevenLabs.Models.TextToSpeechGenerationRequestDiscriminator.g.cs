
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextToSpeechGenerationRequestDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TextToSpeechGenerationRequestDiscriminatorModelIdJsonConverter))]
        public global::ElevenLabs.TextToSpeechGenerationRequestDiscriminatorModelId? ModelId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToSpeechGenerationRequestDiscriminator" /> class.
        /// </summary>
        /// <param name="modelId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextToSpeechGenerationRequestDiscriminator(
            global::ElevenLabs.TextToSpeechGenerationRequestDiscriminatorModelId? modelId)
        {
            this.ModelId = modelId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToSpeechGenerationRequestDiscriminator" /> class.
        /// </summary>
        public TextToSpeechGenerationRequestDiscriminator()
        {
        }

    }
}