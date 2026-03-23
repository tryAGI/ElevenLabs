
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CriterionItemRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_goal_prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConversationGoalPrompt { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_knowledge_base")]
        public bool? UseKnowledgeBase { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CriterionItemRequest" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="conversationGoalPrompt"></param>
        /// <param name="useKnowledgeBase">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CriterionItemRequest(
            string id,
            string name,
            string conversationGoalPrompt,
            bool? useKnowledgeBase)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ConversationGoalPrompt = conversationGoalPrompt ?? throw new global::System.ArgumentNullException(nameof(conversationGoalPrompt));
            this.UseKnowledgeBase = useKnowledgeBase;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CriterionItemRequest" /> class.
        /// </summary>
        public CriterionItemRequest()
        {
        }
    }
}