
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"created_at_unix_secs":1714000000,"name":"My Speech Engine","speech_engine_id":"seng_3701k3ttaq12ewp8b7qv5rfyszkz","tags":["production","v1"]}
    /// </summary>
    public sealed partial class SpeechEngineSummaryResponse
    {
        /// <summary>
        /// The speech engine resource ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_engine_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SpeechEngineId { get; set; }

        /// <summary>
        /// Human-readable name for the speech engine
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Creation time in Unix seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_unix_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAtUnixSecs { get; set; }

        /// <summary>
        /// Arbitrary tags for categorization and filtering
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechEngineSummaryResponse" /> class.
        /// </summary>
        /// <param name="speechEngineId">
        /// The speech engine resource ID
        /// </param>
        /// <param name="name">
        /// Human-readable name for the speech engine
        /// </param>
        /// <param name="createdAtUnixSecs">
        /// Creation time in Unix seconds
        /// </param>
        /// <param name="tags">
        /// Arbitrary tags for categorization and filtering
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechEngineSummaryResponse(
            string speechEngineId,
            string name,
            int createdAtUnixSecs,
            global::System.Collections.Generic.IList<string> tags)
        {
            this.SpeechEngineId = speechEngineId ?? throw new global::System.ArgumentNullException(nameof(speechEngineId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAtUnixSecs = createdAtUnixSecs;
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechEngineSummaryResponse" /> class.
        /// </summary>
        public SpeechEngineSummaryResponse()
        {
        }

    }
}