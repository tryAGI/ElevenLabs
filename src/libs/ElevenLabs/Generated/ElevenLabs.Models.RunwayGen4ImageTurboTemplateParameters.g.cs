
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunwayGen4ImageTurboTemplateParameters
    {
        /// <summary>
        /// Default Value: 16:9
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.RunwayGen4ImageTurboTemplateParametersAspectRatioJsonConverter))]
        public global::ElevenLabs.RunwayGen4ImageTurboTemplateParametersAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Default Value: 720p
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.RunwayGen4ImageTurboTemplateParametersResolutionJsonConverter))]
        public global::ElevenLabs.RunwayGen4ImageTurboTemplateParametersResolution? Resolution { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_images")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReferenceImage>? ReferenceImages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunwayGen4ImageTurboTemplateParameters" /> class.
        /// </summary>
        /// <param name="aspectRatio">
        /// Default Value: 16:9
        /// </param>
        /// <param name="resolution">
        /// Default Value: 720p
        /// </param>
        /// <param name="referenceImages"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunwayGen4ImageTurboTemplateParameters(
            global::ElevenLabs.RunwayGen4ImageTurboTemplateParametersAspectRatio? aspectRatio,
            global::ElevenLabs.RunwayGen4ImageTurboTemplateParametersResolution? resolution,
            global::System.Collections.Generic.IList<global::ElevenLabs.ReferenceImage>? referenceImages)
        {
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
            this.ReferenceImages = referenceImages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunwayGen4ImageTurboTemplateParameters" /> class.
        /// </summary>
        public RunwayGen4ImageTurboTemplateParameters()
        {
        }
    }
}