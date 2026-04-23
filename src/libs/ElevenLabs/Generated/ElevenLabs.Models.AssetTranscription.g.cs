
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssetTranscription
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AssetTranscriptionStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.AssetTranscriptionStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::ElevenLabs.AssetTranscriptionData2? Data { get; set; }

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
        /// Initializes a new instance of the <see cref="AssetTranscription" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="data"></param>
        /// <param name="updatedAtMs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssetTranscription(
            global::ElevenLabs.AssetTranscriptionStatus status,
            global::ElevenLabs.AssetTranscriptionData2? data,
            int? updatedAtMs)
        {
            this.Status = status;
            this.Data = data;
            this.UpdatedAtMs = updatedAtMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetTranscription" /> class.
        /// </summary>
        public AssetTranscription()
        {
        }
    }
}