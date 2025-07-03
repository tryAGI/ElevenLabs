
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SIPUriTransferDestination
    {
        /// <summary>
        /// Default Value: sip_uri
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.SIPUriTransferDestinationTypeJsonConverter))]
        public global::ElevenLabs.SIPUriTransferDestinationType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sip_uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SipUri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SIPUriTransferDestination" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: sip_uri
        /// </param>
        /// <param name="sipUri"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SIPUriTransferDestination(
            string sipUri,
            global::ElevenLabs.SIPUriTransferDestinationType? type)
        {
            this.SipUri = sipUri ?? throw new global::System.ArgumentNullException(nameof(sipUri));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SIPUriTransferDestination" /> class.
        /// </summary>
        public SIPUriTransferDestination()
        {
        }
    }
}