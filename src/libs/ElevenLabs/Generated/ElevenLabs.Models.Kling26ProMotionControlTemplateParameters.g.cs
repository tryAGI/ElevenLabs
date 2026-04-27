
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Kling26ProMotionControlTemplateParameters
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.Kling26ProMotionControlTemplateParametersCharacterOrientationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.Kling26ProMotionControlTemplateParametersCharacterOrientation CharacterOrientation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public global::ElevenLabs.ReferenceImage? Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video")]
        public global::ElevenLabs.ReferenceVideo? Video { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Kling26ProMotionControlTemplateParameters" /> class.
        /// </summary>
        /// <param name="characterOrientation"></param>
        /// <param name="keepAudio">
        /// Default Value: true
        /// </param>
        /// <param name="image"></param>
        /// <param name="video"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Kling26ProMotionControlTemplateParameters(
            global::ElevenLabs.Kling26ProMotionControlTemplateParametersCharacterOrientation characterOrientation,
            bool? keepAudio,
            global::ElevenLabs.ReferenceImage? image,
            global::ElevenLabs.ReferenceVideo? video)
        {
            this.KeepAudio = keepAudio;
            this.CharacterOrientation = characterOrientation;
            this.Image = image;
            this.Video = video;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Kling26ProMotionControlTemplateParameters" /> class.
        /// </summary>
        public Kling26ProMotionControlTemplateParameters()
        {
        }
    }
}