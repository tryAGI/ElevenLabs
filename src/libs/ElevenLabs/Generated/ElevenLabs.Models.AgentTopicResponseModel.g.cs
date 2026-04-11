
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentTopicResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topic_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TopicId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ConversationCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTopicResponseModel" /> class.
        /// </summary>
        /// <param name="topicId"></param>
        /// <param name="label"></param>
        /// <param name="description"></param>
        /// <param name="conversationCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTopicResponseModel(
            string topicId,
            string label,
            string description,
            int conversationCount)
        {
            this.TopicId = topicId ?? throw new global::System.ArgumentNullException(nameof(topicId));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.ConversationCount = conversationCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTopicResponseModel" /> class.
        /// </summary>
        public AgentTopicResponseModel()
        {
        }
    }
}