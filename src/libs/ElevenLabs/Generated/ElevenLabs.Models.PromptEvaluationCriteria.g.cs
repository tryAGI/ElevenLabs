
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// An evaluation using the transcript and a prompt for a yes/no achieved answer
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
        /// LLM model to use for this evaluation criteria. If not set, uses agent's analysis_llm default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm")]
        public global::ElevenLabs.Llm? Llm { get; set; }

        /// <summary>
        /// How this criterion is scored. 'binary' resolves to success/failure/unknown. 'numeric_uniform' returns a number on the [0, max_score] scale which is normalized into the aggregate conversation success percentage.<br/>
        /// Default Value: binary
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scoring_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.CriteriaScoringModeJsonConverter))]
        public global::ElevenLabs.CriteriaScoringMode? ScoringMode { get; set; }

        /// <summary>
        /// Maximum value of the numeric score scale (minimum is always 0). Only used when scoring_mode is 'numeric_uniform'.<br/>
        /// Default Value: 100
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_score")]
        public int? MaxScore { get; set; }

        /// <summary>
        /// Optional free-text instructions describing how to assign values on the numeric scale. Only used when scoring_mode is 'numeric_uniform'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_instructions")]
        public string? ScoreInstructions { get; set; }

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
        /// <param name="llm">
        /// LLM model to use for this evaluation criteria. If not set, uses agent's analysis_llm default.
        /// </param>
        /// <param name="scoringMode">
        /// How this criterion is scored. 'binary' resolves to success/failure/unknown. 'numeric_uniform' returns a number on the [0, max_score] scale which is normalized into the aggregate conversation success percentage.<br/>
        /// Default Value: binary
        /// </param>
        /// <param name="maxScore">
        /// Maximum value of the numeric score scale (minimum is always 0). Only used when scoring_mode is 'numeric_uniform'.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="scoreInstructions">
        /// Optional free-text instructions describing how to assign values on the numeric scale. Only used when scoring_mode is 'numeric_uniform'.
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
            global::ElevenLabs.AnalysisScope? scope,
            global::ElevenLabs.Llm? llm,
            global::ElevenLabs.CriteriaScoringMode? scoringMode,
            int? maxScore,
            string? scoreInstructions)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.ConversationGoalPrompt = conversationGoalPrompt ?? throw new global::System.ArgumentNullException(nameof(conversationGoalPrompt));
            this.UseKnowledgeBase = useKnowledgeBase;
            this.Scope = scope;
            this.Llm = llm;
            this.ScoringMode = scoringMode;
            this.MaxScore = maxScore;
            this.ScoreInstructions = scoreInstructions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptEvaluationCriteria" /> class.
        /// </summary>
        public PromptEvaluationCriteria()
        {
        }

    }
}