
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OutboundSIPTrunkConfigRequestModel
    {
        /// <summary>
        /// Hostname or IP the SIP INVITE is sent to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("address")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Address { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transport")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.SIPTrunkTransportEnumJsonConverter))]
        public global::ElevenLabs.SIPTrunkTransportEnum? Transport { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_encryption")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.SIPMediaEncryptionEnumJsonConverter))]
        public global::ElevenLabs.SIPMediaEncryptionEnum? MediaEncryption { get; set; }

        /// <summary>
        /// SIP X-* headers for INVITE request. These headers are sent as-is and may help identify this call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials")]
        public global::ElevenLabs.SIPTrunkCredentialsRequestModel? Credentials { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutboundSIPTrunkConfigRequestModel" /> class.
        /// </summary>
        /// <param name="address">
        /// Hostname or IP the SIP INVITE is sent to.
        /// </param>
        /// <param name="transport"></param>
        /// <param name="mediaEncryption"></param>
        /// <param name="headers">
        /// SIP X-* headers for INVITE request. These headers are sent as-is and may help identify this call.
        /// </param>
        /// <param name="credentials"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutboundSIPTrunkConfigRequestModel(
            string address,
            global::ElevenLabs.SIPTrunkTransportEnum? transport,
            global::ElevenLabs.SIPMediaEncryptionEnum? mediaEncryption,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            global::ElevenLabs.SIPTrunkCredentialsRequestModel? credentials)
        {
            this.Address = address ?? throw new global::System.ArgumentNullException(nameof(address));
            this.Transport = transport;
            this.MediaEncryption = mediaEncryption;
            this.Headers = headers;
            this.Credentials = credentials;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutboundSIPTrunkConfigRequestModel" /> class.
        /// </summary>
        public OutboundSIPTrunkConfigRequestModel()
        {
        }
    }
}