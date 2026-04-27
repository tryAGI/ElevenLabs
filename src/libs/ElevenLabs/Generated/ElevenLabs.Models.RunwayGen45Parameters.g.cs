
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Parameters for Runway Gen-4.5 T2V and I2V.
    /// </summary>
    public sealed partial class RunwayGen45Parameters
    {
        /// <summary>
        /// Default Value: 16:9
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.RunwayGen45ParametersAspectRatioJsonConverter))]
        public global::ElevenLabs.RunwayGen45ParametersAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Default Value: 720p
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        public string? Resolution { get; set; }

        /// <summary>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_secs")]
        public int? DurationSecs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_frame")]
        public global::ElevenLabs.ReferenceImage? StartFrame { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunwayGen45Parameters" /> class.
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
        /// <param name="startFrame"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunwayGen45Parameters(
            global::ElevenLabs.RunwayGen45ParametersAspectRatio? aspectRatio,
            string? resolution,
            int? durationSecs,
            global::ElevenLabs.ReferenceImage? startFrame)
        {
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
            this.DurationSecs = durationSecs;
            this.StartFrame = startFrame;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunwayGen45Parameters" /> class.
        /// </summary>
        public RunwayGen45Parameters()
        {
        }
    }
}