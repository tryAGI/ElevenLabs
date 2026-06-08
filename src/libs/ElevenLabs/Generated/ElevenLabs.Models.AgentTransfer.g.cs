
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentTransfer
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Condition { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delay_ms")]
        public int? DelayMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_message")]
        public string? TransferMessage { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_transferred_agent_first_message")]
        public bool? EnableTransferredAgentFirstMessage { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_workflow_node_transfer")]
        public bool? IsWorkflowNodeTransfer { get; set; }

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
        /// Initializes a new instance of the <see cref="AgentTransfer" /> class.
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="agentId"></param>
        /// <param name="nodeId"></param>
        /// <param name="delayMs">
        /// Default Value: 0
        /// </param>
        /// <param name="transferMessage"></param>
        /// <param name="enableTransferredAgentFirstMessage">
        /// Default Value: false
        /// </param>
        /// <param name="isWorkflowNodeTransfer">
        /// Default Value: false
        /// </param>
        /// <param name="preserveClientTtsOverrides">
        /// Defines whether TTS client overrides should be carried over to the transferred agent.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTransfer(
            string condition,
            string? agentId,
            string? nodeId,
            int? delayMs,
            string? transferMessage,
            bool? enableTransferredAgentFirstMessage,
            bool? isWorkflowNodeTransfer,
            bool? preserveClientTtsOverrides)
        {
            this.AgentId = agentId;
            this.NodeId = nodeId;
            this.Condition = condition ?? throw new global::System.ArgumentNullException(nameof(condition));
            this.DelayMs = delayMs;
            this.TransferMessage = transferMessage;
            this.EnableTransferredAgentFirstMessage = enableTransferredAgentFirstMessage;
            this.IsWorkflowNodeTransfer = isWorkflowNodeTransfer;
            this.PreserveClientTtsOverrides = preserveClientTtsOverrides;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTransfer" /> class.
        /// </summary>
        public AgentTransfer()
        {
        }

    }
}