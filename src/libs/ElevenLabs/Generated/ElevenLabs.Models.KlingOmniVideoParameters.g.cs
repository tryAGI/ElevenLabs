
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KlingOmniVideoParameters
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
        /// Default Value: 16:9
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        public global::ElevenLabs.KlingOmniVideoParametersAspectRatio2? AspectRatio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video")]
        public global::ElevenLabs.ReferenceVideo? Video { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keep_audio")]
        public bool? KeepAudio { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_images")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReferenceImage>? ReferenceImages { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elements")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.VideoElement>? Elements { get; set; }

        /// <summary>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_secs")]
        public int? DurationSecs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KlingOmniVideoParameters" /> class.
        /// </summary>
        /// <param name="startFrame"></param>
        /// <param name="endFrame"></param>
        /// <param name="aspectRatio">
        /// Default Value: 16:9
        /// </param>
        /// <param name="video"></param>
        /// <param name="keepAudio">
        /// Default Value: true
        /// </param>
        /// <param name="referenceImages">
        /// Default Value: []
        /// </param>
        /// <param name="elements">
        /// Default Value: []
        /// </param>
        /// <param name="durationSecs">
        /// Default Value: 5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KlingOmniVideoParameters(
            global::ElevenLabs.ReferenceImage? startFrame,
            global::ElevenLabs.ReferenceImage? endFrame,
            global::ElevenLabs.KlingOmniVideoParametersAspectRatio2? aspectRatio,
            global::ElevenLabs.ReferenceVideo? video,
            bool? keepAudio,
            global::System.Collections.Generic.IList<global::ElevenLabs.ReferenceImage>? referenceImages,
            global::System.Collections.Generic.IList<global::ElevenLabs.VideoElement>? elements,
            int? durationSecs)
        {
            this.StartFrame = startFrame;
            this.EndFrame = endFrame;
            this.AspectRatio = aspectRatio;
            this.Video = video;
            this.KeepAudio = keepAudio;
            this.ReferenceImages = referenceImages;
            this.Elements = elements;
            this.DurationSecs = durationSecs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KlingOmniVideoParameters" /> class.
        /// </summary>
        public KlingOmniVideoParameters()
        {
        }
    }
}