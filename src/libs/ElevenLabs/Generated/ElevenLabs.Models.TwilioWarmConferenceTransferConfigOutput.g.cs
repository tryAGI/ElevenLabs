
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TwilioWarmConferenceTransferConfigOutput
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_destination")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TransferDestination13JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.TransferDestination13 TransferDestination { get; set; }

        /// <summary>
        /// DTMF digits to send after the call connects (e.g. 'ww1234' for an extension). Static or a dynamic variable reference. Use 'w' for a 0.5s pause.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("post_dial_digits")]
        public global::ElevenLabs.PostDialDigitsVariant15? PostDialDigits { get; set; }

        /// <summary>
        /// Default Value: twilio_warm_conference_transfer
        /// </summary>
        /// <default>"twilio_warm_conference_transfer"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "twilio_warm_conference_transfer";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TwilioWarmConferenceTransferConfigOutput" /> class.
        /// </summary>
        /// <param name="transferDestination"></param>
        /// <param name="postDialDigits">
        /// DTMF digits to send after the call connects (e.g. 'ww1234' for an extension). Static or a dynamic variable reference. Use 'w' for a 0.5s pause.
        /// </param>
        /// <param name="type">
        /// Default Value: twilio_warm_conference_transfer
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TwilioWarmConferenceTransferConfigOutput(
            global::ElevenLabs.TransferDestination13 transferDestination,
            global::ElevenLabs.PostDialDigitsVariant15? postDialDigits,
            string type = "twilio_warm_conference_transfer")
        {
            this.TransferDestination = transferDestination;
            this.PostDialDigits = postDialDigits;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TwilioWarmConferenceTransferConfigOutput" /> class.
        /// </summary>
        public TwilioWarmConferenceTransferConfigOutput()
        {
        }

    }
}