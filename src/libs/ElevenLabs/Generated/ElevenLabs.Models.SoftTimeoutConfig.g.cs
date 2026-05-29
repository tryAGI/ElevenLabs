
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Configuration for soft timeout functionality during LLM response generation.<br/>
    /// Example: {"message":"Hhmmmm...yeah.","timeout_seconds":2.0,"use_llm_generated_message":false}
    /// </summary>
    public sealed partial class SoftTimeoutConfig
    {
        /// <summary>
        /// Time in seconds before showing the predefined message while waiting for LLM response. Set to -1 to disable.<br/>
        /// Default Value: -1F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_seconds")]
        public double? TimeoutSeconds { get; set; }

        /// <summary>
        /// Message to show when soft timeout is reached while waiting for LLM response<br/>
        /// Default Value: Hhmmmm...yeah.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// If enabled, the soft timeout message will be generated dynamically instead of using the static message.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_llm_generated_message")]
        public bool? UseLlmGeneratedMessage { get; set; }

        /// <summary>
        /// Custom prompt for generating the soft timeout filler message when use_llm_generated_message is enabled. Recent conversation context is provided as a separate user message. If not set, the default prompt will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_generated_message_prompt_override")]
        public string? LlmGeneratedMessagePromptOverride { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SoftTimeoutConfig" /> class.
        /// </summary>
        /// <param name="timeoutSeconds">
        /// Time in seconds before showing the predefined message while waiting for LLM response. Set to -1 to disable.<br/>
        /// Default Value: -1F
        /// </param>
        /// <param name="message">
        /// Message to show when soft timeout is reached while waiting for LLM response<br/>
        /// Default Value: Hhmmmm...yeah.
        /// </param>
        /// <param name="useLlmGeneratedMessage">
        /// If enabled, the soft timeout message will be generated dynamically instead of using the static message.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="llmGeneratedMessagePromptOverride">
        /// Custom prompt for generating the soft timeout filler message when use_llm_generated_message is enabled. Recent conversation context is provided as a separate user message. If not set, the default prompt will be used.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SoftTimeoutConfig(
            double? timeoutSeconds,
            string? message,
            bool? useLlmGeneratedMessage,
            string? llmGeneratedMessagePromptOverride)
        {
            this.TimeoutSeconds = timeoutSeconds;
            this.Message = message;
            this.UseLlmGeneratedMessage = useLlmGeneratedMessage;
            this.LlmGeneratedMessagePromptOverride = llmGeneratedMessagePromptOverride;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SoftTimeoutConfig" /> class.
        /// </summary>
        public SoftTimeoutConfig()
        {
        }

    }
}