
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CriterionAnalyticsResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("best_agent")]
        public global::ElevenLabs.AgentRanking? BestAgent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("worst_agent")]
        public global::ElevenLabs.AgentRanking? WorstAgent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_ranking")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.AgentRanking> AgentRanking { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_series")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.TimeSeriesBucket> TimeSeries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CriterionAnalyticsResponse" /> class.
        /// </summary>
        /// <param name="totalEvaluations"></param>
        /// <param name="avgScorePct"></param>
        /// <param name="avgScorePctDelta"></param>
        /// <param name="bestAgent"></param>
        /// <param name="worstAgent"></param>
        /// <param name="agentRanking"></param>
        /// <param name="timeSeries"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CriterionAnalyticsResponse(
            int totalEvaluations,
            global::System.Collections.Generic.IList<global::ElevenLabs.AgentRanking> agentRanking,
            global::System.Collections.Generic.IList<global::ElevenLabs.TimeSeriesBucket> timeSeries,
            double? avgScorePct,
            double? avgScorePctDelta,
            global::ElevenLabs.AgentRanking? bestAgent,
            global::ElevenLabs.AgentRanking? worstAgent)
        {
            this.TotalEvaluations = totalEvaluations;
            this.AgentRanking = agentRanking ?? throw new global::System.ArgumentNullException(nameof(agentRanking));
            this.TimeSeries = timeSeries ?? throw new global::System.ArgumentNullException(nameof(timeSeries));
            this.AvgScorePct = avgScorePct;
            this.AvgScorePctDelta = avgScorePctDelta;
            this.BestAgent = bestAgent;
            this.WorstAgent = worstAgent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CriterionAnalyticsResponse" /> class.
        /// </summary>
        public CriterionAnalyticsResponse()
        {
        }
    }
}