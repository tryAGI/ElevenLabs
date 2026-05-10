
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SMSConversationInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.SMSConversationInfoDirectionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.SMSConversationInfoDirection Direction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number_id")]
        public string? PhoneNumberId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sms_user_phone_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SmsUserPhoneNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_phone_number")]
        public string? AgentPhoneNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SMSConversationInfo" /> class.
        /// </summary>
        /// <param name="direction"></param>
        /// <param name="smsUserPhoneNumber"></param>
        /// <param name="phoneNumberId"></param>
        /// <param name="agentPhoneNumber"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SMSConversationInfo(
            global::ElevenLabs.SMSConversationInfoDirection direction,
            string smsUserPhoneNumber,
            string? phoneNumberId,
            string? agentPhoneNumber)
        {
            this.Direction = direction;
            this.PhoneNumberId = phoneNumberId;
            this.SmsUserPhoneNumber = smsUserPhoneNumber ?? throw new global::System.ArgumentNullException(nameof(smsUserPhoneNumber));
            this.AgentPhoneNumber = agentPhoneNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SMSConversationInfo" /> class.
        /// </summary>
        public SMSConversationInfo()
        {
        }

    }
}