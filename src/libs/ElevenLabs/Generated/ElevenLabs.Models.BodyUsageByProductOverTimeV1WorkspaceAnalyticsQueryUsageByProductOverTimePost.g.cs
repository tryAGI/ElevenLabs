
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyUsageByProductOverTimeV1WorkspaceAnalyticsQueryUsageByProductOverTimePost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndTime { get; set; }

        /// <summary>
        /// Default Value: 60
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval_seconds")]
        public int? IntervalSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_by")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.BodyUsageByProductOverTimeV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item>? GroupBy { get; set; }

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
        /// Initializes a new instance of the <see cref="BodyUsageByProductOverTimeV1WorkspaceAnalyticsQueryUsageByProductOverTimePost" /> class.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="intervalSeconds">
        /// Default Value: 60
        /// </param>
        /// <param name="groupBy"></param>
        /// <param name="filters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyUsageByProductOverTimeV1WorkspaceAnalyticsQueryUsageByProductOverTimePost(
            int startTime,
            int endTime,
            int? intervalSeconds,
            global::System.Collections.Generic.IList<global::ElevenLabs.BodyUsageByProductOverTimeV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item>? groupBy,
            global::System.Collections.Generic.IList<global::ElevenLabs.ColumnFilter>? filters)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.IntervalSeconds = intervalSeconds;
            this.GroupBy = groupBy;
            this.Filters = filters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUsageByProductOverTimeV1WorkspaceAnalyticsQueryUsageByProductOverTimePost" /> class.
        /// </summary>
        public BodyUsageByProductOverTimeV1WorkspaceAnalyticsQueryUsageByProductOverTimePost()
        {
        }
    }
}