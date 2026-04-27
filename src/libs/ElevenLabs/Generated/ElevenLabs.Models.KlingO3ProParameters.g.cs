
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KlingO3ProParameters
    {
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
        [global::System.Text.Json.Serialization.JsonPropertyName("video")]
        public global::ElevenLabs.ReferenceVideo? Video { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generate_audio")]
        public bool? GenerateAudio { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_images")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReferenceImage>? ReferenceImages { get; set; }

        /// <summary>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_secs")]
        public int? DurationSecs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        public global::ElevenLabs.KlingO3ProParametersAspectRatio2? AspectRatio { get; set; }

        /// <summary>
        /// Default Value: 1080p
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.KlingO3ProParametersResolutionJsonConverter))]
        public global::ElevenLabs.KlingO3ProParametersResolution? Resolution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KlingO3ProParameters" /> class.
        /// </summary>
        /// <param name="startFrame"></param>
        /// <param name="endFrame"></param>
        /// <param name="video"></param>
        /// <param name="generateAudio">
        /// Default Value: false
        /// </param>
        /// <param name="referenceImages">
        /// Default Value: []
        /// </param>
        /// <param name="durationSecs">
        /// Default Value: 5
        /// </param>
        /// <param name="aspectRatio"></param>
        /// <param name="resolution">
        /// Default Value: 1080p
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KlingO3ProParameters(
            global::ElevenLabs.ReferenceImage? startFrame,
            global::ElevenLabs.ReferenceImage? endFrame,
            global::ElevenLabs.ReferenceVideo? video,
            bool? generateAudio,
            global::System.Collections.Generic.IList<global::ElevenLabs.ReferenceImage>? referenceImages,
            int? durationSecs,
            global::ElevenLabs.KlingO3ProParametersAspectRatio2? aspectRatio,
            global::ElevenLabs.KlingO3ProParametersResolution? resolution)
        {
            this.StartFrame = startFrame;
            this.EndFrame = endFrame;
            this.Video = video;
            this.GenerateAudio = generateAudio;
            this.ReferenceImages = referenceImages;
            this.DurationSecs = durationSecs;
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KlingO3ProParameters" /> class.
        /// </summary>
        public KlingO3ProParameters()
        {
        }
    }
}