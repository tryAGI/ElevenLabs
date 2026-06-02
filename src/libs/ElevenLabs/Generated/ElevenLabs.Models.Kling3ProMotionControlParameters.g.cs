
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Kling3ProMotionControlParameters
    {
        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keep_audio")]
        public bool? KeepAudio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_orientation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.Kling3ProMotionControlParametersCharacterOrientationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.Kling3ProMotionControlParametersCharacterOrientation CharacterOrientation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ReferenceImage Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ReferenceVideo Video { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Kling3ProMotionControlParameters" /> class.
        /// </summary>
        /// <param name="characterOrientation"></param>
        /// <param name="image"></param>
        /// <param name="video"></param>
        /// <param name="keepAudio">
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Kling3ProMotionControlParameters(
            global::ElevenLabs.Kling3ProMotionControlParametersCharacterOrientation characterOrientation,
            global::ElevenLabs.ReferenceImage image,
            global::ElevenLabs.ReferenceVideo video,
            bool? keepAudio)
        {
            this.KeepAudio = keepAudio;
            this.CharacterOrientation = characterOrientation;
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Video = video ?? throw new global::System.ArgumentNullException(nameof(video));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Kling3ProMotionControlParameters" /> class.
        /// </summary>
        public Kling3ProMotionControlParameters()
        {
        }

    }
}