
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunwayGen4ImageParameters
    {
        /// <summary>
        /// Default Value: 16:9
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.RunwayGen4ImageParametersAspectRatioJsonConverter))]
        public global::ElevenLabs.RunwayGen4ImageParametersAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Default Value: 720p
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.RunwayGen4ImageParametersResolutionJsonConverter))]
        public global::ElevenLabs.RunwayGen4ImageParametersResolution? Resolution { get; set; }

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
        /// Initializes a new instance of the <see cref="RunwayGen4ImageParameters" /> class.
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
        public RunwayGen4ImageParameters(
            global::ElevenLabs.RunwayGen4ImageParametersAspectRatio? aspectRatio,
            global::ElevenLabs.RunwayGen4ImageParametersResolution? resolution,
            global::System.Collections.Generic.IList<global::ElevenLabs.ReferenceImage>? referenceImages)
        {
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
            this.ReferenceImages = referenceImages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunwayGen4ImageParameters" /> class.
        /// </summary>
        public RunwayGen4ImageParameters()
        {
        }
    }
}