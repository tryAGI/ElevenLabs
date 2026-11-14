
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SIPColdReferTransferConfigInput
    {
        /// <summary>
        /// Custom SIP headers to include when transferring the call. Each header can be either a static value or a dynamic variable reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_sip_headers")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.CustomSipHeadersItem2>? CustomSipHeaders { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_destination")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TransferDestination8JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.TransferDestination8 TransferDestination { get; set; }

        /// <summary>
        /// Default Value: sip_cold_refer_transfer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// User-to-User Information (RFC 7433) attached to the REFER. Carries call context such as CRM identifiers or escalation reason across the transfer boundary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uui")]
        public global::ElevenLabs.UUITransferConfig? Uui { get; set; }

        /// <summary>
        /// Play a ringing tone on the original call leg while the REFER completes. Disable if the receiving SBC/contact center should not hear it; the caller then hears silence until the transfer completes.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("play_dialtone")]
        public bool? PlayDialtone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SIPColdReferTransferConfigInput" /> class.
        /// </summary>
        /// <param name="transferDestination"></param>
        /// <param name="customSipHeaders">
        /// Custom SIP headers to include when transferring the call. Each header can be either a static value or a dynamic variable reference.
        /// </param>
        /// <param name="type">
        /// Default Value: sip_cold_refer_transfer
        /// </param>
        /// <param name="uui">
        /// User-to-User Information (RFC 7433) attached to the REFER. Carries call context such as CRM identifiers or escalation reason across the transfer boundary.
        /// </param>
        /// <param name="playDialtone">
        /// Play a ringing tone on the original call leg while the REFER completes. Disable if the receiving SBC/contact center should not hear it; the caller then hears silence until the transfer completes.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SIPColdReferTransferConfigInput(
            global::ElevenLabs.TransferDestination8 transferDestination,
            global::System.Collections.Generic.IList<global::ElevenLabs.CustomSipHeadersItem2>? customSipHeaders,
            string? type,
            global::ElevenLabs.UUITransferConfig? uui,
            bool? playDialtone)
        {
            this.CustomSipHeaders = customSipHeaders;
            this.TransferDestination = transferDestination;
            this.Type = type;
            this.Uui = uui;
            this.PlayDialtone = playDialtone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SIPColdReferTransferConfigInput" /> class.
        /// </summary>
        public SIPColdReferTransferConfigInput()
        {
        }

    }
}