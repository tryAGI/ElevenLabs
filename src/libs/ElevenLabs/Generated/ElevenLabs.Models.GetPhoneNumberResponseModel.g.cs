
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetPhoneNumberResponseModel
    {
        /// <summary>
        /// Phone number
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PhoneNumber { get; set; }

        /// <summary>
        /// Phone provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TelephonyProviderJsonConverter))]
        public global::ElevenLabs.TelephonyProvider Provider { get; set; }

        /// <summary>
        /// Label for the phone number
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// 
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPhoneNumberResponseModel" /> class.
        /// </summary>
        /// <param name="phoneNumber">
        /// Phone number
        /// </param>
        /// <param name="provider">
        /// Phone provider
        /// </param>
        /// <param name="label">
        /// Label for the phone number
        /// </param>
        /// <param name="phoneNumberId"></param>
        /// <param name="assignedAgent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetPhoneNumberResponseModel(
            string phoneNumber,
            string label,
            string phoneNumberId,
            global::ElevenLabs.TelephonyProvider provider,
            global::ElevenLabs.PhoneNumberAgentInfo? assignedAgent)
        {
            this.PhoneNumber = phoneNumber ?? throw new global::System.ArgumentNullException(nameof(phoneNumber));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.PhoneNumberId = phoneNumberId ?? throw new global::System.ArgumentNullException(nameof(phoneNumberId));
            this.Provider = provider;
            this.AssignedAgent = assignedAgent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPhoneNumberResponseModel" /> class.
        /// </summary>
        public GetPhoneNumberResponseModel()
        {
        }
    }
}