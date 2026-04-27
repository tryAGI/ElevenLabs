
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Veo2ExpParameters
    {
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
        /// Default Value: 8
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_secs")]
        public int? DurationSecs { get; set; }

        /// <summary>
        /// Default Value: 16:9
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AspectRatioJsonConverter))]
        public global::ElevenLabs.AspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Default Value: 720p
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        public string? Resolution { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_frame")]
        public global::ElevenLabs.ReferenceImage? StartFrame { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extend_video")]
        public global::ElevenLabs.ReferenceVideo? ExtendVideo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_frame")]
        public global::ElevenLabs.ReferenceImage? EndFrame { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_images")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.VeoReferenceImage>? ReferenceImages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Veo2ExpParameters" /> class.
        /// </summary>
        /// <param name="negativePrompt"></param>
        /// <param name="seed"></param>
        /// <param name="enhancePrompt">
        /// Default Value: true
        /// </param>
        /// <param name="durationSecs">
        /// Default Value: 8
        /// </param>
        /// <param name="aspectRatio">
        /// Default Value: 16:9
        /// </param>
        /// <param name="resolution">
        /// Default Value: 720p
        /// </param>
        /// <param name="startFrame"></param>
        /// <param name="extendVideo"></param>
        /// <param name="endFrame"></param>
        /// <param name="referenceImages"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Veo2ExpParameters(
            global::ElevenLabs.AnyOf<string, global::ElevenLabs.ReferenceText, object>? negativePrompt,
            int? seed,
            bool? enhancePrompt,
            int? durationSecs,
            global::ElevenLabs.AspectRatio? aspectRatio,
            string? resolution,
            global::ElevenLabs.ReferenceImage? startFrame,
            global::ElevenLabs.ReferenceVideo? extendVideo,
            global::ElevenLabs.ReferenceImage? endFrame,
            global::System.Collections.Generic.IList<global::ElevenLabs.VeoReferenceImage>? referenceImages)
        {
            this.NegativePrompt = negativePrompt;
            this.Seed = seed;
            this.EnhancePrompt = enhancePrompt;
            this.DurationSecs = durationSecs;
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
            this.StartFrame = startFrame;
            this.ExtendVideo = extendVideo;
            this.EndFrame = endFrame;
            this.ReferenceImages = referenceImages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Veo2ExpParameters" /> class.
        /// </summary>
        public Veo2ExpParameters()
        {
        }
    }
}