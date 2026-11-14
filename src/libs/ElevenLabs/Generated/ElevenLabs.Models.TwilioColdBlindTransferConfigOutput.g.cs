
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TwilioColdBlindTransferConfigOutput
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_destination")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TransferDestination11JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.TransferDestination11 TransferDestination { get; set; }

        /// <summary>
        /// DTMF digits to send after the call connects (e.g. 'ww1234' for an extension). Static or a dynamic variable reference. Use 'w' for a 0.5s pause.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("post_dial_digits")]
        public global::ElevenLabs.PostDialDigitsVariant13? PostDialDigits { get; set; }

        /// <summary>
        /// Default Value: twilio_cold_blind_transfer
        /// </summary>
        /// <default>"twilio_cold_blind_transfer"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "twilio_cold_blind_transfer";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TwilioColdBlindTransferConfigOutput" /> class.
        /// </summary>
        /// <param name="transferDestination"></param>
        /// <param name="postDialDigits">
        /// DTMF digits to send after the call connects (e.g. 'ww1234' for an extension). Static or a dynamic variable reference. Use 'w' for a 0.5s pause.
        /// </param>
        /// <param name="type">
        /// Default Value: twilio_cold_blind_transfer
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TwilioColdBlindTransferConfigOutput(
            global::ElevenLabs.TransferDestination11 transferDestination,
            global::ElevenLabs.PostDialDigitsVariant13? postDialDigits,
            string type = "twilio_cold_blind_transfer")
        {
            this.TransferDestination = transferDestination;
            this.PostDialDigits = postDialDigits;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TwilioColdBlindTransferConfigOutput" /> class.
        /// </summary>
        public TwilioColdBlindTransferConfigOutput()
        {
        }

    }
}