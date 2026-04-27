
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Sora2ProParameters
    {
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_frame")]
        public global::ElevenLabs.ReferenceImage? StartFrame { get; set; }

        /// <summary>
        /// Default Value: 720p
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.Sora2ProParametersResolutionJsonConverter))]
        public global::ElevenLabs.Sora2ProParametersResolution? Resolution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Sora2ProParameters" /> class.
        /// </summary>
        /// <param name="durationSecs">
        /// Default Value: 8
        /// </param>
        /// <param name="aspectRatio">
        /// Default Value: 16:9
        /// </param>
        /// <param name="startFrame"></param>
        /// <param name="resolution">
        /// Default Value: 720p
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Sora2ProParameters(
            int? durationSecs,
            global::ElevenLabs.AspectRatio? aspectRatio,
            global::ElevenLabs.ReferenceImage? startFrame,
            global::ElevenLabs.Sora2ProParametersResolution? resolution)
        {
            this.DurationSecs = durationSecs;
            this.AspectRatio = aspectRatio;
            this.StartFrame = startFrame;
            this.Resolution = resolution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Sora2ProParameters" /> class.
        /// </summary>
        public Sora2ProParameters()
        {
        }
    }
}