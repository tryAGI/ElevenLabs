
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LTXAudioToVideoParameters
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
        public global::ElevenLabs.LTXAudioToVideoParametersAspectRatio2? AspectRatio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        public global::ElevenLabs.LTXAudioToVideoParametersResolution2? Resolution { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ReferenceAudio Audio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LTXAudioToVideoParameters" /> class.
        /// </summary>
        /// <param name="audio"></param>
        /// <param name="image"></param>
        /// <param name="aspectRatio"></param>
        /// <param name="resolution"></param>
        /// <param name="negativePrompt"></param>
        /// <param name="enhancePrompt">
        /// Default Value: false
        /// </param>
        /// <param name="seed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LTXAudioToVideoParameters(
            global::ElevenLabs.ReferenceAudio audio,
            global::ElevenLabs.ReferenceImage? image,
            global::ElevenLabs.LTXAudioToVideoParametersAspectRatio2? aspectRatio,
            global::ElevenLabs.LTXAudioToVideoParametersResolution2? resolution,
            global::ElevenLabs.AnyOf<string, global::ElevenLabs.ReferenceText, object>? negativePrompt,
            bool? enhancePrompt,
            int? seed)
        {
            this.Image = image;
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
            this.NegativePrompt = negativePrompt;
            this.EnhancePrompt = enhancePrompt;
            this.Seed = seed;
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LTXAudioToVideoParameters" /> class.
        /// </summary>
        public LTXAudioToVideoParameters()
        {
        }

    }
}