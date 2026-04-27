
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BytedanceSeedream4Parameters
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.BytedanceSeedream4ParametersAspectRatioJsonConverter))]
        public global::ElevenLabs.BytedanceSeedream4ParametersAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Default Value: 1080p
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.BytedanceSeedream4ParametersResolutionJsonConverter))]
        public global::ElevenLabs.BytedanceSeedream4ParametersResolution? Resolution { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BytedanceSeedream4Parameters" /> class.
        /// </summary>
        /// <param name="images"></param>
        /// <param name="aspectRatio">
        /// Default Value: 16:9
        /// </param>
        /// <param name="resolution">
        /// Default Value: 1080p
        /// </param>
        /// <param name="seed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BytedanceSeedream4Parameters(
            global::System.Collections.Generic.IList<global::ElevenLabs.ReferenceImage>? images,
            global::ElevenLabs.BytedanceSeedream4ParametersAspectRatio? aspectRatio,
            global::ElevenLabs.BytedanceSeedream4ParametersResolution? resolution,
            int? seed)
        {
            this.Images = images;
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
            this.Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BytedanceSeedream4Parameters" /> class.
        /// </summary>
        public BytedanceSeedream4Parameters()
        {
        }
    }
}