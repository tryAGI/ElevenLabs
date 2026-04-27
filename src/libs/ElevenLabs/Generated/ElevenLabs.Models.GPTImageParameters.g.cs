
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GPTImageParameters
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReferenceImage>? Images { get; set; }

        /// <summary>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.GPTImageParametersBackgroundJsonConverter))]
        public global::ElevenLabs.GPTImageParametersBackground? Background { get; set; }

        /// <summary>
        /// Default Value: medium
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.GPTImageParametersQualityJsonConverter))]
        public global::ElevenLabs.GPTImageParametersQuality? Quality { get; set; }

        /// <summary>
        /// Default Value: 1:1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.GPTImageParametersAspectRatioJsonConverter))]
        public global::ElevenLabs.GPTImageParametersAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask")]
        public global::ElevenLabs.ReferenceImage? Mask { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GPTImageParameters" /> class.
        /// </summary>
        /// <param name="images"></param>
        /// <param name="background">
        /// Default Value: auto
        /// </param>
        /// <param name="quality">
        /// Default Value: medium
        /// </param>
        /// <param name="aspectRatio">
        /// Default Value: 1:1
        /// </param>
        /// <param name="mask"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GPTImageParameters(
            global::System.Collections.Generic.IList<global::ElevenLabs.ReferenceImage>? images,
            global::ElevenLabs.GPTImageParametersBackground? background,
            global::ElevenLabs.GPTImageParametersQuality? quality,
            global::ElevenLabs.GPTImageParametersAspectRatio? aspectRatio,
            global::ElevenLabs.ReferenceImage? mask)
        {
            this.Images = images;
            this.Background = background;
            this.Quality = quality;
            this.AspectRatio = aspectRatio;
            this.Mask = mask;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GPTImageParameters" /> class.
        /// </summary>
        public GPTImageParameters()
        {
        }
    }
}