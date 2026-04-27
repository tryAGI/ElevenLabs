
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Wan26Parameters
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_frame")]
        public global::ElevenLabs.ReferenceImage? StartFrame { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_videos")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReferenceVideo>? ReferenceVideos { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public global::ElevenLabs.ReferenceAudio? Audio { get; set; }

        /// <summary>
        /// Default Value: 720p
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.Wan26ParametersResolutionJsonConverter))]
        public global::ElevenLabs.Wan26ParametersResolution? Resolution { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        public global::ElevenLabs.Wan26ParametersAspectRatio2? AspectRatio { get; set; }

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
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multi_shots")]
        public bool? MultiShots { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Wan26Parameters" /> class.
        /// </summary>
        /// <param name="startFrame"></param>
        /// <param name="referenceVideos"></param>
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
        /// <param name="multiShots">
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Wan26Parameters(
            global::ElevenLabs.ReferenceImage? startFrame,
            global::System.Collections.Generic.IList<global::ElevenLabs.ReferenceVideo>? referenceVideos,
            global::ElevenLabs.ReferenceAudio? audio,
            global::ElevenLabs.Wan26ParametersResolution? resolution,
            global::ElevenLabs.Wan26ParametersAspectRatio2? aspectRatio,
            int? durationSecs,
            global::ElevenLabs.AnyOf<string, global::ElevenLabs.ReferenceText, object>? negativePrompt,
            int? seed,
            bool? enhancePrompt,
            bool? multiShots)
        {
            this.StartFrame = startFrame;
            this.ReferenceVideos = referenceVideos;
            this.Audio = audio;
            this.Resolution = resolution;
            this.AspectRatio = aspectRatio;
            this.DurationSecs = durationSecs;
            this.NegativePrompt = negativePrompt;
            this.Seed = seed;
            this.EnhancePrompt = enhancePrompt;
            this.MultiShots = multiShots;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Wan26Parameters" /> class.
        /// </summary>
        public Wan26Parameters()
        {
        }
    }
}