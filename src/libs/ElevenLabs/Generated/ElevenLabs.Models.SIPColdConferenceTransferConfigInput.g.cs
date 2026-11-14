
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SIPColdConferenceTransferConfigInput
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_destination")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TransferDestination6JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.TransferDestination6 TransferDestination { get; set; }

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
        /// <param name="type">
        /// Default Value: sip_cold_conference_transfer
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SIPColdConferenceTransferConfigInput(
            global::ElevenLabs.TransferDestination6 transferDestination,
            string? type)
        {
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