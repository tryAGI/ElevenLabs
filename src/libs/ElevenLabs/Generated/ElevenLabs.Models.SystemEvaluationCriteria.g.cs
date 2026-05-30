
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SystemEvaluationCriteria
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_sentiment_score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UserSentimentScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_frustration_score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UserFrustrationScore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemEvaluationCriteria" /> class.
        /// </summary>
        /// <param name="userSentimentScore"></param>
        /// <param name="userFrustrationScore"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SystemEvaluationCriteria(
            double userSentimentScore,
            double userFrustrationScore)
        {
            this.UserSentimentScore = userSentimentScore;
            this.UserFrustrationScore = userFrustrationScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemEvaluationCriteria" /> class.
        /// </summary>
        public SystemEvaluationCriteria()
        {
        }

    }
}