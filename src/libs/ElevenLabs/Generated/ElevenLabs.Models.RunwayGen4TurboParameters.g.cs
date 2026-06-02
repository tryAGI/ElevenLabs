
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunwayGen4TurboParameters
    {
        /// <summary>
        /// Default Value: 16:9
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.RunwayGen4TurboParametersAspectRatioJsonConverter))]
        public global::ElevenLabs.RunwayGen4TurboParametersAspectRatio? AspectRatio { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ReferenceImage StartFrame { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunwayGen4TurboParameters" /> class.
        /// </summary>
        /// <param name="startFrame"></param>
        /// <param name="aspectRatio">
        /// Default Value: 16:9
        /// </param>
        /// <param name="resolution">
        /// Default Value: 720p
        /// </param>
        /// <param name="durationSecs">
        /// Default Value: 5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunwayGen4TurboParameters(
            global::ElevenLabs.ReferenceImage startFrame,
            global::ElevenLabs.RunwayGen4TurboParametersAspectRatio? aspectRatio,
            string? resolution,
            int? durationSecs)
        {
            this.AspectRatio = aspectRatio;
            this.Resolution = resolution;
            this.DurationSecs = durationSecs;
            this.StartFrame = startFrame ?? throw new global::System.ArgumentNullException(nameof(startFrame));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunwayGen4TurboParameters" /> class.
        /// </summary>
        public RunwayGen4TurboParameters()
        {
        }

    }
}