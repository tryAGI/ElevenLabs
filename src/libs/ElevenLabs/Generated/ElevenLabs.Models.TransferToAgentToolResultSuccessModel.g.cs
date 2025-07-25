
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TransferToAgentToolResultSuccessModel
    {
        /// <summary>
        /// Default Value: transfer_to_agent_success
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TransferToAgentToolResultSuccessModelResultTypeJsonConverter))]
        public global::ElevenLabs.TransferToAgentToolResultSuccessModelResultType? ResultType { get; set; }

        /// <summary>
        /// Default Value: success
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TransferToAgentToolResultSuccessModelStatusJsonConverter))]
        public global::ElevenLabs.TransferToAgentToolResultSuccessModelStatus? Status { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferToAgentToolResultSuccessModel" /> class.
        /// </summary>
        /// <param name="resultType">
        /// Default Value: transfer_to_agent_success
        /// </param>
        /// <param name="status">
        /// Default Value: success
        /// </param>
        /// <param name="fromAgent"></param>
        /// <param name="toAgent"></param>
        /// <param name="condition"></param>
        /// <param name="delayMs">
        /// Default Value: 0
        /// </param>
        /// <param name="transferMessage"></param>
        /// <param name="enableTransferredAgentFirstMessage">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TransferToAgentToolResultSuccessModel(
            string fromAgent,
            string toAgent,
            string condition,
            global::ElevenLabs.TransferToAgentToolResultSuccessModelResultType? resultType,
            global::ElevenLabs.TransferToAgentToolResultSuccessModelStatus? status,
            int? delayMs,
            string? transferMessage,
            bool? enableTransferredAgentFirstMessage)
        {
            this.FromAgent = fromAgent ?? throw new global::System.ArgumentNullException(nameof(fromAgent));
            this.ToAgent = toAgent ?? throw new global::System.ArgumentNullException(nameof(toAgent));
            this.Condition = condition ?? throw new global::System.ArgumentNullException(nameof(condition));
            this.ResultType = resultType;
            this.Status = status;
            this.DelayMs = delayMs;
            this.TransferMessage = transferMessage;
            this.EnableTransferredAgentFirstMessage = enableTransferredAgentFirstMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferToAgentToolResultSuccessModel" /> class.
        /// </summary>
        public TransferToAgentToolResultSuccessModel()
        {
        }
    }
}