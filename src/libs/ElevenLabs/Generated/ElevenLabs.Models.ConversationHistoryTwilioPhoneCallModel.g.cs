
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationHistoryTwilioPhoneCallModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ConversationHistoryTwilioPhoneCallModelDirectionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::ElevenLabs.ConversationHistoryTwilioPhoneCallModelDirection Direction { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string PhoneNumberId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string AgentNumber { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string ExternalNumber { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        /// <default>"twilio"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "twilio";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_sid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string StreamSid { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_sid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string CallSid { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryTwilioPhoneCallModel" /> class.
        /// </summary>
        /// <param name="direction"></param>
        /// <param name="phoneNumberId"></param>
        /// <param name="agentNumber"></param>
        /// <param name="externalNumber"></param>
        /// <param name="type"></param>
        /// <param name="streamSid"></param>
        /// <param name="callSid"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationHistoryTwilioPhoneCallModel(
            global::ElevenLabs.ConversationHistoryTwilioPhoneCallModelDirection direction,
            string phoneNumberId,
            string agentNumber,
            string externalNumber,
            string streamSid,
            string callSid,
            string type = "twilio")
        {
            this.Direction = direction;
            this.PhoneNumberId = phoneNumberId ?? throw new global::System.ArgumentNullException(nameof(phoneNumberId));
            this.AgentNumber = agentNumber ?? throw new global::System.ArgumentNullException(nameof(agentNumber));
            this.ExternalNumber = externalNumber ?? throw new global::System.ArgumentNullException(nameof(externalNumber));
            this.StreamSid = streamSid ?? throw new global::System.ArgumentNullException(nameof(streamSid));
            this.CallSid = callSid ?? throw new global::System.ArgumentNullException(nameof(callSid));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryTwilioPhoneCallModel" /> class.
        /// </summary>
        public ConversationHistoryTwilioPhoneCallModel()
        {
        }
    }
}