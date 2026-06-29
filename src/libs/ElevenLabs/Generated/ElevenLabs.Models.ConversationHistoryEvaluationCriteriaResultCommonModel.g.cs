
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationHistoryEvaluationCriteriaResultCommonModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("criteria_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CriteriaId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.EvaluationSuccessResultJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.EvaluationSuccessResult Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rationale")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Rationale { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scoring_mode")]
        public global::ElevenLabs.CriteriaScoringMode? ScoringMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public int? Score { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_score")]
        public int? MaxScore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryEvaluationCriteriaResultCommonModel" /> class.
        /// </summary>
        /// <param name="criteriaId"></param>
        /// <param name="result"></param>
        /// <param name="rationale"></param>
        /// <param name="scoringMode"></param>
        /// <param name="score"></param>
        /// <param name="maxScore"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationHistoryEvaluationCriteriaResultCommonModel(
            string criteriaId,
            global::ElevenLabs.EvaluationSuccessResult result,
            string rationale,
            global::ElevenLabs.CriteriaScoringMode? scoringMode,
            int? score,
            int? maxScore)
        {
            this.CriteriaId = criteriaId ?? throw new global::System.ArgumentNullException(nameof(criteriaId));
            this.Result = result;
            this.Rationale = rationale ?? throw new global::System.ArgumentNullException(nameof(rationale));
            this.ScoringMode = scoringMode;
            this.Score = score;
            this.MaxScore = maxScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryEvaluationCriteriaResultCommonModel" /> class.
        /// </summary>
        public ConversationHistoryEvaluationCriteriaResultCommonModel()
        {
        }

    }
}