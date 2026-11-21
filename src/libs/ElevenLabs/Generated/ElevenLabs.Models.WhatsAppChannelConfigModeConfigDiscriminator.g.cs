
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WhatsAppChannelConfigModeConfigDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.WhatsAppChannelConfigModeConfigDiscriminatorModeJsonConverter))]
        public global::ElevenLabs.WhatsAppChannelConfigModeConfigDiscriminatorMode? Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppChannelConfigModeConfigDiscriminator" /> class.
        /// </summary>
        /// <param name="mode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WhatsAppChannelConfigModeConfigDiscriminator(
            global::ElevenLabs.WhatsAppChannelConfigModeConfigDiscriminatorMode? mode)
        {
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppChannelConfigModeConfigDiscriminator" /> class.
        /// </summary>
        public WhatsAppChannelConfigModeConfigDiscriminator()
        {
        }

    }
}