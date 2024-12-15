
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationHistoryFeedbackCommonModel
    {
        /// <summary>
        /// An enumeration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overall_score")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.UserFeedbackScoreJsonConverter))]
        public global::ElevenLabs.UserFeedbackScore? OverallScore { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("likes")]
        public int? Likes { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dislikes")]
        public int? Dislikes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryFeedbackCommonModel" /> class.
        /// </summary>
        /// <param name="overallScore">
        /// An enumeration.
        /// </param>
        /// <param name="likes">
        /// Default Value: 0
        /// </param>
        /// <param name="dislikes">
        /// Default Value: 0
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ConversationHistoryFeedbackCommonModel(
            global::ElevenLabs.UserFeedbackScore? overallScore,
            int? likes,
            int? dislikes)
        {
            this.OverallScore = overallScore;
            this.Likes = likes;
            this.Dislikes = dislikes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryFeedbackCommonModel" /> class.
        /// </summary>
        public ConversationHistoryFeedbackCommonModel()
        {
        }
    }
}