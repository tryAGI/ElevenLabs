
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FrustratedConversationRef
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConversationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time_unix_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartTimeUnixSecs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overall_label")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.FrustratedConversationRefOverallLabelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.FrustratedConversationRefOverallLabel OverallLabel { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FrustratedConversationRef" /> class.
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="agentId"></param>
        /// <param name="startTimeUnixSecs"></param>
        /// <param name="overallLabel"></param>
        /// <param name="overallSentimentScore"></param>
        /// <param name="overallFrustrationScore"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FrustratedConversationRef(
            string conversationId,
            string agentId,
            int startTimeUnixSecs,
            global::ElevenLabs.FrustratedConversationRefOverallLabel overallLabel,
            double overallSentimentScore,
            double overallFrustrationScore)
        {
            this.ConversationId = conversationId ?? throw new global::System.ArgumentNullException(nameof(conversationId));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.StartTimeUnixSecs = startTimeUnixSecs;
            this.OverallLabel = overallLabel;
            this.OverallSentimentScore = overallSentimentScore;
            this.OverallFrustrationScore = overallFrustrationScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FrustratedConversationRef" /> class.
        /// </summary>
        public FrustratedConversationRef()
        {
        }

    }
}