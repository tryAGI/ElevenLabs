
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BytedanceSeedanceParameters
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.BytedanceSeedanceParametersAspectRatioJsonConverter))]
        public global::ElevenLabs.BytedanceSeedanceParametersAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Default Value: 720p
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.BytedanceSeedanceParametersResolutionJsonConverter))]
        public global::ElevenLabs.BytedanceSeedanceParametersResolution? Resolution { get; set; }

        /// <summary>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_secs")]
        public int? DurationSecs { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("camera_fixed")]
        public bool? CameraFixed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BytedanceSeedanceParameters" /> class.
        /// </summary>
        /// <param name="startFrame"></param>
        /// <param name="endFrame"></param>
        /// <param name="aspectRatio">
        /// Default Value: 16:9
        /// </param>
        /// <param name="resolution">
        /// Default Value: 720p
        /// </param>
        /// <param name="durationSecs">
        /// Default Value: 5
        /// </param>
        /// <param name="cameraFixed">
        /// Default Value: false
        /// </param>
        /// <param name="seed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BytedanceSeedanceParameters(
            global::ElevenLabs.ReferenceImage? startFrame,
            global::ElevenLabs.ReferenceImage? endFrame,
            global::ElevenLabs.BytedanceSeedanceParametersAspectRatio? aspectRatio,
            global::ElevenLabs.BytedanceSeedanceParametersResolution? resolution,
            int? durationSecs,
            bool? cameraFixed,
            int? seed)
        {
            this.StartFrame = startFrame;
            this.EndFrame = endFrame;
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
            this.DurationSecs = durationSecs;
            this.CameraFixed = cameraFixed;
            this.Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BytedanceSeedanceParameters" /> class.
        /// </summary>
        public BytedanceSeedanceParameters()
        {
        }
    }
}