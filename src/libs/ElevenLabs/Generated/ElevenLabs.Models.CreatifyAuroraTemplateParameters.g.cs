
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatifyAuroraTemplateParameters
    {
        /// <summary>
        /// Default Value: 720p
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.CreatifyAuroraTemplateParametersResolutionJsonConverter))]
        public global::ElevenLabs.CreatifyAuroraTemplateParametersResolution? Resolution { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guidance_scale")]
        public double? GuidanceScale { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_guidance_scale")]
        public double? AudioGuidanceScale { get; set; }

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
        /// Initializes a new instance of the <see cref="CreatifyAuroraTemplateParameters" /> class.
        /// </summary>
        /// <param name="resolution">
        /// Default Value: 720p
        /// </param>
        /// <param name="guidanceScale"></param>
        /// <param name="audioGuidanceScale"></param>
        /// <param name="image"></param>
        /// <param name="audio"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatifyAuroraTemplateParameters(
            global::ElevenLabs.CreatifyAuroraTemplateParametersResolution? resolution,
            double? guidanceScale,
            double? audioGuidanceScale,
            global::ElevenLabs.ReferenceImage? image,
            global::ElevenLabs.ReferenceAudio? audio)
        {
            this.Resolution = resolution;
            this.GuidanceScale = guidanceScale;
            this.AudioGuidanceScale = audioGuidanceScale;
            this.Image = image;
            this.Audio = audio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatifyAuroraTemplateParameters" /> class.
        /// </summary>
        public CreatifyAuroraTemplateParameters()
        {
        }
    }
}