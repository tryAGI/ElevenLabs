
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SIPColdConferenceTransferConfigOutput
    {
        /// <summary>
        /// Custom SIP headers to include when transferring the call. Each header can be either a static value or a dynamic variable reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_sip_headers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.CustomSipHeadersItem7> CustomSipHeaders { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_destination")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TransferDestination13JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.TransferDestination13 TransferDestination { get; set; }

        /// <summary>
        /// Default Value: sip_cold_conference_transfer
        /// </summary>
        /// <default>"sip_cold_conference_transfer"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "sip_cold_conference_transfer";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SIPColdConferenceTransferConfigOutput" /> class.
        /// </summary>
        /// <param name="customSipHeaders">
        /// Custom SIP headers to include when transferring the call. Each header can be either a static value or a dynamic variable reference.
        /// </param>
        /// <param name="transferDestination"></param>
        /// <param name="type">
        /// Default Value: sip_cold_conference_transfer
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SIPColdConferenceTransferConfigOutput(
            global::System.Collections.Generic.IList<global::ElevenLabs.CustomSipHeadersItem7> customSipHeaders,
            global::ElevenLabs.TransferDestination13 transferDestination,
            string type = "sip_cold_conference_transfer")
        {
            this.CustomSipHeaders = customSipHeaders ?? throw new global::System.ArgumentNullException(nameof(customSipHeaders));
            this.TransferDestination = transferDestination;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SIPColdConferenceTransferConfigOutput" /> class.
        /// </summary>
        public SIPColdConferenceTransferConfigOutput()
        {
        }

    }
}