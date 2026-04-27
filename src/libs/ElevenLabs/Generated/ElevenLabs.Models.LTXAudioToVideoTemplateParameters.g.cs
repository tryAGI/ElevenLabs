
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LTXAudioToVideoTemplateParameters
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public global::ElevenLabs.ReferenceImage? Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        public global::ElevenLabs.LTXAudioToVideoTemplateParametersAspectRatio2? AspectRatio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        public global::ElevenLabs.LTXAudioToVideoTemplateParametersResolution2? Resolution { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_prompt")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ReferenceText, object>))]
        public global::ElevenLabs.AnyOf<string, global::ElevenLabs.ReferenceText, object>? NegativePrompt { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enhance_prompt")]
        public bool? EnhancePrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

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
        /// Initializes a new instance of the <see cref="LTXAudioToVideoTemplateParameters" /> class.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="aspectRatio"></param>
        /// <param name="resolution"></param>
        /// <param name="negativePrompt"></param>
        /// <param name="enhancePrompt">
        /// Default Value: false
        /// </param>
        /// <param name="seed"></param>
        /// <param name="audio"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LTXAudioToVideoTemplateParameters(
            global::ElevenLabs.ReferenceImage? image,
            global::ElevenLabs.LTXAudioToVideoTemplateParametersAspectRatio2? aspectRatio,
            global::ElevenLabs.LTXAudioToVideoTemplateParametersResolution2? resolution,
            global::ElevenLabs.AnyOf<string, global::ElevenLabs.ReferenceText, object>? negativePrompt,
            bool? enhancePrompt,
            int? seed,
            global::ElevenLabs.ReferenceAudio? audio)
        {
            this.Image = image;
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
            this.NegativePrompt = negativePrompt;
            this.EnhancePrompt = enhancePrompt;
            this.Seed = seed;
            this.Audio = audio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LTXAudioToVideoTemplateParameters" /> class.
        /// </summary>
        public LTXAudioToVideoTemplateParameters()
        {
        }
    }
}