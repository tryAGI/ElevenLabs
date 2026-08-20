
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAgentTopicsResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.AgentTopicResponseModel> Topics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("window_start_unix_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WindowStartUnixSecs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("window_end_unix_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WindowEndUnixSecs { get; set; }

        /// <summary>
        /// Number of daily topic-discovery runs the returned metrics were summed over.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aggregated_run_count")]
        public int? AggregatedRunCount { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool? HasMore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentTopicsResponseModel" /> class.
        /// </summary>
        /// <param name="topics"></param>
        /// <param name="windowStartUnixSecs"></param>
        /// <param name="windowEndUnixSecs"></param>
        /// <param name="aggregatedRunCount">
        /// Number of daily topic-discovery runs the returned metrics were summed over.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="hasMore">
        /// Default Value: false
        /// </param>
        /// <param name="nextCursor"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAgentTopicsResponseModel(
            global::System.Collections.Generic.IList<global::ElevenLabs.AgentTopicResponseModel> topics,
            int windowStartUnixSecs,
            int windowEndUnixSecs,
            int? aggregatedRunCount,
            bool? hasMore,
            string? nextCursor)
        {
            this.Topics = topics ?? throw new global::System.ArgumentNullException(nameof(topics));
            this.WindowStartUnixSecs = windowStartUnixSecs;
            this.WindowEndUnixSecs = windowEndUnixSecs;
            this.AggregatedRunCount = aggregatedRunCount;
            this.HasMore = hasMore;
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentTopicsResponseModel" /> class.
        /// </summary>
        public GetAgentTopicsResponseModel()
        {
        }

    }
}