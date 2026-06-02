
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunwayGen4ImageTurboParameters
    {
        /// <summary>
        /// Default Value: 16:9
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.RunwayGen4ImageTurboParametersAspectRatioJsonConverter))]
        public global::ElevenLabs.RunwayGen4ImageTurboParametersAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Default Value: 720p
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.RunwayGen4ImageTurboParametersResolutionJsonConverter))]
        public global::ElevenLabs.RunwayGen4ImageTurboParametersResolution? Resolution { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_images")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.ReferenceImage> ReferenceImages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunwayGen4ImageTurboParameters" /> class.
        /// </summary>
        /// <param name="referenceImages"></param>
        /// <param name="aspectRatio">
        /// Default Value: 16:9
        /// </param>
        /// <param name="resolution">
        /// Default Value: 720p
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunwayGen4ImageTurboParameters(
            global::System.Collections.Generic.IList<global::ElevenLabs.ReferenceImage> referenceImages,
            global::ElevenLabs.RunwayGen4ImageTurboParametersAspectRatio? aspectRatio,
            global::ElevenLabs.RunwayGen4ImageTurboParametersResolution? resolution)
        {
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
            this.ReferenceImages = referenceImages ?? throw new global::System.ArgumentNullException(nameof(referenceImages));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunwayGen4ImageTurboParameters" /> class.
        /// </summary>
        public RunwayGen4ImageTurboParameters()
        {
        }

    }
}