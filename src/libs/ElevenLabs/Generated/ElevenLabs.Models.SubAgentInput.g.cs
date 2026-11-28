
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubAgentInput
    {
        /// <summary>
        /// Whether to wait for the reply, or keep going and get it later in the conversation.<br/>
        /// Default Value: immediate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.SubAgentInputExecutionModeJsonConverter))]
        public global::ElevenLabs.SubAgentInputExecutionMode? ExecutionMode { get; set; }

        /// <summary>
        /// How long the agent may run before it's stopped.<br/>
        /// Default Value: 60
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_secs")]
        public int? TimeoutSecs { get; set; }

        /// <summary>
        /// The agent to run. Must be in the same workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// The branch to run. Defaults to the agent's live deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_id")]
        public string? BranchId { get; set; }

        /// <summary>
        /// What the agent is for. Shown to the LLM when it picks an agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Values passed to the agent as dynamic variables.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::ElevenLabs.ObjectJsonSchemaPropertyInput? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubAgentInput" /> class.
        /// </summary>
        /// <param name="agentId">
        /// The agent to run. Must be in the same workspace.
        /// </param>
        /// <param name="description">
        /// What the agent is for. Shown to the LLM when it picks an agent.
        /// </param>
        /// <param name="executionMode">
        /// Whether to wait for the reply, or keep going and get it later in the conversation.<br/>
        /// Default Value: immediate
        /// </param>
        /// <param name="timeoutSecs">
        /// How long the agent may run before it's stopped.<br/>
        /// Default Value: 60
        /// </param>
        /// <param name="branchId">
        /// The branch to run. Defaults to the agent's live deployment.
        /// </param>
        /// <param name="parameters">
        /// Values passed to the agent as dynamic variables.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubAgentInput(
            string agentId,
            string description,
            global::ElevenLabs.SubAgentInputExecutionMode? executionMode,
            int? timeoutSecs,
            string? branchId,
            global::ElevenLabs.ObjectJsonSchemaPropertyInput? parameters)
        {
            this.ExecutionMode = executionMode;
            this.TimeoutSecs = timeoutSecs;
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.BranchId = branchId;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubAgentInput" /> class.
        /// </summary>
        public SubAgentInput()
        {
        }

    }
}