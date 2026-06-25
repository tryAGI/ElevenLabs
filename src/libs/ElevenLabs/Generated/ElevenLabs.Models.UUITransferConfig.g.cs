
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// User-to-User Information envelope for SIP REFER transfers (RFC 7433).<br/>
    /// Outbound payloads are hex-encoded (the only encoding RFC 7433 defines). The<br/>
    /// protocol discriminator axis lets per-platform formats (Talkdesk, Genesys, ...)<br/>
    /// be expressed by configuration rather than scattered transfer flags. Further<br/>
    /// axes (ASCII encoding, header name, purpose/content parameters) can be added<br/>
    /// here without touching the transfer model.
    /// </summary>
    public sealed partial class UUITransferConfig
    {
        /// <summary>
        /// UUI payload to send on SIP REFER transfers. Supports inline dynamic variables and is hex-encoded at transfer time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// Optional one-octet protocol discriminator (two hex digits, e.g. '00'). Required by platforms such as Genesys Cloud, which otherwise strip the first octet of the payload. Leave unset for platforms like Talkdesk that expect a bare hex payload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protocol_discriminator")]
        public string? ProtocolDiscriminator { get; set; }

        /// <summary>
        /// How to attach protocol_discriminator. 'prefix' prepends the octet to the hex payload (User-to-User=XX&lt;hex&gt;;encoding=hex). 'pd_parameter' sends it as a separate parameter (User-to-User=&lt;hex&gt;;pd=XX;encoding=hex). Ignored when protocol_discriminator is unset.<br/>
        /// Default Value: prefix
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protocol_discriminator_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.UUITransferConfigProtocolDiscriminatorModeJsonConverter))]
        public global::ElevenLabs.UUITransferConfigProtocolDiscriminatorMode? ProtocolDiscriminatorMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UUITransferConfig" /> class.
        /// </summary>
        /// <param name="data">
        /// UUI payload to send on SIP REFER transfers. Supports inline dynamic variables and is hex-encoded at transfer time.
        /// </param>
        /// <param name="protocolDiscriminator">
        /// Optional one-octet protocol discriminator (two hex digits, e.g. '00'). Required by platforms such as Genesys Cloud, which otherwise strip the first octet of the payload. Leave unset for platforms like Talkdesk that expect a bare hex payload.
        /// </param>
        /// <param name="protocolDiscriminatorMode">
        /// How to attach protocol_discriminator. 'prefix' prepends the octet to the hex payload (User-to-User=XX&lt;hex&gt;;encoding=hex). 'pd_parameter' sends it as a separate parameter (User-to-User=&lt;hex&gt;;pd=XX;encoding=hex). Ignored when protocol_discriminator is unset.<br/>
        /// Default Value: prefix
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UUITransferConfig(
            string data,
            string? protocolDiscriminator,
            global::ElevenLabs.UUITransferConfigProtocolDiscriminatorMode? protocolDiscriminatorMode)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.ProtocolDiscriminator = protocolDiscriminator;
            this.ProtocolDiscriminatorMode = protocolDiscriminatorMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UUITransferConfig" /> class.
        /// </summary>
        public UUITransferConfig()
        {
        }

    }
}