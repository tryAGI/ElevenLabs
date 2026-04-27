
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LTXV2RetakeTemplateParameters
    {
        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retake_start_time")]
        public double? RetakeStartTime { get; set; }

        /// <summary>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retake_duration_secs")]
        public int? RetakeDurationSecs { get; set; }

        /// <summary>
        /// Default Value: replace_audio_and_video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retake_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.LTXV2RetakeTemplateParametersRetakeModeJsonConverter))]
        public global::ElevenLabs.LTXV2RetakeTemplateParametersRetakeMode? RetakeMode { get; set; }

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
        /// Initializes a new instance of the <see cref="LTXV2RetakeTemplateParameters" /> class.
        /// </summary>
        /// <param name="retakeStartTime">
        /// Default Value: 0
        /// </param>
        /// <param name="retakeDurationSecs">
        /// Default Value: 5
        /// </param>
        /// <param name="retakeMode">
        /// Default Value: replace_audio_and_video
        /// </param>
        /// <param name="video"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LTXV2RetakeTemplateParameters(
            double? retakeStartTime,
            int? retakeDurationSecs,
            global::ElevenLabs.LTXV2RetakeTemplateParametersRetakeMode? retakeMode,
            global::ElevenLabs.ReferenceVideo? video)
        {
            this.RetakeStartTime = retakeStartTime;
            this.RetakeDurationSecs = retakeDurationSecs;
            this.RetakeMode = retakeMode;
            this.Video = video;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LTXV2RetakeTemplateParameters" /> class.
        /// </summary>
        public LTXV2RetakeTemplateParameters()
        {
        }
    }
}