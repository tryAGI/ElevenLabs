
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SentimentAggregate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scored_conversation_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ScoredConversationCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("positive_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PositiveCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("neutral_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NeutralCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NegativeCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("average_sentiment_score")]
        public double? AverageSentimentScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("average_frustration_score")]
        public double? AverageFrustrationScore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SentimentAggregate" /> class.
        /// </summary>
        /// <param name="scoredConversationCount"></param>
        /// <param name="positiveCount"></param>
        /// <param name="neutralCount"></param>
        /// <param name="negativeCount"></param>
        /// <param name="averageSentimentScore"></param>
        /// <param name="averageFrustrationScore"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SentimentAggregate(
            int scoredConversationCount,
            int positiveCount,
            int neutralCount,
            int negativeCount,
            double? averageSentimentScore,
            double? averageFrustrationScore)
        {
            this.ScoredConversationCount = scoredConversationCount;
            this.PositiveCount = positiveCount;
            this.NeutralCount = neutralCount;
            this.NegativeCount = negativeCount;
            this.AverageSentimentScore = averageSentimentScore;
            this.AverageFrustrationScore = averageFrustrationScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SentimentAggregate" /> class.
        /// </summary>
        public SentimentAggregate()
        {
        }

    }
}