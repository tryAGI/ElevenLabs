
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePost
    {
        /// <summary>
        /// Start of the time range as a Unix timestamp in milliseconds. Must be at least 2020-01-01.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset StartTime { get; set; }

        /// <summary>
        /// End of the time range as a Unix timestamp in milliseconds. Must be at least 2020-01-01.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset EndTime { get; set; }

        /// <summary>
        /// Default Value: 60
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval_seconds")]
        public int? IntervalSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_by")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item>? GroupBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.ColumnFilter>? Filters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePost" /> class.
        /// </summary>
        /// <param name="startTime">
        /// Start of the time range as a Unix timestamp in milliseconds. Must be at least 2020-01-01.
        /// </param>
        /// <param name="endTime">
        /// End of the time range as a Unix timestamp in milliseconds. Must be at least 2020-01-01.
        /// </param>
        /// <param name="intervalSeconds">
        /// Default Value: 60
        /// </param>
        /// <param name="groupBy"></param>
        /// <param name="filters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePost(
            global::System.DateTimeOffset startTime,
            global::System.DateTimeOffset endTime,
            int? intervalSeconds,
            global::System.Collections.Generic.IList<global::ElevenLabs.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item>? groupBy,
            global::System.Collections.Generic.IList<global::ElevenLabs.ColumnFilter>? filters)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.IntervalSeconds = intervalSeconds;
            this.GroupBy = groupBy;
            this.Filters = filters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePost" /> class.
        /// </summary>
        public BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePost()
        {
        }

    }
}