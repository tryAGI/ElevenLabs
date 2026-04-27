
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KlingOmniImageParameters
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.ReferenceImage> Images { get; set; }

        /// <summary>
        /// Default Value: 1K
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.KlingOmniImageParametersResolutionJsonConverter))]
        public global::ElevenLabs.KlingOmniImageParametersResolution? Resolution { get; set; }

        /// <summary>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.KlingOmniImageParametersAspectRatioJsonConverter))]
        public global::ElevenLabs.KlingOmniImageParametersAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Default Value: png
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.KlingOmniImageParametersOutputFormatJsonConverter))]
        public global::ElevenLabs.KlingOmniImageParametersOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KlingOmniImageParameters" /> class.
        /// </summary>
        /// <param name="images"></param>
        /// <param name="resolution">
        /// Default Value: 1K
        /// </param>
        /// <param name="aspectRatio">
        /// Default Value: auto
        /// </param>
        /// <param name="outputFormat">
        /// Default Value: png
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KlingOmniImageParameters(
            global::System.Collections.Generic.IList<global::ElevenLabs.ReferenceImage> images,
            global::ElevenLabs.KlingOmniImageParametersResolution? resolution,
            global::ElevenLabs.KlingOmniImageParametersAspectRatio? aspectRatio,
            global::ElevenLabs.KlingOmniImageParametersOutputFormat? outputFormat)
        {
            this.Images = images ?? throw new global::System.ArgumentNullException(nameof(images));
            this.Resolution = resolution;
            this.AspectRatio = aspectRatio;
            this.OutputFormat = outputFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KlingOmniImageParameters" /> class.
        /// </summary>
        public KlingOmniImageParameters()
        {
        }
    }
}