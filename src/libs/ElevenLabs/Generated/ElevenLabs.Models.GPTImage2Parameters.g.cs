
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// GPT Image 2 accepts a `size` parameter (WxH) instead of separate quality/aspect_ratio.<br/>
    /// We expose aspect_ratio + resolution in the UI and compute the size at generation time.<br/>
    /// Size constraints from OpenAI:<br/>
    /// - Max edge &lt;= 3840px, both edges multiples of 16, ratio &lt;= 3:1<br/>
    /// - Total pixels between 655,360 and 8,294,400
    /// </summary>
    public sealed partial class GPTImage2Parameters
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReferenceImage>? Images { get; set; }

        /// <summary>
        /// Default Value: medium
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.GPTImage2ParametersQualityJsonConverter))]
        public global::ElevenLabs.GPTImage2ParametersQuality? Quality { get; set; }

        /// <summary>
        /// Default Value: 16:9
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.GPTImage2ParametersAspectRatioJsonConverter))]
        public global::ElevenLabs.GPTImage2ParametersAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Default Value: 1K
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.GPTImage2ParametersResolutionJsonConverter))]
        public global::ElevenLabs.GPTImage2ParametersResolution? Resolution { get; set; }

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
        /// Initializes a new instance of the <see cref="GPTImage2Parameters" /> class.
        /// </summary>
        /// <param name="images"></param>
        /// <param name="quality">
        /// Default Value: medium
        /// </param>
        /// <param name="aspectRatio">
        /// Default Value: 16:9
        /// </param>
        /// <param name="resolution">
        /// Default Value: 1K
        /// </param>
        /// <param name="mask"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GPTImage2Parameters(
            global::System.Collections.Generic.IList<global::ElevenLabs.ReferenceImage>? images,
            global::ElevenLabs.GPTImage2ParametersQuality? quality,
            global::ElevenLabs.GPTImage2ParametersAspectRatio? aspectRatio,
            global::ElevenLabs.GPTImage2ParametersResolution? resolution,
            global::ElevenLabs.ReferenceImage? mask)
        {
            this.Images = images;
            this.Quality = quality;
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
            this.Mask = mask;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GPTImage2Parameters" /> class.
        /// </summary>
        public GPTImage2Parameters()
        {
        }
    }
}