
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TopicEvaluationCriteriaAggregate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("criteria_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CriteriaId { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success_count")]
        public int? SuccessCount { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failure_count")]
        public int? FailureCount { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unknown_count")]
        public int? UnknownCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicEvaluationCriteriaAggregate" /> class.
        /// </summary>
        /// <param name="criteriaId"></param>
        /// <param name="successCount">
        /// Default Value: 0
        /// </param>
        /// <param name="failureCount">
        /// Default Value: 0
        /// </param>
        /// <param name="unknownCount">
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TopicEvaluationCriteriaAggregate(
            string criteriaId,
            int? successCount,
            int? failureCount,
            int? unknownCount)
        {
            this.CriteriaId = criteriaId ?? throw new global::System.ArgumentNullException(nameof(criteriaId));
            this.SuccessCount = successCount;
            this.FailureCount = failureCount;
            this.UnknownCount = unknownCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicEvaluationCriteriaAggregate" /> class.
        /// </summary>
        public TopicEvaluationCriteriaAggregate()
        {
        }

    }
}