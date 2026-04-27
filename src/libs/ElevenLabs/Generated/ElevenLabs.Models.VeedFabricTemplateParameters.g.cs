
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VeedFabricTemplateParameters
    {
        /// <summary>
        /// Default Value: 720p
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.VeedFabricTemplateParametersResolutionJsonConverter))]
        public global::ElevenLabs.VeedFabricTemplateParametersResolution? Resolution { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public global::ElevenLabs.ReferenceImage? Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public global::ElevenLabs.ReferenceAudio? Audio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VeedFabricTemplateParameters" /> class.
        /// </summary>
        /// <param name="resolution">
        /// Default Value: 720p
        /// </param>
        /// <param name="image"></param>
        /// <param name="audio"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VeedFabricTemplateParameters(
            global::ElevenLabs.VeedFabricTemplateParametersResolution? resolution,
            global::ElevenLabs.ReferenceImage? image,
            global::ElevenLabs.ReferenceAudio? audio)
        {
            this.Resolution = resolution;
            this.Image = image;
            this.Audio = audio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VeedFabricTemplateParameters" /> class.
        /// </summary>
        public VeedFabricTemplateParameters()
        {
        }
    }
}