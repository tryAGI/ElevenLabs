
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BytedanceOmniHumanTemplateParameters
    {
        /// <summary>
        /// Default Value: 1080p
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.BytedanceOmniHumanTemplateParametersResolutionJsonConverter))]
        public global::ElevenLabs.BytedanceOmniHumanTemplateParametersResolution? Resolution { get; set; }

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
        /// Initializes a new instance of the <see cref="BytedanceOmniHumanTemplateParameters" /> class.
        /// </summary>
        /// <param name="resolution">
        /// Default Value: 1080p
        /// </param>
        /// <param name="image"></param>
        /// <param name="audio"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BytedanceOmniHumanTemplateParameters(
            global::ElevenLabs.BytedanceOmniHumanTemplateParametersResolution? resolution,
            global::ElevenLabs.ReferenceImage? image,
            global::ElevenLabs.ReferenceAudio? audio)
        {
            this.Resolution = resolution;
            this.Image = image;
            this.Audio = audio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BytedanceOmniHumanTemplateParameters" /> class.
        /// </summary>
        public BytedanceOmniHumanTemplateParameters()
        {
        }
    }
}