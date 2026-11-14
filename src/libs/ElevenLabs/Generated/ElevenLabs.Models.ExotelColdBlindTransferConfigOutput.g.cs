
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ExotelColdBlindTransferConfigOutput
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_destination")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TransferDestination2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.TransferDestination2 TransferDestination { get; set; }

        /// <summary>
        /// Default Value: exotel_cold_blind_transfer
        /// </summary>
        /// <default>"exotel_cold_blind_transfer"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "exotel_cold_blind_transfer";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExotelColdBlindTransferConfigOutput" /> class.
        /// </summary>
        /// <param name="transferDestination"></param>
        /// <param name="type">
        /// Default Value: exotel_cold_blind_transfer
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExotelColdBlindTransferConfigOutput(
            global::ElevenLabs.TransferDestination2 transferDestination,
            string type = "exotel_cold_blind_transfer")
        {
            this.TransferDestination = transferDestination;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExotelColdBlindTransferConfigOutput" /> class.
        /// </summary>
        public ExotelColdBlindTransferConfigOutput()
        {
        }

    }
}