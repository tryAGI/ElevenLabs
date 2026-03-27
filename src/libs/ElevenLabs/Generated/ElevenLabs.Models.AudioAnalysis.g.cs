
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioAnalysis
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AudioAnalysisStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.AudioAnalysisStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::ElevenLabs.AudioAnalysisResult? Data { get; set; }

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
        /// Initializes a new instance of the <see cref="AudioAnalysis" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="data"></param>
        /// <param name="updatedAtMs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioAnalysis(
            global::ElevenLabs.AudioAnalysisStatus status,
            global::ElevenLabs.AudioAnalysisResult? data,
            int? updatedAtMs)
        {
            this.Status = status;
            this.Data = data;
            this.UpdatedAtMs = updatedAtMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioAnalysis" /> class.
        /// </summary>
        public AudioAnalysis()
        {
        }
    }
}