
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Wan25PreviewVideoParameters
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_frame")]
        public global::ElevenLabs.ReferenceImage? StartFrame { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public global::ElevenLabs.ReferenceAudio? Audio { get; set; }

        /// <summary>
        /// Default Value: 720p
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.Wan25PreviewVideoParametersResolutionJsonConverter))]
        public global::ElevenLabs.Wan25PreviewVideoParametersResolution? Resolution { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        public global::ElevenLabs.Wan25PreviewVideoParametersAspectRatio2? AspectRatio { get; set; }

        /// <summary>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_secs")]
        public int? DurationSecs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_prompt")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ReferenceText, object>))]
        public global::ElevenLabs.AnyOf<string, global::ElevenLabs.ReferenceText, object>? NegativePrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enhance_prompt")]
        public bool? EnhancePrompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Wan25PreviewVideoParameters" /> class.
        /// </summary>
        /// <param name="startFrame"></param>
        /// <param name="audio"></param>
        /// <param name="resolution">
        /// Default Value: 720p
        /// </param>
        /// <param name="aspectRatio"></param>
        /// <param name="durationSecs">
        /// Default Value: 5
        /// </param>
        /// <param name="negativePrompt"></param>
        /// <param name="seed"></param>
        /// <param name="enhancePrompt">
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Wan25PreviewVideoParameters(
            global::ElevenLabs.ReferenceImage? startFrame,
            global::ElevenLabs.ReferenceAudio? audio,
            global::ElevenLabs.Wan25PreviewVideoParametersResolution? resolution,
            global::ElevenLabs.Wan25PreviewVideoParametersAspectRatio2? aspectRatio,
            int? durationSecs,
            global::ElevenLabs.AnyOf<string, global::ElevenLabs.ReferenceText, object>? negativePrompt,
            int? seed,
            bool? enhancePrompt)
        {
            this.StartFrame = startFrame;
            this.Audio = audio;
            this.Resolution = resolution;
            this.AspectRatio = aspectRatio;
            this.DurationSecs = durationSecs;
            this.NegativePrompt = negativePrompt;
            this.Seed = seed;
            this.EnhancePrompt = enhancePrompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Wan25PreviewVideoParameters" /> class.
        /// </summary>
        public Wan25PreviewVideoParameters()
        {
        }
    }
}