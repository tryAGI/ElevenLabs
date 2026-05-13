
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"has_more":false,"speech_engines":[{"created_at_unix_secs":1714000000,"name":"My Speech Engine","speech_engine_id":"seng_3701k3ttaq12ewp8b7qv5rfyszkz","tags":["production","v1"]}]}
    /// </summary>
    public sealed partial class ListSpeechEnginesResponse
    {
        /// <summary>
        /// The speech engines matching the query
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_engines")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.SpeechEngineSummaryResponse> SpeechEngines { get; set; }

        /// <summary>
        /// Cursor for fetching the next page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Whether there are more results
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSpeechEnginesResponse" /> class.
        /// </summary>
        /// <param name="speechEngines">
        /// The speech engines matching the query
        /// </param>
        /// <param name="hasMore">
        /// Whether there are more results
        /// </param>
        /// <param name="nextCursor">
        /// Cursor for fetching the next page
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListSpeechEnginesResponse(
            global::System.Collections.Generic.IList<global::ElevenLabs.SpeechEngineSummaryResponse> speechEngines,
            bool hasMore,
            string? nextCursor)
        {
            this.SpeechEngines = speechEngines ?? throw new global::System.ArgumentNullException(nameof(speechEngines));
            this.NextCursor = nextCursor;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSpeechEnginesResponse" /> class.
        /// </summary>
        public ListSpeechEnginesResponse()
        {
        }

    }
}