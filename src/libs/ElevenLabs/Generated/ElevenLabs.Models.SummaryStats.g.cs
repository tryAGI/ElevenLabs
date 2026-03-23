
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SummaryStats
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_evaluations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalEvaluations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Completed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Failed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_or_processing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PendingOrProcessing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_score_pct")]
        public double? AvgScorePct { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_call_duration_seconds")]
        public double? AvgCallDurationSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_agents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalAgents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_criteria")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCriteria { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryStats" /> class.
        /// </summary>
        /// <param name="totalEvaluations"></param>
        /// <param name="completed"></param>
        /// <param name="failed"></param>
        /// <param name="pendingOrProcessing"></param>
        /// <param name="avgScorePct"></param>
        /// <param name="avgCallDurationSeconds"></param>
        /// <param name="totalAgents"></param>
        /// <param name="totalCriteria"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SummaryStats(
            int totalEvaluations,
            int completed,
            int failed,
            int pendingOrProcessing,
            int totalAgents,
            int totalCriteria,
            double? avgScorePct,
            double? avgCallDurationSeconds)
        {
            this.TotalEvaluations = totalEvaluations;
            this.Completed = completed;
            this.Failed = failed;
            this.PendingOrProcessing = pendingOrProcessing;
            this.TotalAgents = totalAgents;
            this.TotalCriteria = totalCriteria;
            this.AvgScorePct = avgScorePct;
            this.AvgCallDurationSeconds = avgCallDurationSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryStats" /> class.
        /// </summary>
        public SummaryStats()
        {
        }
    }
}