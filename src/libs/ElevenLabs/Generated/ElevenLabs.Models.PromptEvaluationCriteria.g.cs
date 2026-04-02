
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// An evaluation using the transcript and a prompt for a yes/no achieved answer<br/>
    /// Example: {"conversation_goal_prompt":"You are a helpful assistant that can answer questions about the topic of the conversation.","id":"1234567890","name":"Customer satisfaction check","scope":"conversation","use_knowledge_base":false}
    /// </summary>
    public sealed partial class PromptEvaluationCriteria
    {
        /// <summary>
        /// The unique identifier for the evaluation criteria
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
        /// The type of evaluation criteria<br/>
        /// Default Value: prompt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The prompt that the agent should use to evaluate the conversation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_goal_prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConversationGoalPrompt { get; set; }

        /// <summary>
        /// When evaluating the prompt, should the agent's knowledge base be used.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_knowledge_base")]
        public bool? UseKnowledgeBase { get; set; }

        /// <summary>
        /// The scope of transcript context used when evaluating this criterion. 'conversation' uses the full transcript; 'agent' uses only the portion where the defining agent was active.<br/>
        /// Default Value: conversation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AnalysisScopeJsonConverter))]
        public global::ElevenLabs.AnalysisScope? Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptEvaluationCriteria" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for the evaluation criteria
        /// </param>
        /// <param name="name"></param>
        /// <param name="conversationGoalPrompt">
        /// The prompt that the agent should use to evaluate the conversation
        /// </param>
        /// <param name="type">
        /// The type of evaluation criteria<br/>
        /// Default Value: prompt
        /// </param>
        /// <param name="useKnowledgeBase">
        /// When evaluating the prompt, should the agent's knowledge base be used.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="scope">
        /// The scope of transcript context used when evaluating this criterion. 'conversation' uses the full transcript; 'agent' uses only the portion where the defining agent was active.<br/>
        /// Default Value: conversation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptEvaluationCriteria(
            string id,
            string name,
            string conversationGoalPrompt,
            string? type,
            bool? useKnowledgeBase,
            global::ElevenLabs.AnalysisScope? scope)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.ConversationGoalPrompt = conversationGoalPrompt ?? throw new global::System.ArgumentNullException(nameof(conversationGoalPrompt));
            this.UseKnowledgeBase = useKnowledgeBase;
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptEvaluationCriteria" /> class.
        /// </summary>
        public PromptEvaluationCriteria()
        {
        }
    }
}