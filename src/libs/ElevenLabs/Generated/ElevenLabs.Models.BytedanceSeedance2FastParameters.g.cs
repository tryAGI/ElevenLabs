
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BytedanceSeedance2FastParameters
    {
        /// <summary>
        /// Default Value: 16:9
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        public global::ElevenLabs.BytedanceSeedance2FastParametersAspectRatio2? AspectRatio { get; set; }

        /// <summary>
        /// Default Value: 720p
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.BytedanceSeedance2FastParametersResolutionJsonConverter))]
        public global::ElevenLabs.BytedanceSeedance2FastParametersResolution? Resolution { get; set; }

        /// <summary>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_secs")]
        public int? DurationSecs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generate_audio")]
        public bool? GenerateAudio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_frame")]
        public global::ElevenLabs.ReferenceImage? StartFrame { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_frame")]
        public global::ElevenLabs.ReferenceImage? EndFrame { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_images")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReferenceImage>? ReferenceImages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_videos")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReferenceVideo>? ReferenceVideos { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_audios")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReferenceAudio>? ReferenceAudios { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BytedanceSeedance2FastParameters" /> class.
        /// </summary>
        /// <param name="aspectRatio">
        /// Default Value: 16:9
        /// </param>
        /// <param name="resolution">
        /// Default Value: 720p
        /// </param>
        /// <param name="durationSecs">
        /// Default Value: 5
        /// </param>
        /// <param name="seed"></param>
        /// <param name="generateAudio">
        /// Default Value: true
        /// </param>
        /// <param name="startFrame"></param>
        /// <param name="endFrame"></param>
        /// <param name="referenceImages"></param>
        /// <param name="referenceVideos"></param>
        /// <param name="referenceAudios"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BytedanceSeedance2FastParameters(
            global::ElevenLabs.BytedanceSeedance2FastParametersAspectRatio2? aspectRatio,
            global::ElevenLabs.BytedanceSeedance2FastParametersResolution? resolution,
            int? durationSecs,
            int? seed,
            bool? generateAudio,
            global::ElevenLabs.ReferenceImage? startFrame,
            global::ElevenLabs.ReferenceImage? endFrame,
            global::System.Collections.Generic.IList<global::ElevenLabs.ReferenceImage>? referenceImages,
            global::System.Collections.Generic.IList<global::ElevenLabs.ReferenceVideo>? referenceVideos,
            global::System.Collections.Generic.IList<global::ElevenLabs.ReferenceAudio>? referenceAudios)
        {
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
            this.DurationSecs = durationSecs;
            this.Seed = seed;
            this.GenerateAudio = generateAudio;
            this.StartFrame = startFrame;
            this.EndFrame = endFrame;
            this.ReferenceImages = referenceImages;
            this.ReferenceVideos = referenceVideos;
            this.ReferenceAudios = referenceAudios;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BytedanceSeedance2FastParameters" /> class.
        /// </summary>
        public BytedanceSeedance2FastParameters()
        {
        }
    }
}