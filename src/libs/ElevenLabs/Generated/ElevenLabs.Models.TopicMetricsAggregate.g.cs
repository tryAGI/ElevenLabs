
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TopicMetricsAggregate
    {
        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_count")]
        public int? ConversationCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentiment")]
        public global::ElevenLabs.TopicSentimentAggregate? Sentiment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluation_criteria")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.TopicEvaluationCriteriaAggregate>? EvaluationCriteria { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicMetricsAggregate" /> class.
        /// </summary>
        /// <param name="conversationCount">
        /// Default Value: 0
        /// </param>
        /// <param name="sentiment"></param>
        /// <param name="evaluationCriteria"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TopicMetricsAggregate(
            int? conversationCount,
            global::ElevenLabs.TopicSentimentAggregate? sentiment,
            global::System.Collections.Generic.IList<global::ElevenLabs.TopicEvaluationCriteriaAggregate>? evaluationCriteria)
        {
            this.ConversationCount = conversationCount;
            this.Sentiment = sentiment;
            this.EvaluationCriteria = evaluationCriteria;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicMetricsAggregate" /> class.
        /// </summary>
        public TopicMetricsAggregate()
        {
        }

    }
}