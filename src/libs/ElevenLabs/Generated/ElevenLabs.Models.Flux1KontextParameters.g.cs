
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Flux1KontextParameters
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Default Value: 0.5F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cfg_scale")]
        public double? CfgScale { get; set; }

        /// <summary>
        /// Default Value: png
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ImageOutputFormatJsonConverter))]
        public global::ElevenLabs.ImageOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enhance_prompt")]
        public bool? EnhancePrompt { get; set; }

        /// <summary>
        /// Default Value: 16:9
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.Flux1KontextParametersAspectRatioJsonConverter))]
        public global::ElevenLabs.Flux1KontextParametersAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public global::ElevenLabs.ReferenceImage? Image { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Flux1KontextParameters" /> class.
        /// </summary>
        /// <param name="seed"></param>
        /// <param name="cfgScale">
        /// Default Value: 0.5F
        /// </param>
        /// <param name="outputFormat">
        /// Default Value: png
        /// </param>
        /// <param name="enhancePrompt">
        /// Default Value: true
        /// </param>
        /// <param name="aspectRatio">
        /// Default Value: 16:9
        /// </param>
        /// <param name="image"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Flux1KontextParameters(
            int? seed,
            double? cfgScale,
            global::ElevenLabs.ImageOutputFormat? outputFormat,
            bool? enhancePrompt,
            global::ElevenLabs.Flux1KontextParametersAspectRatio? aspectRatio,
            global::ElevenLabs.ReferenceImage? image)
        {
            this.Seed = seed;
            this.CfgScale = cfgScale;
            this.OutputFormat = outputFormat;
            this.EnhancePrompt = enhancePrompt;
            this.AspectRatio = aspectRatio;
            this.Image = image;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Flux1KontextParameters" /> class.
        /// </summary>
        public Flux1KontextParameters()
        {
        }
    }
}