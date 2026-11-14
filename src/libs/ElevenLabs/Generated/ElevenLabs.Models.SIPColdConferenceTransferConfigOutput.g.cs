
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SIPColdConferenceTransferConfigOutput
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_destination")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TransferDestination7JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.TransferDestination7 TransferDestination { get; set; }

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
        /// <param name="transferDestination"></param>
        /// <param name="type">
        /// Default Value: sip_cold_conference_transfer
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SIPColdConferenceTransferConfigOutput(
            global::ElevenLabs.TransferDestination7 transferDestination,
            string type = "sip_cold_conference_transfer")
        {
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