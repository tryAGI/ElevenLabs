
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ExotelColdBlindTransferConfigInput
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_destination")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TransferDestinationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.TransferDestination TransferDestination { get; set; }

        /// <summary>
        /// Default Value: exotel_cold_blind_transfer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExotelColdBlindTransferConfigInput" /> class.
        /// </summary>
        /// <param name="transferDestination"></param>
        /// <param name="type">
        /// Default Value: exotel_cold_blind_transfer
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExotelColdBlindTransferConfigInput(
            global::ElevenLabs.TransferDestination transferDestination,
            string? type)
        {
            this.TransferDestination = transferDestination;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExotelColdBlindTransferConfigInput" /> class.
        /// </summary>
        public ExotelColdBlindTransferConfigInput()
        {
        }

    }
}