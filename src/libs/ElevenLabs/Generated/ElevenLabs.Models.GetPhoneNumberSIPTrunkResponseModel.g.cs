
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetPhoneNumberSIPTrunkResponseModel
    {
        /// <summary>
        /// Phone number
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PhoneNumber { get; set; }

        /// <summary>
        /// Label for the phone number
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// The ID of the phone number
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PhoneNumberId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assigned_agent")]
        public global::ElevenLabs.PhoneNumberAgentInfo? AssignedAgent { get; set; }

        /// <summary>
        /// Phone provider<br/>
        /// Default Value: sip_trunk
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.GetPhoneNumberSIPTrunkResponseModelProviderJsonConverter))]
        public global::ElevenLabs.GetPhoneNumberSIPTrunkResponseModelProvider? Provider { get; set; }

        /// <summary>
        /// SIP Trunk configuration details for a phone number
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_config")]
        public global::ElevenLabs.GetPhoneNumberOutboundSIPTrunkConfigResponseModel? ProviderConfig { get; set; }

        /// <summary>
        /// SIP Trunk configuration details for a phone number
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outbound_trunk")]
        public global::ElevenLabs.GetPhoneNumberOutboundSIPTrunkConfigResponseModel? OutboundTrunk { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inbound_trunk")]
        public global::ElevenLabs.GetPhoneNumberInboundSIPTrunkConfigResponseModel? InboundTrunk { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPhoneNumberSIPTrunkResponseModel" /> class.
        /// </summary>
        /// <param name="phoneNumber">
        /// Phone number
        /// </param>
        /// <param name="label">
        /// Label for the phone number
        /// </param>
        /// <param name="phoneNumberId">
        /// The ID of the phone number
        /// </param>
        /// <param name="assignedAgent"></param>
        /// <param name="provider">
        /// Phone provider<br/>
        /// Default Value: sip_trunk
        /// </param>
        /// <param name="providerConfig">
        /// SIP Trunk configuration details for a phone number
        /// </param>
        /// <param name="outboundTrunk">
        /// SIP Trunk configuration details for a phone number
        /// </param>
        /// <param name="inboundTrunk"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetPhoneNumberSIPTrunkResponseModel(
            string phoneNumber,
            string label,
            string phoneNumberId,
            global::ElevenLabs.PhoneNumberAgentInfo? assignedAgent,
            global::ElevenLabs.GetPhoneNumberSIPTrunkResponseModelProvider? provider,
            global::ElevenLabs.GetPhoneNumberOutboundSIPTrunkConfigResponseModel? providerConfig,
            global::ElevenLabs.GetPhoneNumberOutboundSIPTrunkConfigResponseModel? outboundTrunk,
            global::ElevenLabs.GetPhoneNumberInboundSIPTrunkConfigResponseModel? inboundTrunk)
        {
            this.PhoneNumber = phoneNumber ?? throw new global::System.ArgumentNullException(nameof(phoneNumber));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.PhoneNumberId = phoneNumberId ?? throw new global::System.ArgumentNullException(nameof(phoneNumberId));
            this.AssignedAgent = assignedAgent;
            this.Provider = provider;
            this.ProviderConfig = providerConfig;
            this.OutboundTrunk = outboundTrunk;
            this.InboundTrunk = inboundTrunk;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPhoneNumberSIPTrunkResponseModel" /> class.
        /// </summary>
        public GetPhoneNumberSIPTrunkResponseModel()
        {
        }
    }
}