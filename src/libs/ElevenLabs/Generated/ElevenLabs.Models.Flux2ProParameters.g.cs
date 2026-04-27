
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Flux2ProParameters
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.Flux2ProParametersAspectRatioJsonConverter))]
        public global::ElevenLabs.Flux2ProParametersAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Default Value: 1080p
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.Flux2ProParametersResolutionJsonConverter))]
        public global::ElevenLabs.Flux2ProParametersResolution? Resolution { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enhance_prompt")]
        public bool? EnhancePrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Default Value: png
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.Flux2ProParametersOutputFormatJsonConverter))]
        public global::ElevenLabs.Flux2ProParametersOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Flux2ProParameters" /> class.
        /// </summary>
        /// <param name="images"></param>
        /// <param name="aspectRatio">
        /// Default Value: 16:9
        /// </param>
        /// <param name="resolution">
        /// Default Value: 1080p
        /// </param>
        /// <param name="enhancePrompt">
        /// Default Value: false
        /// </param>
        /// <param name="seed"></param>
        /// <param name="outputFormat">
        /// Default Value: png
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Flux2ProParameters(
            global::System.Collections.Generic.IList<global::ElevenLabs.ReferenceImage>? images,
            global::ElevenLabs.Flux2ProParametersAspectRatio? aspectRatio,
            global::ElevenLabs.Flux2ProParametersResolution? resolution,
            bool? enhancePrompt,
            int? seed,
            global::ElevenLabs.Flux2ProParametersOutputFormat? outputFormat)
        {
            this.Images = images;
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
            this.EnhancePrompt = enhancePrompt;
            this.Seed = seed;
            this.OutputFormat = outputFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Flux2ProParameters" /> class.
        /// </summary>
        public Flux2ProParameters()
        {
        }
    }
}