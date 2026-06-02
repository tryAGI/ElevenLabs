
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HeygenAvatar4Parameters
    {
        /// <summary>
        /// Default Value: stable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("talking_style")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.HeygenAvatar4ParametersTalkingStyleJsonConverter))]
        public global::ElevenLabs.HeygenAvatar4ParametersTalkingStyle? TalkingStyle { get; set; }

        /// <summary>
        /// Default Value: 1080p
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        public string? Resolution { get; set; }

        /// <summary>
        /// Default Value: 16:9
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.HeygenAvatar4ParametersAspectRatioJsonConverter))]
        public global::ElevenLabs.HeygenAvatar4ParametersAspectRatio? AspectRatio { get; set; }

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
        /// Initializes a new instance of the <see cref="HeygenAvatar4Parameters" /> class.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="audio"></param>
        /// <param name="talkingStyle">
        /// Default Value: stable
        /// </param>
        /// <param name="resolution">
        /// Default Value: 1080p
        /// </param>
        /// <param name="aspectRatio">
        /// Default Value: 16:9
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HeygenAvatar4Parameters(
            global::ElevenLabs.AnyOf<global::ElevenLabs.CroppedReferenceImage, global::ElevenLabs.ReferenceImage> image,
            global::ElevenLabs.ReferenceAudio audio,
            global::ElevenLabs.HeygenAvatar4ParametersTalkingStyle? talkingStyle,
            string? resolution,
            global::ElevenLabs.HeygenAvatar4ParametersAspectRatio? aspectRatio)
        {
            this.TalkingStyle = talkingStyle;
            this.Resolution = resolution;
            this.AspectRatio = aspectRatio;
            this.Image = image;
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeygenAvatar4Parameters" /> class.
        /// </summary>
        public HeygenAvatar4Parameters()
        {
        }

    }
}