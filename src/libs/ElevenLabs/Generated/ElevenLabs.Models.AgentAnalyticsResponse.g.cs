
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentAnalyticsResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_score_pct")]
        public double? AvgScorePct { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_score_pct_delta")]
        public double? AvgScorePctDelta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("best_criterion")]
        public global::ElevenLabs.CriterionPerformance? BestCriterion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("worst_criterion")]
        public global::ElevenLabs.CriterionPerformance? WorstCriterion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("criteria_breakdown")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.CriterionPerformance> CriteriaBreakdown { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_series")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.TimeSeriesBucket> TimeSeries { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_call_duration_seconds")]
        public double? AvgCallDurationSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_agent_speaking_pct")]
        public double? AvgAgentSpeakingPct { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_user_speaking_pct")]
        public double? AvgUserSpeakingPct { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentAnalyticsResponse" /> class.
        /// </summary>
        /// <param name="totalEvaluations"></param>
        /// <param name="avgScorePct"></param>
        /// <param name="avgScorePctDelta"></param>
        /// <param name="bestCriterion"></param>
        /// <param name="worstCriterion"></param>
        /// <param name="criteriaBreakdown"></param>
        /// <param name="timeSeries"></param>
        /// <param name="avgCallDurationSeconds"></param>
        /// <param name="avgAgentSpeakingPct"></param>
        /// <param name="avgUserSpeakingPct"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentAnalyticsResponse(
            int totalEvaluations,
            global::System.Collections.Generic.IList<global::ElevenLabs.CriterionPerformance> criteriaBreakdown,
            global::System.Collections.Generic.IList<global::ElevenLabs.TimeSeriesBucket> timeSeries,
            double? avgScorePct,
            double? avgScorePctDelta,
            global::ElevenLabs.CriterionPerformance? bestCriterion,
            global::ElevenLabs.CriterionPerformance? worstCriterion,
            double? avgCallDurationSeconds,
            double? avgAgentSpeakingPct,
            double? avgUserSpeakingPct)
        {
            this.TotalEvaluations = totalEvaluations;
            this.CriteriaBreakdown = criteriaBreakdown ?? throw new global::System.ArgumentNullException(nameof(criteriaBreakdown));
            this.TimeSeries = timeSeries ?? throw new global::System.ArgumentNullException(nameof(timeSeries));
            this.AvgScorePct = avgScorePct;
            this.AvgScorePctDelta = avgScorePctDelta;
            this.BestCriterion = bestCriterion;
            this.WorstCriterion = worstCriterion;
            this.AvgCallDurationSeconds = avgCallDurationSeconds;
            this.AvgAgentSpeakingPct = avgAgentSpeakingPct;
            this.AvgUserSpeakingPct = avgUserSpeakingPct;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentAnalyticsResponse" /> class.
        /// </summary>
        public AgentAnalyticsResponse()
        {
        }
    }
}