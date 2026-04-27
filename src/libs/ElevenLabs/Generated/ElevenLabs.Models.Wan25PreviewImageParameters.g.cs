
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Wan25PreviewImageParameters
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReferenceImage>? Images { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_prompt")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ReferenceText, object>))]
        public global::ElevenLabs.AnyOf<string, global::ElevenLabs.ReferenceText, object>? NegativePrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Default Value: 1:1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.Wan25PreviewImageParametersAspectRatioJsonConverter))]
        public global::ElevenLabs.Wan25PreviewImageParametersAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enhance_prompt")]
        public bool? EnhancePrompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Wan25PreviewImageParameters" /> class.
        /// </summary>
        /// <param name="images"></param>
        /// <param name="negativePrompt"></param>
        /// <param name="seed"></param>
        /// <param name="aspectRatio">
        /// Default Value: 1:1
        /// </param>
        /// <param name="enhancePrompt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Wan25PreviewImageParameters(
            global::System.Collections.Generic.IList<global::ElevenLabs.ReferenceImage>? images,
            global::ElevenLabs.AnyOf<string, global::ElevenLabs.ReferenceText, object>? negativePrompt,
            int? seed,
            global::ElevenLabs.Wan25PreviewImageParametersAspectRatio? aspectRatio,
            bool? enhancePrompt)
        {
            this.Images = images;
            this.NegativePrompt = negativePrompt;
            this.Seed = seed;
            this.AspectRatio = aspectRatio;
            this.EnhancePrompt = enhancePrompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Wan25PreviewImageParameters" /> class.
        /// </summary>
        public Wan25PreviewImageParameters()
        {
        }
    }
}