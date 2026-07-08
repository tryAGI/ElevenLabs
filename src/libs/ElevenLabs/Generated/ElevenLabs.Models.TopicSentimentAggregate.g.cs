
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TopicSentimentAggregate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentiment")]
        public global::ElevenLabs.NumericDistributionAggregate? Sentiment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frustration")]
        public global::ElevenLabs.NumericDistributionAggregate? Frustration { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("positive_count")]
        public int? PositiveCount { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("neutral_count")]
        public int? NeutralCount { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_count")]
        public int? NegativeCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicSentimentAggregate" /> class.
        /// </summary>
        /// <param name="sentiment"></param>
        /// <param name="frustration"></param>
        /// <param name="positiveCount">
        /// Default Value: 0
        /// </param>
        /// <param name="neutralCount">
        /// Default Value: 0
        /// </param>
        /// <param name="negativeCount">
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TopicSentimentAggregate(
            global::ElevenLabs.NumericDistributionAggregate? sentiment,
            global::ElevenLabs.NumericDistributionAggregate? frustration,
            int? positiveCount,
            int? neutralCount,
            int? negativeCount)
        {
            this.Sentiment = sentiment;
            this.Frustration = frustration;
            this.PositiveCount = positiveCount;
            this.NeutralCount = neutralCount;
            this.NegativeCount = negativeCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicSentimentAggregate" /> class.
        /// </summary>
        public TopicSentimentAggregate()
        {
        }

    }
}