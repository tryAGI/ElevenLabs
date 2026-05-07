
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_topic_id")]
        public string? ParentTopicId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x_2d")]
        public double? X2d { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("y_2d")]
        public double? Y2d { get; set; }

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
        /// <param name="parentTopicId"></param>
        /// <param name="x2d"></param>
        /// <param name="y2d"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTopicResponseModel(
            string topicId,
            string label,
            string description,
            int conversationCount,
            string? parentTopicId,
            double? x2d,
            double? y2d)
        {
            this.TopicId = topicId ?? throw new global::System.ArgumentNullException(nameof(topicId));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.ConversationCount = conversationCount;
            this.ParentTopicId = parentTopicId;
            this.X2d = x2d;
            this.Y2d = y2d;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTopicResponseModel" /> class.
        /// </summary>
        public AgentTopicResponseModel()
        {
        }
    }
}