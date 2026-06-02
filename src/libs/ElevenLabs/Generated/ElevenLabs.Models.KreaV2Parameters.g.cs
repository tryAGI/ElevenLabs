
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KreaV2Parameters
    {
        /// <summary>
        /// Default Value: 16:9
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.KreaV2ParametersAspectRatioJsonConverter))]
        public global::ElevenLabs.KreaV2ParametersAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Default Value: medium
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creativity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.KreaV2ParametersCreativityJsonConverter))]
        public global::ElevenLabs.KreaV2ParametersCreativity? Creativity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReferenceImage>? Images { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KreaV2Parameters" /> class.
        /// </summary>
        /// <param name="aspectRatio">
        /// Default Value: 16:9
        /// </param>
        /// <param name="creativity">
        /// Default Value: medium
        /// </param>
        /// <param name="seed"></param>
        /// <param name="images"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KreaV2Parameters(
            global::ElevenLabs.KreaV2ParametersAspectRatio? aspectRatio,
            global::ElevenLabs.KreaV2ParametersCreativity? creativity,
            int? seed,
            global::System.Collections.Generic.IList<global::ElevenLabs.ReferenceImage>? images)
        {
            this.AspectRatio = aspectRatio;
            this.Creativity = creativity;
            this.Seed = seed;
            this.Images = images;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KreaV2Parameters" /> class.
        /// </summary>
        public KreaV2Parameters()
        {
        }

    }
}