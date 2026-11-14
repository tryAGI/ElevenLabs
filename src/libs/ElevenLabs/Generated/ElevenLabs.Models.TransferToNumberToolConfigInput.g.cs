
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TransferToNumberToolConfigInput
    {
        /// <summary>
        /// Default Value: transfer_to_number
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_tool_type")]
        public string? SystemToolType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.PhoneNumberTransfer> Transfers { get; set; }

        /// <summary>
        /// Per-provider transfer configuration. Mutually exclusive with `transfers`: a tool sets exactly one of the two. When present, the configuration matching the call's telephony provider is offered to the agent and executed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_rules")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.TransferRuleInput>? TransferRules { get; set; }

        /// <summary>
        /// Whether to play a message to the client while they wait for transfer. Defaults to true for backward compatibility.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_client_message")]
        public bool? EnableClientMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferToNumberToolConfigInput" /> class.
        /// </summary>
        /// <param name="transfers"></param>
        /// <param name="systemToolType">
        /// Default Value: transfer_to_number
        /// </param>
        /// <param name="transferRules">
        /// Per-provider transfer configuration. Mutually exclusive with `transfers`: a tool sets exactly one of the two. When present, the configuration matching the call's telephony provider is offered to the agent and executed.
        /// </param>
        /// <param name="enableClientMessage">
        /// Whether to play a message to the client while they wait for transfer. Defaults to true for backward compatibility.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TransferToNumberToolConfigInput(
            global::System.Collections.Generic.IList<global::ElevenLabs.PhoneNumberTransfer> transfers,
            string? systemToolType,
            global::System.Collections.Generic.IList<global::ElevenLabs.TransferRuleInput>? transferRules,
            bool? enableClientMessage)
        {
            this.SystemToolType = systemToolType;
            this.Transfers = transfers ?? throw new global::System.ArgumentNullException(nameof(transfers));
            this.TransferRules = transferRules;
            this.EnableClientMessage = enableClientMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferToNumberToolConfigInput" /> class.
        /// </summary>
        public TransferToNumberToolConfigInput()
        {
        }

    }
}