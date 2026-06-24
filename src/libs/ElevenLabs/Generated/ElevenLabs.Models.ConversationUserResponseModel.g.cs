
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationUserResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_contact_unix_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LastContactUnixSecs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_contact_unix_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FirstContactUnixSecs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ConversationCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_contact_agent_id")]
        public string? LastContactAgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_contact_conversation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LastContactConversationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_contact_agent_name")]
        public string? LastContactAgentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentiment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.SentimentAggregate Sentiment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("most_frustrated_conversations")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.FrustratedConversationRef>? MostFrustratedConversations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationUserResponseModel" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="lastContactUnixSecs"></param>
        /// <param name="firstContactUnixSecs"></param>
        /// <param name="conversationCount"></param>
        /// <param name="lastContactConversationId"></param>
        /// <param name="sentiment"></param>
        /// <param name="lastContactAgentId"></param>
        /// <param name="lastContactAgentName"></param>
        /// <param name="mostFrustratedConversations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationUserResponseModel(
            string userId,
            int lastContactUnixSecs,
            int firstContactUnixSecs,
            int conversationCount,
            string lastContactConversationId,
            global::ElevenLabs.SentimentAggregate sentiment,
            string? lastContactAgentId,
            string? lastContactAgentName,
            global::System.Collections.Generic.IList<global::ElevenLabs.FrustratedConversationRef>? mostFrustratedConversations)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.LastContactUnixSecs = lastContactUnixSecs;
            this.FirstContactUnixSecs = firstContactUnixSecs;
            this.ConversationCount = conversationCount;
            this.LastContactAgentId = lastContactAgentId;
            this.LastContactConversationId = lastContactConversationId ?? throw new global::System.ArgumentNullException(nameof(lastContactConversationId));
            this.LastContactAgentName = lastContactAgentName;
            this.Sentiment = sentiment ?? throw new global::System.ArgumentNullException(nameof(sentiment));
            this.MostFrustratedConversations = mostFrustratedConversations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationUserResponseModel" /> class.
        /// </summary>
        public ConversationUserResponseModel()
        {
        }

    }
}