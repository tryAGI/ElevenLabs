
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScopedAnalysisResult
    {
        /// <summary>
        /// The scope of the analysis. 'conversation' uses the full transcript; 'agent' uses only the portion where the defining agent was active.<br/>
        /// Default Value: conversation
        /// </summary>
        /// <default>global::ElevenLabs.AnalysisScope.Conversation</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AnalysisScopeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.AnalysisScope Scope { get; set; } = global::ElevenLabs.AnalysisScope.Conversation;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceAgentId { get; set; }

        /// <summary>
        /// Branch of the agent for this scoped block; disambiguates repeated agent_id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_branch_id")]
        public string? SourceBranchId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluation_criteria_results")]
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.ConversationHistoryEvaluationCriteriaResultCommonModel>? EvaluationCriteriaResults { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_collection_results")]
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.DataCollectionResultCommonModel>? DataCollectionResults { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("successful")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.EvaluationSuccessResultJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.EvaluationSuccessResult Successful { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScopedAnalysisResult" /> class.
        /// </summary>
        /// <param name="scope">
        /// The scope of the analysis. 'conversation' uses the full transcript; 'agent' uses only the portion where the defining agent was active.<br/>
        /// Default Value: conversation
        /// </param>
        /// <param name="sourceAgentId"></param>
        /// <param name="successful"></param>
        /// <param name="sourceBranchId">
        /// Branch of the agent for this scoped block; disambiguates repeated agent_id.
        /// </param>
        /// <param name="evaluationCriteriaResults"></param>
        /// <param name="dataCollectionResults"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScopedAnalysisResult(
            global::ElevenLabs.AnalysisScope scope,
            string sourceAgentId,
            global::ElevenLabs.EvaluationSuccessResult successful,
            string? sourceBranchId,
            global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.ConversationHistoryEvaluationCriteriaResultCommonModel>? evaluationCriteriaResults,
            global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.DataCollectionResultCommonModel>? dataCollectionResults)
        {
            this.Scope = scope;
            this.SourceAgentId = sourceAgentId ?? throw new global::System.ArgumentNullException(nameof(sourceAgentId));
            this.SourceBranchId = sourceBranchId;
            this.EvaluationCriteriaResults = evaluationCriteriaResults;
            this.DataCollectionResults = dataCollectionResults;
            this.Successful = successful;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScopedAnalysisResult" /> class.
        /// </summary>
        public ScopedAnalysisResult()
        {
        }

    }
}