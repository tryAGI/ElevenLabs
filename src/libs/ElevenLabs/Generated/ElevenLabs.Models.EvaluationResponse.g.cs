
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluationResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkspaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eval_criterion_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EvalCriterionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TranscriptId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public object? Labels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("criteria_scores")]
        public global::System.Collections.Generic.IList<object>? CriteriaScores { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extracted_data")]
        public global::System.Collections.Generic.IList<object>? ExtractedData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_summary")]
        public string? CallSummary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_duration_seconds")]
        public double? CallDurationSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_speaking_pct")]
        public double? AgentSpeakingPct { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_speaking_pct")]
        public double? UserSpeakingPct { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_timestamp")]
        public global::System.DateTime? CallTimestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="workspaceId"></param>
        /// <param name="agentId"></param>
        /// <param name="evalCriterionId"></param>
        /// <param name="transcriptId"></param>
        /// <param name="labels"></param>
        /// <param name="status"></param>
        /// <param name="criteriaScores"></param>
        /// <param name="extractedData"></param>
        /// <param name="callSummary"></param>
        /// <param name="callDurationSeconds"></param>
        /// <param name="agentSpeakingPct"></param>
        /// <param name="userSpeakingPct"></param>
        /// <param name="callTimestamp"></param>
        /// <param name="createdAt"></param>
        /// <param name="completedAt"></param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationResponse(
            string id,
            string workspaceId,
            string agentId,
            string evalCriterionId,
            string transcriptId,
            string status,
            global::System.DateTime createdAt,
            object? labels,
            global::System.Collections.Generic.IList<object>? criteriaScores,
            global::System.Collections.Generic.IList<object>? extractedData,
            string? callSummary,
            double? callDurationSeconds,
            double? agentSpeakingPct,
            double? userSpeakingPct,
            global::System.DateTime? callTimestamp,
            global::System.DateTime? completedAt,
            string? error)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.WorkspaceId = workspaceId ?? throw new global::System.ArgumentNullException(nameof(workspaceId));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.EvalCriterionId = evalCriterionId ?? throw new global::System.ArgumentNullException(nameof(evalCriterionId));
            this.TranscriptId = transcriptId ?? throw new global::System.ArgumentNullException(nameof(transcriptId));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.CreatedAt = createdAt;
            this.Labels = labels;
            this.CriteriaScores = criteriaScores;
            this.ExtractedData = extractedData;
            this.CallSummary = callSummary;
            this.CallDurationSeconds = callDurationSeconds;
            this.AgentSpeakingPct = agentSpeakingPct;
            this.UserSpeakingPct = userSpeakingPct;
            this.CallTimestamp = callTimestamp;
            this.CompletedAt = completedAt;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationResponse" /> class.
        /// </summary>
        public EvaluationResponse()
        {
        }
    }
}