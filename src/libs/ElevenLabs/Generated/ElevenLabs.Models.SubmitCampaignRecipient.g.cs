
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubmitCampaignRecipient
    {
        /// <summary>
        /// The number to call, in E.164 format such as `+14155550100`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// More numbers to call, in order after `phone_number`. The lead moves on to the next one when calls to its current number keep failing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_numbers")]
        public global::System.Collections.Generic.IList<string>? PhoneNumbers { get; set; }

        /// <summary>
        /// The contact's WhatsApp user ID. WhatsApp campaigns use it instead of the phone numbers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("whatsapp_user_id")]
        public string? WhatsappUserId { get; set; }

        /// <summary>
        /// Your identifier for the recipient, returned as its lead's `recipient_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Dynamic variables and overrides for this recipient's calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_initiation_client_data")]
        public global::ElevenLabs.ConversationInitiationClientDataRequestInput? ConversationInitiationClientData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitCampaignRecipient" /> class.
        /// </summary>
        /// <param name="phoneNumber">
        /// The number to call, in E.164 format such as `+14155550100`.
        /// </param>
        /// <param name="phoneNumbers">
        /// More numbers to call, in order after `phone_number`. The lead moves on to the next one when calls to its current number keep failing.
        /// </param>
        /// <param name="whatsappUserId">
        /// The contact's WhatsApp user ID. WhatsApp campaigns use it instead of the phone numbers.
        /// </param>
        /// <param name="id">
        /// Your identifier for the recipient, returned as its lead's `recipient_id`.
        /// </param>
        /// <param name="conversationInitiationClientData">
        /// Dynamic variables and overrides for this recipient's calls.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubmitCampaignRecipient(
            string? phoneNumber,
            global::System.Collections.Generic.IList<string>? phoneNumbers,
            string? whatsappUserId,
            string? id,
            global::ElevenLabs.ConversationInitiationClientDataRequestInput? conversationInitiationClientData)
        {
            this.PhoneNumber = phoneNumber;
            this.PhoneNumbers = phoneNumbers;
            this.WhatsappUserId = whatsappUserId;
            this.Id = id;
            this.ConversationInitiationClientData = conversationInitiationClientData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitCampaignRecipient" /> class.
        /// </summary>
        public SubmitCampaignRecipient()
        {
        }

    }
}