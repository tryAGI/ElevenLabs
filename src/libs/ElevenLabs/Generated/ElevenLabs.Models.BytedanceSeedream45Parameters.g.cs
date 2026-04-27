
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BytedanceSeedream45Parameters
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.BytedanceSeedream45ParametersAspectRatioJsonConverter))]
        public global::ElevenLabs.BytedanceSeedream45ParametersAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Default Value: 2K
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.BytedanceSeedream45ParametersResolutionJsonConverter))]
        public global::ElevenLabs.BytedanceSeedream45ParametersResolution? Resolution { get; set; }

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
        /// Initializes a new instance of the <see cref="BytedanceSeedream45Parameters" /> class.
        /// </summary>
        /// <param name="images"></param>
        /// <param name="aspectRatio">
        /// Default Value: 16:9
        /// </param>
        /// <param name="resolution">
        /// Default Value: 2K
        /// </param>
        /// <param name="seed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BytedanceSeedream45Parameters(
            global::System.Collections.Generic.IList<global::ElevenLabs.ReferenceImage>? images,
            global::ElevenLabs.BytedanceSeedream45ParametersAspectRatio? aspectRatio,
            global::ElevenLabs.BytedanceSeedream45ParametersResolution? resolution,
            int? seed)
        {
            this.Images = images;
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
            this.Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BytedanceSeedream45Parameters" /> class.
        /// </summary>
        public BytedanceSeedream45Parameters()
        {
        }
    }
}