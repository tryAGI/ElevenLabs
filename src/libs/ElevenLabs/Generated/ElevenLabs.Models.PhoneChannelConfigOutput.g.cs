
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PhoneChannelConfigOutput
    {
        /// <summary>
        /// Default Value: phone
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel")]
        public string? Channel { get; set; }

        /// <summary>
        /// The phone number to call from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_phone_number_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentPhoneNumberId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode_config")]
        public global::ElevenLabs.PhoneVoiceConfigOutput? ModeConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneChannelConfigOutput" /> class.
        /// </summary>
        /// <param name="agentPhoneNumberId">
        /// The phone number to call from.
        /// </param>
        /// <param name="channel">
        /// Default Value: phone
        /// </param>
        /// <param name="modeConfig"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PhoneChannelConfigOutput(
            string agentPhoneNumberId,
            string? channel,
            global::ElevenLabs.PhoneVoiceConfigOutput? modeConfig)
        {
            this.Channel = channel;
            this.AgentPhoneNumberId = agentPhoneNumberId ?? throw new global::System.ArgumentNullException(nameof(agentPhoneNumberId));
            this.ModeConfig = modeConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneChannelConfigOutput" /> class.
        /// </summary>
        public PhoneChannelConfigOutput()
        {
        }

    }
}