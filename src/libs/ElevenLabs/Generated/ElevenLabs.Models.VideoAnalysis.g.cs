
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoAnalysis
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.VideoAnalysisStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.VideoAnalysisStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::ElevenLabs.VideoAnalysisResult? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at_ms")]
        public int? UpdatedAtMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoAnalysis" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="data"></param>
        /// <param name="updatedAtMs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoAnalysis(
            global::ElevenLabs.VideoAnalysisStatus status,
            global::ElevenLabs.VideoAnalysisResult? data,
            int? updatedAtMs)
        {
            this.Status = status;
            this.Data = data;
            this.UpdatedAtMs = updatedAtMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoAnalysis" /> class.
        /// </summary>
        public VideoAnalysis()
        {
        }

    }
}