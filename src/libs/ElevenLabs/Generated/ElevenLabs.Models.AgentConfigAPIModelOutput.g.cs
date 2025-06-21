
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentConfigAPIModelOutput
    {
        /// <summary>
        /// If non-empty, the first message the agent will say. If empty, the agent waits for the user to start the discussion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_message")]
        public string? FirstMessage { get; set; }

        /// <summary>
        /// Language of the agent - used for ASR and TTS<br/>
        /// Default Value: en
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variables")]
        public global::ElevenLabs.DynamicVariablesConfig? DynamicVariables { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public global::ElevenLabs.PromptAgentAPIModelOutput? Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfigAPIModelOutput" /> class.
        /// </summary>
        /// <param name="firstMessage">
        /// If non-empty, the first message the agent will say. If empty, the agent waits for the user to start the discussion.
        /// </param>
        /// <param name="language">
        /// Language of the agent - used for ASR and TTS<br/>
        /// Default Value: en
        /// </param>
        /// <param name="dynamicVariables"></param>
        /// <param name="prompt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentConfigAPIModelOutput(
            string? firstMessage,
            string? language,
            global::ElevenLabs.DynamicVariablesConfig? dynamicVariables,
            global::ElevenLabs.PromptAgentAPIModelOutput? prompt)
        {
            this.FirstMessage = firstMessage;
            this.Language = language;
            this.DynamicVariables = dynamicVariables;
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfigAPIModelOutput" /> class.
        /// </summary>
        public AgentConfigAPIModelOutput()
        {
        }
    }
}