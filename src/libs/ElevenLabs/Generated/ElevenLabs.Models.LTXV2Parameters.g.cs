
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LTXV2Parameters
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_frame")]
        public global::ElevenLabs.ReferenceImage? StartFrame { get; set; }

        /// <summary>
        /// Default Value: 6
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_secs")]
        public int? DurationSecs { get; set; }

        /// <summary>
        /// Default Value: 25
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_fps")]
        public int? TargetFps { get; set; }

        /// <summary>
        /// Default Value: 1080p
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.LTXV2ParametersResolutionJsonConverter))]
        public global::ElevenLabs.LTXV2ParametersResolution? Resolution { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generate_audio")]
        public bool? GenerateAudio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LTXV2Parameters" /> class.
        /// </summary>
        /// <param name="startFrame"></param>
        /// <param name="durationSecs">
        /// Default Value: 6
        /// </param>
        /// <param name="targetFps">
        /// Default Value: 25
        /// </param>
        /// <param name="resolution">
        /// Default Value: 1080p
        /// </param>
        /// <param name="generateAudio">
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LTXV2Parameters(
            global::ElevenLabs.ReferenceImage? startFrame,
            int? durationSecs,
            int? targetFps,
            global::ElevenLabs.LTXV2ParametersResolution? resolution,
            bool? generateAudio)
        {
            this.StartFrame = startFrame;
            this.DurationSecs = durationSecs;
            this.TargetFps = targetFps;
            this.Resolution = resolution;
            this.GenerateAudio = generateAudio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LTXV2Parameters" /> class.
        /// </summary>
        public LTXV2Parameters()
        {
        }
    }
}