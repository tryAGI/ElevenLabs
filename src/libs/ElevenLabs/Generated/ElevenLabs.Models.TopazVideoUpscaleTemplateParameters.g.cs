
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TopazVideoUpscaleTemplateParameters
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
        public global::ElevenLabs.ReferenceVideo? Video { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TopazVideoUpscaleTemplateParameters" /> class.
        /// </summary>
        /// <param name="upscaleFactor">
        /// Default Value: 2F
        /// </param>
        /// <param name="targetFps"></param>
        /// <param name="video"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TopazVideoUpscaleTemplateParameters(
            double? upscaleFactor,
            int? targetFps,
            global::ElevenLabs.ReferenceVideo? video)
        {
            this.UpscaleFactor = upscaleFactor;
            this.TargetFps = targetFps;
            this.Video = video;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopazVideoUpscaleTemplateParameters" /> class.
        /// </summary>
        public TopazVideoUpscaleTemplateParameters()
        {
        }
    }
}