
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TopazImageUpscaleTemplateParameters
    {
        /// <summary>
        /// Default Value: 2F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upscale_factor")]
        public double? UpscaleFactor { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crop_to_fill")]
        public bool? CropToFill { get; set; }

        /// <summary>
        /// Default Value: png
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ImageOutputFormatJsonConverter))]
        public global::ElevenLabs.ImageOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("face_enhancement")]
        public bool? FaceEnhancement { get; set; }

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
        /// Initializes a new instance of the <see cref="TopazImageUpscaleTemplateParameters" /> class.
        /// </summary>
        /// <param name="upscaleFactor">
        /// Default Value: 2F
        /// </param>
        /// <param name="cropToFill">
        /// Default Value: true
        /// </param>
        /// <param name="outputFormat">
        /// Default Value: png
        /// </param>
        /// <param name="faceEnhancement">
        /// Default Value: false
        /// </param>
        /// <param name="image"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TopazImageUpscaleTemplateParameters(
            double? upscaleFactor,
            bool? cropToFill,
            global::ElevenLabs.ImageOutputFormat? outputFormat,
            bool? faceEnhancement,
            global::ElevenLabs.ReferenceImage? image)
        {
            this.UpscaleFactor = upscaleFactor;
            this.CropToFill = cropToFill;
            this.OutputFormat = outputFormat;
            this.FaceEnhancement = faceEnhancement;
            this.Image = image;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopazImageUpscaleTemplateParameters" /> class.
        /// </summary>
        public TopazImageUpscaleTemplateParameters()
        {
        }
    }
}