
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Gemini31FlashImageParameters
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReferenceImage>? Images { get; set; }

        /// <summary>
        /// Default Value: 16:9
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.Gemini31FlashImageParametersAspectRatioJsonConverter))]
        public global::ElevenLabs.Gemini31FlashImageParametersAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Default Value: 1K
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.Gemini31FlashImageParametersResolutionJsonConverter))]
        public global::ElevenLabs.Gemini31FlashImageParametersResolution? Resolution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Gemini31FlashImageParameters" /> class.
        /// </summary>
        /// <param name="images"></param>
        /// <param name="aspectRatio">
        /// Default Value: 16:9
        /// </param>
        /// <param name="resolution">
        /// Default Value: 1K
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Gemini31FlashImageParameters(
            global::System.Collections.Generic.IList<global::ElevenLabs.ReferenceImage>? images,
            global::ElevenLabs.Gemini31FlashImageParametersAspectRatio? aspectRatio,
            global::ElevenLabs.Gemini31FlashImageParametersResolution? resolution)
        {
            this.Images = images;
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Gemini31FlashImageParameters" /> class.
        /// </summary>
        public Gemini31FlashImageParameters()
        {
        }
    }
}