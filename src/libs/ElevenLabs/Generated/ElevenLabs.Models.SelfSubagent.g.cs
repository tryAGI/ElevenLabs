
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The agent itself, run on the same branch with none of the conversation.
    /// </summary>
    public sealed partial class SelfSubagent
    {
        /// <summary>
        /// Whether to wait for the reply, or keep going and get it later in the conversation.<br/>
        /// Default Value: immediate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.SelfSubagentExecutionModeJsonConverter))]
        public global::ElevenLabs.SelfSubagentExecutionMode? ExecutionMode { get; set; }

        /// <summary>
        /// How long the agent may run before it's stopped.<br/>
        /// Default Value: 60
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_secs")]
        public int? TimeoutSecs { get; set; }

        /// <summary>
        /// When the agent should hand work to itself. Defaults to a built-in description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SelfSubagent" /> class.
        /// </summary>
        /// <param name="executionMode">
        /// Whether to wait for the reply, or keep going and get it later in the conversation.<br/>
        /// Default Value: immediate
        /// </param>
        /// <param name="timeoutSecs">
        /// How long the agent may run before it's stopped.<br/>
        /// Default Value: 60
        /// </param>
        /// <param name="description">
        /// When the agent should hand work to itself. Defaults to a built-in description.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SelfSubagent(
            global::ElevenLabs.SelfSubagentExecutionMode? executionMode,
            int? timeoutSecs,
            string? description)
        {
            this.ExecutionMode = executionMode;
            this.TimeoutSecs = timeoutSecs;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SelfSubagent" /> class.
        /// </summary>
        public SelfSubagent()
        {
        }

    }
}