
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePost
    {
        /// <summary>
        /// Start of the time range as a Unix timestamp in milliseconds. Must be at least 2020-01-01.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long StartTime { get; set; }

        /// <summary>
        /// End of the time range as a Unix timestamp in milliseconds. Must be at least 2020-01-01.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long EndTime { get; set; }

        /// <summary>
        /// Bucket size in seconds, in whole UTC days. Pass 86400 for daily buckets or 604800 for weekly buckets, which start on Monday.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int IntervalSeconds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_by")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePostGroupByVariant1Item>? GroupBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.MetronomeUsageColumnFilter>? Filters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePost" /> class.
        /// </summary>
        /// <param name="startTime">
        /// Start of the time range as a Unix timestamp in milliseconds. Must be at least 2020-01-01.
        /// </param>
        /// <param name="endTime">
        /// End of the time range as a Unix timestamp in milliseconds. Must be at least 2020-01-01.
        /// </param>
        /// <param name="intervalSeconds">
        /// Bucket size in seconds, in whole UTC days. Pass 86400 for daily buckets or 604800 for weekly buckets, which start on Monday.
        /// </param>
        /// <param name="groupBy"></param>
        /// <param name="filters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePost(
            long startTime,
            long endTime,
            int intervalSeconds,
            global::System.Collections.Generic.IList<global::ElevenLabs.BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePostGroupByVariant1Item>? groupBy,
            global::System.Collections.Generic.IList<global::ElevenLabs.MetronomeUsageColumnFilter>? filters)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.IntervalSeconds = intervalSeconds;
            this.GroupBy = groupBy;
            this.Filters = filters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePost" /> class.
        /// </summary>
        public BodyGetWorkspaceCostUsageV1WorkspaceAnalyticsUsagePost()
        {
        }

    }
}