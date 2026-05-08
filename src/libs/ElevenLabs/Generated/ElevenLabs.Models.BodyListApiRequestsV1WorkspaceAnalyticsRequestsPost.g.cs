
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyListApiRequestsV1WorkspaceAnalyticsRequestsPost
    {
        /// <summary>
        /// Start of the time range as a Unix timestamp in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public long? StartTime { get; set; }

        /// <summary>
        /// End of the time range as a Unix timestamp in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public long? EndTime { get; set; }

        /// <summary>
        /// Default Value: 100
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Optional timestamp sort direction. If omitted, defaults to desc when end_time is provided, otherwise asc.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort")]
        public global::ElevenLabs.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort2? Sort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.ColumnFilter>? Filters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search")]
        public string? Search { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyListApiRequestsV1WorkspaceAnalyticsRequestsPost" /> class.
        /// </summary>
        /// <param name="startTime">
        /// Start of the time range as a Unix timestamp in milliseconds.
        /// </param>
        /// <param name="endTime">
        /// End of the time range as a Unix timestamp in milliseconds.
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="sort">
        /// Optional timestamp sort direction. If omitted, defaults to desc when end_time is provided, otherwise asc.
        /// </param>
        /// <param name="filters"></param>
        /// <param name="search"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyListApiRequestsV1WorkspaceAnalyticsRequestsPost(
            long? startTime,
            long? endTime,
            int? limit,
            global::ElevenLabs.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort2? sort,
            global::System.Collections.Generic.IList<global::ElevenLabs.ColumnFilter>? filters,
            string? search)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Limit = limit;
            this.Sort = sort;
            this.Filters = filters;
            this.Search = search;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyListApiRequestsV1WorkspaceAnalyticsRequestsPost" /> class.
        /// </summary>
        public BodyListApiRequestsV1WorkspaceAnalyticsRequestsPost()
        {
        }
    }
}