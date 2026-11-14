
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ExotelWarmTransferConfigOutput
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_destination")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TransferDestination4JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.TransferDestination4 TransferDestination { get; set; }

        /// <summary>
        /// Default Value: exotel_warm_transfer
        /// </summary>
        /// <default>"exotel_warm_transfer"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "exotel_warm_transfer";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExotelWarmTransferConfigOutput" /> class.
        /// </summary>
        /// <param name="transferDestination"></param>
        /// <param name="type">
        /// Default Value: exotel_warm_transfer
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExotelWarmTransferConfigOutput(
            global::ElevenLabs.TransferDestination4 transferDestination,
            string type = "exotel_warm_transfer")
        {
            this.TransferDestination = transferDestination;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExotelWarmTransferConfigOutput" /> class.
        /// </summary>
        public ExotelWarmTransferConfigOutput()
        {
        }

    }
}