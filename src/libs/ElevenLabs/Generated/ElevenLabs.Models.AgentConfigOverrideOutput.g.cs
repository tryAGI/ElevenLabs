
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"first_message":"Hello, how can I help you today?","language":"en","prompt":{"knowledge_base":[],"llm":"gemini-2.0-flash-001","prompt":"You are a helpful assistant that can answer questions about the topic of the conversation.","tool_ids":[]}}
    /// </summary>
    public sealed partial class AgentConfigOverrideOutput
    {
        /// <summary>
        /// If non-empty, the first message the agent will say. If empty, the agent waits for the user to start the discussion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_message")]
        public string? FirstMessage { get; set; }

        /// <summary>
        /// Language of the agent - used for ASR and TTS
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// If non-empty, the message the agent will send when max conversation duration is reached.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_conversation_duration_message")]
        public string? MaxConversationDurationMessage { get; set; }

        /// <summary>
        /// The prompt for the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public global::ElevenLabs.PromptAgentAPIModelOverrideOutput? Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfigOverrideOutput" /> class.
        /// </summary>
        /// <param name="firstMessage">
        /// If non-empty, the first message the agent will say. If empty, the agent waits for the user to start the discussion.
        /// </param>
        /// <param name="language">
        /// Language of the agent - used for ASR and TTS
        /// </param>
        /// <param name="maxConversationDurationMessage">
        /// If non-empty, the message the agent will send when max conversation duration is reached.
        /// </param>
        /// <param name="prompt">
        /// The prompt for the agent
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentConfigOverrideOutput(
            string? firstMessage,
            string? language,
            string? maxConversationDurationMessage,
            global::ElevenLabs.PromptAgentAPIModelOverrideOutput? prompt)
        {
            this.FirstMessage = firstMessage;
            this.Language = language;
            this.MaxConversationDurationMessage = maxConversationDurationMessage;
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfigOverrideOutput" /> class.
        /// </summary>
        public AgentConfigOverrideOutput()
        {
        }
    }
}