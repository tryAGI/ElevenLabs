
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Single custom guardrail configuration
    /// </summary>
    public sealed partial class CustomGuardrailConfig
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_enabled")]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// User-facing name for this guardrail
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Instruction describing what to block, e.g. 'don't talk about politics'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Default Value: streaming
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.GuardrailExecutionModeJsonConverter))]
        public global::ElevenLabs.GuardrailExecutionMode? ExecutionMode { get; set; }

        /// <summary>
        /// LLM model to use for custom guardrail evaluation<br/>
        /// Default Value: gemini-2.5-flash-lite
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.CustomGuardrailConfigModelJsonConverter))]
        public global::ElevenLabs.CustomGuardrailConfigModel? Model { get; set; }

        /// <summary>
        /// How many recent customer messages to include in the guardrail's history, plus the agent replies that follow them (and tool calls and results when history_include_tool_calls is enabled). Only customer messages count toward the limit. 0 (default) shows none; 1 shows the customer's latest message onward. When &gt; 0, the guardrail prompt can refer to this history as &lt;conversation_history&gt;; the reply under evaluation appears as &lt;agent_message&gt; and may repeat at the end of the history.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("history_message_count")]
        public int? HistoryMessageCount { get; set; }

        /// <summary>
        /// When history is on (history_message_count &gt; 0), also render interleaved tool calls and results in the window. Off by default: history shows only customer and agent text. Tool payloads can be large, so enabling this increases evaluation token cost.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("history_include_tool_calls")]
        public bool? HistoryIncludeToolCalls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger_action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TriggerAction3JsonConverter))]
        public global::ElevenLabs.TriggerAction3? TriggerAction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomGuardrailConfig" /> class.
        /// </summary>
        /// <param name="name">
        /// User-facing name for this guardrail
        /// </param>
        /// <param name="prompt">
        /// Instruction describing what to block, e.g. 'don't talk about politics'
        /// </param>
        /// <param name="isEnabled">
        /// Default Value: false
        /// </param>
        /// <param name="executionMode">
        /// Default Value: streaming
        /// </param>
        /// <param name="model">
        /// LLM model to use for custom guardrail evaluation<br/>
        /// Default Value: gemini-2.5-flash-lite
        /// </param>
        /// <param name="historyMessageCount">
        /// How many recent customer messages to include in the guardrail's history, plus the agent replies that follow them (and tool calls and results when history_include_tool_calls is enabled). Only customer messages count toward the limit. 0 (default) shows none; 1 shows the customer's latest message onward. When &gt; 0, the guardrail prompt can refer to this history as &lt;conversation_history&gt;; the reply under evaluation appears as &lt;agent_message&gt; and may repeat at the end of the history.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="historyIncludeToolCalls">
        /// When history is on (history_message_count &gt; 0), also render interleaved tool calls and results in the window. Off by default: history shows only customer and agent text. Tool payloads can be large, so enabling this increases evaluation token cost.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="triggerAction"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomGuardrailConfig(
            string name,
            string prompt,
            bool? isEnabled,
            global::ElevenLabs.GuardrailExecutionMode? executionMode,
            global::ElevenLabs.CustomGuardrailConfigModel? model,
            int? historyMessageCount,
            bool? historyIncludeToolCalls,
            global::ElevenLabs.TriggerAction3? triggerAction)
        {
            this.IsEnabled = isEnabled;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.ExecutionMode = executionMode;
            this.Model = model;
            this.HistoryMessageCount = historyMessageCount;
            this.HistoryIncludeToolCalls = historyIncludeToolCalls;
            this.TriggerAction = triggerAction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomGuardrailConfig" /> class.
        /// </summary>
        public CustomGuardrailConfig()
        {
        }

    }
}