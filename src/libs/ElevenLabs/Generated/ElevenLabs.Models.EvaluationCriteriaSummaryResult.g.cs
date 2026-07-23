
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluationCriteriaSummaryResult
    {
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
        /// Initializes a new instance of the <see cref="EvaluationCriteriaSummaryResult" /> class.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="score"></param>
        /// <param name="maxScore"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationCriteriaSummaryResult(
            global::ElevenLabs.EvaluationSuccessResult result,
            int? score,
            int? maxScore)
        {
            this.Result = result;
            this.Score = score;
            this.MaxScore = maxScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationCriteriaSummaryResult" /> class.
        /// </summary>
        public EvaluationCriteriaSummaryResult()
        {
        }

    }
}