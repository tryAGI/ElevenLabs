
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubmitWhatsAppChannelConfig
    {
        /// <summary>
        /// Default Value: whatsapp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel")]
        public string? Channel { get; set; }

        /// <summary>
        /// The WhatsApp phone number to call or message from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("whatsapp_phone_number_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WhatsappPhoneNumberId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode_config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ModeConfigJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ModeConfig ModeConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitWhatsAppChannelConfig" /> class.
        /// </summary>
        /// <param name="whatsappPhoneNumberId">
        /// The WhatsApp phone number to call or message from.
        /// </param>
        /// <param name="modeConfig"></param>
        /// <param name="channel">
        /// Default Value: whatsapp
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubmitWhatsAppChannelConfig(
            string whatsappPhoneNumberId,
            global::ElevenLabs.ModeConfig modeConfig,
            string? channel)
        {
            this.Channel = channel;
            this.WhatsappPhoneNumberId = whatsappPhoneNumberId ?? throw new global::System.ArgumentNullException(nameof(whatsappPhoneNumberId));
            this.ModeConfig = modeConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitWhatsAppChannelConfig" /> class.
        /// </summary>
        public SubmitWhatsAppChannelConfig()
        {
        }

    }
}