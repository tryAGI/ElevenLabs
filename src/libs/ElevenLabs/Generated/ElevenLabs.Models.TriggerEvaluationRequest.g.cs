
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TriggerEvaluationRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TranscriptId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.Dictionary<string, string>? Labels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_name")]
        public string? AgentName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerEvaluationRequest" /> class.
        /// </summary>
        /// <param name="transcriptId"></param>
        /// <param name="agentId"></param>
        /// <param name="evalCriterionId"></param>
        /// <param name="labels"></param>
        /// <param name="agentName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TriggerEvaluationRequest(
            string transcriptId,
            string agentId,
            string evalCriterionId,
            global::System.Collections.Generic.Dictionary<string, string>? labels,
            string? agentName)
        {
            this.TranscriptId = transcriptId ?? throw new global::System.ArgumentNullException(nameof(transcriptId));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.EvalCriterionId = evalCriterionId ?? throw new global::System.ArgumentNullException(nameof(evalCriterionId));
            this.Labels = labels;
            this.AgentName = agentName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerEvaluationRequest" /> class.
        /// </summary>
        public TriggerEvaluationRequest()
        {
        }
    }
}