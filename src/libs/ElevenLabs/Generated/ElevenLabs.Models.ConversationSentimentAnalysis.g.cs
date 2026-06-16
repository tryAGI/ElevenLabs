
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationSentimentAnalysis
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overall_label")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ConversationSentimentAnalysisOverallLabelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ConversationSentimentAnalysisOverallLabel OverallLabel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overall_sentiment_score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double OverallSentimentScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overall_frustration_score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double OverallFrustrationScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_user_sentiment_score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MinUserSentimentScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_user_frustration_score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MaxUserFrustrationScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_scored_user_turns")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumScoredUserTurns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationSentimentAnalysis" /> class.
        /// </summary>
        /// <param name="overallLabel"></param>
        /// <param name="overallSentimentScore"></param>
        /// <param name="overallFrustrationScore"></param>
        /// <param name="minUserSentimentScore"></param>
        /// <param name="maxUserFrustrationScore"></param>
        /// <param name="numScoredUserTurns"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationSentimentAnalysis(
            global::ElevenLabs.ConversationSentimentAnalysisOverallLabel overallLabel,
            double overallSentimentScore,
            double overallFrustrationScore,
            double minUserSentimentScore,
            double maxUserFrustrationScore,
            int numScoredUserTurns)
        {
            this.OverallLabel = overallLabel;
            this.OverallSentimentScore = overallSentimentScore;
            this.OverallFrustrationScore = overallFrustrationScore;
            this.MinUserSentimentScore = minUserSentimentScore;
            this.MaxUserFrustrationScore = maxUserFrustrationScore;
            this.NumScoredUserTurns = numScoredUserTurns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationSentimentAnalysis" /> class.
        /// </summary>
        public ConversationSentimentAnalysis()
        {
        }

    }
}