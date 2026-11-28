
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RunConversationEvaluationsRequest
    {
        /// <summary>
        /// ID of the single evaluation criterion to rerun.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EvaluationId { get; set; }

        /// <summary>
        /// Default Value: conversation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AnalysisScopeJsonConverter))]
        public global::ElevenLabs.AnalysisScope? Scope { get; set; }

        /// <summary>
        /// ID of the agent whose evaluation result to rerun, for conversations that transferred between agents. If omitted, a conversation-scoped evaluation reruns for the agent that started the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluated_agent_id")]
        public string? EvaluatedAgentId { get; set; }

        /// <summary>
        /// Branch of `evaluated_agent_id` whose evaluation result to rerun, for conversations that visited the agent on more than one branch. If omitted, the result reruns for every branch of that agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluated_branch_id")]
        public string? EvaluatedBranchId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunConversationEvaluationsRequest" /> class.
        /// </summary>
        /// <param name="evaluationId">
        /// ID of the single evaluation criterion to rerun.
        /// </param>
        /// <param name="scope">
        /// Default Value: conversation
        /// </param>
        /// <param name="evaluatedAgentId">
        /// ID of the agent whose evaluation result to rerun, for conversations that transferred between agents. If omitted, a conversation-scoped evaluation reruns for the agent that started the conversation.
        /// </param>
        /// <param name="evaluatedBranchId">
        /// Branch of `evaluated_agent_id` whose evaluation result to rerun, for conversations that visited the agent on more than one branch. If omitted, the result reruns for every branch of that agent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunConversationEvaluationsRequest(
            string evaluationId,
            global::ElevenLabs.AnalysisScope? scope,
            string? evaluatedAgentId,
            string? evaluatedBranchId)
        {
            this.EvaluationId = evaluationId ?? throw new global::System.ArgumentNullException(nameof(evaluationId));
            this.Scope = scope;
            this.EvaluatedAgentId = evaluatedAgentId;
            this.EvaluatedBranchId = evaluatedBranchId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunConversationEvaluationsRequest" /> class.
        /// </summary>
        public RunConversationEvaluationsRequest()
        {
        }

    }
}