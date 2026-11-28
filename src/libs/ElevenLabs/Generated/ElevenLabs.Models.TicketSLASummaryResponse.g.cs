
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TicketSLASummaryResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.SLAMetricJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.SLAMetric Metric { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DurationSecs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at_unix_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartedAtUnixSecs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("due_at_unix_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DueAtUnixSecs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TicketSLASummaryResponse" /> class.
        /// </summary>
        /// <param name="metric"></param>
        /// <param name="durationSecs"></param>
        /// <param name="startedAtUnixSecs"></param>
        /// <param name="dueAtUnixSecs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TicketSLASummaryResponse(
            global::ElevenLabs.SLAMetric metric,
            int durationSecs,
            int startedAtUnixSecs,
            int dueAtUnixSecs)
        {
            this.Metric = metric;
            this.DurationSecs = durationSecs;
            this.StartedAtUnixSecs = startedAtUnixSecs;
            this.DueAtUnixSecs = dueAtUnixSecs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TicketSLASummaryResponse" /> class.
        /// </summary>
        public TicketSLASummaryResponse()
        {
        }

    }
}