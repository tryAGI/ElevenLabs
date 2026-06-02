
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TopazVideoUpscaleParameters
    {
        /// <summary>
        /// Default Value: 2F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upscale_factor")]
        public double? UpscaleFactor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_fps")]
        public int? TargetFps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ReferenceVideo Video { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TopazVideoUpscaleParameters" /> class.
        /// </summary>
        /// <param name="video"></param>
        /// <param name="upscaleFactor">
        /// Default Value: 2F
        /// </param>
        /// <param name="targetFps"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TopazVideoUpscaleParameters(
            global::ElevenLabs.ReferenceVideo video,
            double? upscaleFactor,
            int? targetFps)
        {
            this.UpscaleFactor = upscaleFactor;
            this.TargetFps = targetFps;
            this.Video = video ?? throw new global::System.ArgumentNullException(nameof(video));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopazVideoUpscaleParameters" /> class.
        /// </summary>
        public TopazVideoUpscaleParameters()
        {
        }

    }
}