
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UserEvaluationAnalysisItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Default Value: user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// LLM to use for this item. If unset, the attaching agent's analysis_llm default is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm")]
        public global::ElevenLabs.Llm? Llm { get; set; }

        /// <summary>
        /// Default Value: evaluation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// The prompt used to evaluate the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_goal_prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConversationGoalPrompt { get; set; }

        /// <summary>
        /// Whether the attaching agent's knowledge base is used when evaluating this criterion.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_knowledge_base")]
        public bool? UseKnowledgeBase { get; set; }

        /// <summary>
        /// How this criterion is scored (binary or numeric_uniform).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scoring")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ScoringJsonConverter))]
        public global::ElevenLabs.Scoring? Scoring { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEvaluationAnalysisItem" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="conversationGoalPrompt">
        /// The prompt used to evaluate the conversation.
        /// </param>
        /// <param name="source">
        /// Default Value: user
        /// </param>
        /// <param name="llm">
        /// LLM to use for this item. If unset, the attaching agent's analysis_llm default is used.
        /// </param>
        /// <param name="kind">
        /// Default Value: evaluation
        /// </param>
        /// <param name="useKnowledgeBase">
        /// Whether the attaching agent's knowledge base is used when evaluating this criterion.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="scoring">
        /// How this criterion is scored (binary or numeric_uniform).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserEvaluationAnalysisItem(
            string name,
            string conversationGoalPrompt,
            string? source,
            global::ElevenLabs.Llm? llm,
            string? kind,
            bool? useKnowledgeBase,
            global::ElevenLabs.Scoring? scoring)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Source = source;
            this.Llm = llm;
            this.Kind = kind;
            this.ConversationGoalPrompt = conversationGoalPrompt ?? throw new global::System.ArgumentNullException(nameof(conversationGoalPrompt));
            this.UseKnowledgeBase = useKnowledgeBase;
            this.Scoring = scoring;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserEvaluationAnalysisItem" /> class.
        /// </summary>
        public UserEvaluationAnalysisItem()
        {
        }

    }
}