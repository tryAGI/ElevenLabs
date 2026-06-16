
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowStandaloneAgentNodeModelInput
    {
        /// <summary>
        /// Default Value: standalone_agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Position of the node in the workflow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        public global::ElevenLabs.PositionInput? Position { get; set; }

        /// <summary>
        /// The ids of outgoing edges in the order they should be evaluated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edge_order")]
        public global::System.Collections.Generic.IList<string>? EdgeOrder { get; set; }

        /// <summary>
        /// The ID of the agent to transfer the conversation to. None means transfer within the current agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// Optional target node ID in the destination agent's workflow. When set, the transfer starts at this node instead of the default entry node.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// Artificial delay in milliseconds applied before transferring the conversation.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delay_ms")]
        public int? DelayMs { get; set; }

        /// <summary>
        /// Optional message sent to the user before the transfer is initiated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_message")]
        public string? TransferMessage { get; set; }

        /// <summary>
        /// Whether to enable the transferred agent to send its configured first message after the transfer.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_transferred_agent_first_message")]
        public bool? EnableTransferredAgentFirstMessage { get; set; }

        /// <summary>
        /// Defines whether TTS client overrides should be carried over to the transferred agent.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preserve_client_tts_overrides")]
        public bool? PreserveClientTtsOverrides { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowStandaloneAgentNodeModelInput" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: standalone_agent
        /// </param>
        /// <param name="position">
        /// Position of the node in the workflow.
        /// </param>
        /// <param name="edgeOrder">
        /// The ids of outgoing edges in the order they should be evaluated.
        /// </param>
        /// <param name="agentId">
        /// The ID of the agent to transfer the conversation to. None means transfer within the current agent.
        /// </param>
        /// <param name="nodeId">
        /// Optional target node ID in the destination agent's workflow. When set, the transfer starts at this node instead of the default entry node.
        /// </param>
        /// <param name="delayMs">
        /// Artificial delay in milliseconds applied before transferring the conversation.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="transferMessage">
        /// Optional message sent to the user before the transfer is initiated.
        /// </param>
        /// <param name="enableTransferredAgentFirstMessage">
        /// Whether to enable the transferred agent to send its configured first message after the transfer.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="preserveClientTtsOverrides">
        /// Defines whether TTS client overrides should be carried over to the transferred agent.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowStandaloneAgentNodeModelInput(
            string? type,
            global::ElevenLabs.PositionInput? position,
            global::System.Collections.Generic.IList<string>? edgeOrder,
            string? agentId,
            string? nodeId,
            int? delayMs,
            string? transferMessage,
            bool? enableTransferredAgentFirstMessage,
            bool? preserveClientTtsOverrides)
        {
            this.Type = type;
            this.Position = position;
            this.EdgeOrder = edgeOrder;
            this.AgentId = agentId;
            this.NodeId = nodeId;
            this.DelayMs = delayMs;
            this.TransferMessage = transferMessage;
            this.EnableTransferredAgentFirstMessage = enableTransferredAgentFirstMessage;
            this.PreserveClientTtsOverrides = preserveClientTtsOverrides;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowStandaloneAgentNodeModelInput" /> class.
        /// </summary>
        public WorkflowStandaloneAgentNodeModelInput()
        {
        }

    }
}