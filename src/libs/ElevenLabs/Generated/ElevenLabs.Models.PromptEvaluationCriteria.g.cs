
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// An evaluation using the transcript and a prompt for a yes/no achieved answer
    /// </summary>
    public sealed partial class PromptEvaluationCriteria
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
        public string? Name { get; set; }

        /// <summary>
        /// Default Value: prompt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.PromptEvaluationCriteriaTypeJsonConverter))]
        public global::ElevenLabs.PromptEvaluationCriteriaType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_goal_prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConversationGoalPrompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptEvaluationCriteria" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="type">
        /// Default Value: prompt
        /// </param>
        /// <param name="conversationGoalPrompt"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PromptEvaluationCriteria(
            string id,
            string conversationGoalPrompt,
            string? name,
            global::ElevenLabs.PromptEvaluationCriteriaType? type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ConversationGoalPrompt = conversationGoalPrompt ?? throw new global::System.ArgumentNullException(nameof(conversationGoalPrompt));
            this.Name = name;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptEvaluationCriteria" /> class.
        /// </summary>
        public PromptEvaluationCriteria()
        {
        }
    }
}