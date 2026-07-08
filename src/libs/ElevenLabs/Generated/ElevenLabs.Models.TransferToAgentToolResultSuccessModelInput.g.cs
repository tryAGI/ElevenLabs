
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TransferToAgentToolResultSuccessModelInput
    {
        /// <summary>
        /// Default Value: transfer_to_agent_success
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_type")]
        public string? ResultType { get; set; }

        /// <summary>
        /// Default Value: success
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_agent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FromAgent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to_agent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToAgent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to_node")]
        public string? ToNode { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_info")]
        public global::ElevenLabs.BranchInfoVariant1? BranchInfo { get; set; }

        /// <summary>
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
        /// Initializes a new instance of the <see cref="TransferToAgentToolResultSuccessModelInput" /> class.
        /// </summary>
        /// <param name="fromAgent"></param>
        /// <param name="toAgent"></param>
        /// <param name="condition"></param>
        /// <param name="resultType">
        /// Default Value: transfer_to_agent_success
        /// </param>
        /// <param name="status">
        /// Default Value: success
        /// </param>
        /// <param name="toNode"></param>
        /// <param name="delayMs">
        /// Default Value: 0
        /// </param>
        /// <param name="transferMessage"></param>
        /// <param name="enableTransferredAgentFirstMessage">
        /// Default Value: false
        /// </param>
        /// <param name="branchInfo"></param>
        /// <param name="preserveClientTtsOverrides">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TransferToAgentToolResultSuccessModelInput(
            string fromAgent,
            string toAgent,
            string condition,
            string? resultType,
            string? status,
            string? toNode,
            int? delayMs,
            string? transferMessage,
            bool? enableTransferredAgentFirstMessage,
            global::ElevenLabs.BranchInfoVariant1? branchInfo,
            bool? preserveClientTtsOverrides)
        {
            this.ResultType = resultType;
            this.Status = status;
            this.FromAgent = fromAgent ?? throw new global::System.ArgumentNullException(nameof(fromAgent));
            this.ToAgent = toAgent ?? throw new global::System.ArgumentNullException(nameof(toAgent));
            this.ToNode = toNode;
            this.Condition = condition ?? throw new global::System.ArgumentNullException(nameof(condition));
            this.DelayMs = delayMs;
            this.TransferMessage = transferMessage;
            this.EnableTransferredAgentFirstMessage = enableTransferredAgentFirstMessage;
            this.BranchInfo = branchInfo;
            this.PreserveClientTtsOverrides = preserveClientTtsOverrides;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferToAgentToolResultSuccessModelInput" /> class.
        /// </summary>
        public TransferToAgentToolResultSuccessModelInput()
        {
        }

    }
}