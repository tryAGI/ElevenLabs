
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BytedanceOmniHumanParameters
    {
        /// <summary>
        /// Default Value: 1080p
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.BytedanceOmniHumanParametersResolutionJsonConverter))]
        public global::ElevenLabs.BytedanceOmniHumanParametersResolution? Resolution { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.CroppedReferenceImage, global::ElevenLabs.ReferenceImage>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.AnyOf<global::ElevenLabs.CroppedReferenceImage, global::ElevenLabs.ReferenceImage> Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ReferenceAudio Audio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BytedanceOmniHumanParameters" /> class.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="audio"></param>
        /// <param name="resolution">
        /// Default Value: 1080p
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BytedanceOmniHumanParameters(
            global::ElevenLabs.AnyOf<global::ElevenLabs.CroppedReferenceImage, global::ElevenLabs.ReferenceImage> image,
            global::ElevenLabs.ReferenceAudio audio,
            global::ElevenLabs.BytedanceOmniHumanParametersResolution? resolution)
        {
            this.Resolution = resolution;
            this.Image = image;
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BytedanceOmniHumanParameters" /> class.
        /// </summary>
        public BytedanceOmniHumanParameters()
        {
        }

    }
}