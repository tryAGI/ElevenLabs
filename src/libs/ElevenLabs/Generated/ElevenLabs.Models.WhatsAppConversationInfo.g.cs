
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WhatsAppConversationInfo
    {
        /// <summary>
        /// Default Value: unknown
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.WhatsAppConversationInfoDirectionJsonConverter))]
        public global::ElevenLabs.WhatsAppConversationInfoDirection? Direction { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("whatsapp_phone_number_id")]
        public string? WhatsappPhoneNumberId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("whatsapp_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WhatsappUserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("awaiting_first_user_message")]
        public bool? AwaitingFirstUserMessage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recipient")]
        public global::ElevenLabs.WhatsAppRecipient? Recipient { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_permission_request")]
        public global::ElevenLabs.WhatsAppCallPermissionRequest? CallPermissionRequest { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_result")]
        public global::ElevenLabs.CallResult? CallResult { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppConversationInfo" /> class.
        /// </summary>
        /// <param name="whatsappUserId"></param>
        /// <param name="direction">
        /// Default Value: unknown
        /// </param>
        /// <param name="whatsappPhoneNumberId"></param>
        /// <param name="awaitingFirstUserMessage"></param>
        /// <param name="recipient"></param>
        /// <param name="callPermissionRequest"></param>
        /// <param name="callResult"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WhatsAppConversationInfo(
            string whatsappUserId,
            global::ElevenLabs.WhatsAppConversationInfoDirection? direction,
            string? whatsappPhoneNumberId,
            bool? awaitingFirstUserMessage,
            global::ElevenLabs.WhatsAppRecipient? recipient,
            global::ElevenLabs.WhatsAppCallPermissionRequest? callPermissionRequest,
            global::ElevenLabs.CallResult? callResult)
        {
            this.Direction = direction;
            this.WhatsappPhoneNumberId = whatsappPhoneNumberId;
            this.WhatsappUserId = whatsappUserId ?? throw new global::System.ArgumentNullException(nameof(whatsappUserId));
            this.AwaitingFirstUserMessage = awaitingFirstUserMessage;
            this.Recipient = recipient;
            this.CallPermissionRequest = callPermissionRequest;
            this.CallResult = callResult;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppConversationInfo" /> class.
        /// </summary>
        public WhatsAppConversationInfo()
        {
        }

    }
}