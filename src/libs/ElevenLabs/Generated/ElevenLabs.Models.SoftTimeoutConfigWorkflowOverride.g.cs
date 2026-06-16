
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"message":"Hhmmmm...yeah.","timeout_seconds":-1.0,"use_llm_generated_message":false}
    /// </summary>
    public sealed partial class SoftTimeoutConfigWorkflowOverride
    {
        /// <summary>
        /// Time in seconds before showing the predefined message while waiting for LLM response. Set to -1 to disable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_seconds")]
        public double? TimeoutSeconds { get; set; }

        /// <summary>
        /// Message to show when the first soft timeout is reached while waiting for LLM response
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Extra static filler messages for subsequent soft timeouts in the same LLM generation. The first timeout uses `message`. If fewer messages are configured than `max_soft_timeouts_per_generation`, the last configured message is repeated; otherwise a built-in filler is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additional_soft_timeout_messages")]
        public global::System.Collections.Generic.IList<string>? AdditionalSoftTimeoutMessages { get; set; }

        /// <summary>
        /// If enabled, the soft timeout message will be generated dynamically instead of using the static message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_llm_generated_message")]
        public bool? UseLlmGeneratedMessage { get; set; }

        /// <summary>
        /// If enabled, shuffle the order of static soft timeout messages once at the start of each turn. Only applies when use_llm_generated_message is false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("randomize_fillers")]
        public bool? RandomizeFillers { get; set; }

        /// <summary>
        /// Maximum filler messages while waiting for a single LLM response. Fires every timeout_seconds until the LLM streams content or this limit is reached.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_soft_timeouts_per_generation")]
        public int? MaxSoftTimeoutsPerGeneration { get; set; }

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
        /// Initializes a new instance of the <see cref="SoftTimeoutConfigWorkflowOverride" /> class.
        /// </summary>
        /// <param name="timeoutSeconds">
        /// Time in seconds before showing the predefined message while waiting for LLM response. Set to -1 to disable.
        /// </param>
        /// <param name="message">
        /// Message to show when the first soft timeout is reached while waiting for LLM response
        /// </param>
        /// <param name="additionalSoftTimeoutMessages">
        /// Extra static filler messages for subsequent soft timeouts in the same LLM generation. The first timeout uses `message`. If fewer messages are configured than `max_soft_timeouts_per_generation`, the last configured message is repeated; otherwise a built-in filler is used.
        /// </param>
        /// <param name="useLlmGeneratedMessage">
        /// If enabled, the soft timeout message will be generated dynamically instead of using the static message.
        /// </param>
        /// <param name="randomizeFillers">
        /// If enabled, shuffle the order of static soft timeout messages once at the start of each turn. Only applies when use_llm_generated_message is false.
        /// </param>
        /// <param name="maxSoftTimeoutsPerGeneration">
        /// Maximum filler messages while waiting for a single LLM response. Fires every timeout_seconds until the LLM streams content or this limit is reached.
        /// </param>
        /// <param name="llmGeneratedMessagePromptOverride">
        /// Custom prompt for generating the soft timeout filler message when use_llm_generated_message is enabled. Recent conversation context is provided as a separate user message. If not set, the default prompt will be used.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SoftTimeoutConfigWorkflowOverride(
            double? timeoutSeconds,
            string? message,
            global::System.Collections.Generic.IList<string>? additionalSoftTimeoutMessages,
            bool? useLlmGeneratedMessage,
            bool? randomizeFillers,
            int? maxSoftTimeoutsPerGeneration,
            string? llmGeneratedMessagePromptOverride)
        {
            this.TimeoutSeconds = timeoutSeconds;
            this.Message = message;
            this.AdditionalSoftTimeoutMessages = additionalSoftTimeoutMessages;
            this.UseLlmGeneratedMessage = useLlmGeneratedMessage;
            this.RandomizeFillers = randomizeFillers;
            this.MaxSoftTimeoutsPerGeneration = maxSoftTimeoutsPerGeneration;
            this.LlmGeneratedMessagePromptOverride = llmGeneratedMessagePromptOverride;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SoftTimeoutConfigWorkflowOverride" /> class.
        /// </summary>
        public SoftTimeoutConfigWorkflowOverride()
        {
        }

    }
}