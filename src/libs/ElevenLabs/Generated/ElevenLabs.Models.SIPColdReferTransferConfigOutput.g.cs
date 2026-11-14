
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SIPColdReferTransferConfigOutput
    {
        /// <summary>
        /// Custom SIP headers to include when transferring the call. Each header can be either a static value or a dynamic variable reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_sip_headers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.CustomSipHeadersItem3> CustomSipHeaders { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_destination")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TransferDestination9JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.TransferDestination9 TransferDestination { get; set; }

        /// <summary>
        /// Default Value: sip_cold_refer_transfer
        /// </summary>
        /// <default>"sip_cold_refer_transfer"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "sip_cold_refer_transfer";

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool PlayDialtone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SIPColdReferTransferConfigOutput" /> class.
        /// </summary>
        /// <param name="customSipHeaders">
        /// Custom SIP headers to include when transferring the call. Each header can be either a static value or a dynamic variable reference.
        /// </param>
        /// <param name="transferDestination"></param>
        /// <param name="playDialtone">
        /// Play a ringing tone on the original call leg while the REFER completes. Disable if the receiving SBC/contact center should not hear it; the caller then hears silence until the transfer completes.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="uui">
        /// User-to-User Information (RFC 7433) attached to the REFER. Carries call context such as CRM identifiers or escalation reason across the transfer boundary.
        /// </param>
        /// <param name="type">
        /// Default Value: sip_cold_refer_transfer
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SIPColdReferTransferConfigOutput(
            global::System.Collections.Generic.IList<global::ElevenLabs.CustomSipHeadersItem3> customSipHeaders,
            global::ElevenLabs.TransferDestination9 transferDestination,
            bool playDialtone,
            global::ElevenLabs.UUITransferConfig? uui,
            string type = "sip_cold_refer_transfer")
        {
            this.CustomSipHeaders = customSipHeaders ?? throw new global::System.ArgumentNullException(nameof(customSipHeaders));
            this.TransferDestination = transferDestination;
            this.Type = type;
            this.Uui = uui;
            this.PlayDialtone = playDialtone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SIPColdReferTransferConfigOutput" /> class.
        /// </summary>
        public SIPColdReferTransferConfigOutput()
        {
        }

    }
}