
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SIPColdConferenceTransferConfigInput
    {
        /// <summary>
        /// Custom SIP headers to include when transferring the call. Each header can be either a static value or a dynamic variable reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_sip_headers")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.CustomSipHeadersItem6>? CustomSipHeaders { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_destination")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TransferDestination12JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.TransferDestination12 TransferDestination { get; set; }

        /// <summary>
        /// Default Value: sip_cold_conference_transfer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SIPColdConferenceTransferConfigInput" /> class.
        /// </summary>
        /// <param name="transferDestination"></param>
        /// <param name="customSipHeaders">
        /// Custom SIP headers to include when transferring the call. Each header can be either a static value or a dynamic variable reference.
        /// </param>
        /// <param name="type">
        /// Default Value: sip_cold_conference_transfer
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SIPColdConferenceTransferConfigInput(
            global::ElevenLabs.TransferDestination12 transferDestination,
            global::System.Collections.Generic.IList<global::ElevenLabs.CustomSipHeadersItem6>? customSipHeaders,
            string? type)
        {
            this.CustomSipHeaders = customSipHeaders;
            this.TransferDestination = transferDestination;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SIPColdConferenceTransferConfigInput" /> class.
        /// </summary>
        public SIPColdConferenceTransferConfigInput()
        {
        }

    }
}