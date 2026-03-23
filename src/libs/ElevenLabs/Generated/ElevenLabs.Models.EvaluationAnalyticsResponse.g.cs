
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluationAnalyticsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.SummaryStats Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_series")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.TimeSeriesBucket> TimeSeries { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_criteria")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.CriterionBreakdown> TopCriteria { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_agents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.AgentBreakdown> TopAgents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agents_performance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.AgentPerformance> AgentsPerformance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("onboarding")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.OnboardingStatus Onboarding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_score_pct_delta")]
        public double? AvgScorePctDelta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_evaluations_delta")]
        public double? TotalEvaluationsDelta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationAnalyticsResponse" /> class.
        /// </summary>
        /// <param name="summary"></param>
        /// <param name="timeSeries"></param>
        /// <param name="topCriteria"></param>
        /// <param name="topAgents"></param>
        /// <param name="agentsPerformance"></param>
        /// <param name="onboarding"></param>
        /// <param name="avgScorePctDelta"></param>
        /// <param name="totalEvaluationsDelta"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationAnalyticsResponse(
            global::ElevenLabs.SummaryStats summary,
            global::System.Collections.Generic.IList<global::ElevenLabs.TimeSeriesBucket> timeSeries,
            global::System.Collections.Generic.IList<global::ElevenLabs.CriterionBreakdown> topCriteria,
            global::System.Collections.Generic.IList<global::ElevenLabs.AgentBreakdown> topAgents,
            global::System.Collections.Generic.IList<global::ElevenLabs.AgentPerformance> agentsPerformance,
            global::ElevenLabs.OnboardingStatus onboarding,
            double? avgScorePctDelta,
            double? totalEvaluationsDelta)
        {
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.TimeSeries = timeSeries ?? throw new global::System.ArgumentNullException(nameof(timeSeries));
            this.TopCriteria = topCriteria ?? throw new global::System.ArgumentNullException(nameof(topCriteria));
            this.TopAgents = topAgents ?? throw new global::System.ArgumentNullException(nameof(topAgents));
            this.AgentsPerformance = agentsPerformance ?? throw new global::System.ArgumentNullException(nameof(agentsPerformance));
            this.Onboarding = onboarding ?? throw new global::System.ArgumentNullException(nameof(onboarding));
            this.AvgScorePctDelta = avgScorePctDelta;
            this.TotalEvaluationsDelta = totalEvaluationsDelta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationAnalyticsResponse" /> class.
        /// </summary>
        public EvaluationAnalyticsResponse()
        {
        }
    }
}