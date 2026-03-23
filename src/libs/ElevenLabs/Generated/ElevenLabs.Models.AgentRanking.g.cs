
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentRanking
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rank")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Rank { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pass_rate")]
        public double? PassRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Evaluations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trend_delta")]
        public double? TrendDelta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_evaluated")]
        public string? LastEvaluated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRanking" /> class.
        /// </summary>
        /// <param name="rank"></param>
        /// <param name="agentId"></param>
        /// <param name="agentName"></param>
        /// <param name="passRate"></param>
        /// <param name="evaluations"></param>
        /// <param name="trendDelta"></param>
        /// <param name="lastEvaluated"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentRanking(
            int rank,
            string agentId,
            string agentName,
            int evaluations,
            double? passRate,
            double? trendDelta,
            string? lastEvaluated)
        {
            this.Rank = rank;
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.AgentName = agentName ?? throw new global::System.ArgumentNullException(nameof(agentName));
            this.Evaluations = evaluations;
            this.PassRate = passRate;
            this.TrendDelta = trendDelta;
            this.LastEvaluated = lastEvaluated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRanking" /> class.
        /// </summary>
        public AgentRanking()
        {
        }
    }
}