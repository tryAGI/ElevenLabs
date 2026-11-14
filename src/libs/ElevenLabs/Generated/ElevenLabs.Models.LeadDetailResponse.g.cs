
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LeadDetailResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lead_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LeadId { get; set; }

        /// <summary>
        /// The `id` given to this recipient when the campaign was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recipient_id")]
        public string? RecipientId { get; set; }

        /// <summary>
        /// The number the lead's next call dials. It changes when the lead moves on to another listed number or the contact asks to be called on a different one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PhoneNumber { get; set; }

        /// <summary>
        /// The lead's listed numbers, in calling order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_numbers")]
        public global::System.Collections.Generic.IList<string>? PhoneNumbers { get; set; }

        /// <summary>
        /// The position in `phone_numbers` of the number being called.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_numbers_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PhoneNumbersIndex { get; set; }

        /// <summary>
        /// The contact's identity: the `user_id` submitted in `conversation_initiation_client_data`, else the lead's phone number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Calls placed, counted against the policy's `max_total_calls`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attempt_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AttemptCount { get; set; }

        /// <summary>
        /// Failed calls to the current number; resets on a new number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failure_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FailureCount { get; set; }

        /// <summary>
        /// Callbacks the contact asked for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CallbackCount { get; set; }

        /// <summary>
        /// Times the contact asked to be called on another number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RedirectCount { get; set; }

        /// <summary>
        /// Set when the contact asked not to be called, the lead was removed, or the campaign stopped. The lead isn't called again.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("do_not_call")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool DoNotCall { get; set; }

        /// <summary>
        /// Why the lead won't be called again; unset while it may be.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("terminal_disposition")]
        public global::ElevenLabs.TerminalDisposition? TerminalDisposition { get; set; }

        /// <summary>
        /// When the lead joined the campaign; unset on older leads.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_unix")]
        public int? CreatedAtUnix { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UpdatedAtUnix { get; set; }

        /// <summary>
        /// The dynamic variables submitted for the lead, with secrets redacted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variables")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object DynamicVariables { get; set; }

        /// <summary>
        /// The conversation overrides submitted for the lead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overrides")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.FlattenedConfigOverrides Overrides { get; set; }

        /// <summary>
        /// The lead's latest message delivery; set on message campaigns.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delivery")]
        public global::ElevenLabs.LeadDeliveryView? Delivery { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LeadDetailResponse" /> class.
        /// </summary>
        /// <param name="leadId"></param>
        /// <param name="phoneNumber">
        /// The number the lead's next call dials. It changes when the lead moves on to another listed number or the contact asks to be called on a different one.
        /// </param>
        /// <param name="phoneNumbersIndex">
        /// The position in `phone_numbers` of the number being called.
        /// </param>
        /// <param name="userId">
        /// The contact's identity: the `user_id` submitted in `conversation_initiation_client_data`, else the lead's phone number.
        /// </param>
        /// <param name="attemptCount">
        /// Calls placed, counted against the policy's `max_total_calls`.
        /// </param>
        /// <param name="failureCount">
        /// Failed calls to the current number; resets on a new number.
        /// </param>
        /// <param name="callbackCount">
        /// Callbacks the contact asked for.
        /// </param>
        /// <param name="redirectCount">
        /// Times the contact asked to be called on another number.
        /// </param>
        /// <param name="doNotCall">
        /// Set when the contact asked not to be called, the lead was removed, or the campaign stopped. The lead isn't called again.
        /// </param>
        /// <param name="updatedAtUnix"></param>
        /// <param name="dynamicVariables">
        /// The dynamic variables submitted for the lead, with secrets redacted.
        /// </param>
        /// <param name="overrides">
        /// The conversation overrides submitted for the lead.
        /// </param>
        /// <param name="recipientId">
        /// The `id` given to this recipient when the campaign was created.
        /// </param>
        /// <param name="phoneNumbers">
        /// The lead's listed numbers, in calling order.
        /// </param>
        /// <param name="terminalDisposition">
        /// Why the lead won't be called again; unset while it may be.
        /// </param>
        /// <param name="createdAtUnix">
        /// When the lead joined the campaign; unset on older leads.
        /// </param>
        /// <param name="delivery">
        /// The lead's latest message delivery; set on message campaigns.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LeadDetailResponse(
            string leadId,
            string phoneNumber,
            int phoneNumbersIndex,
            string userId,
            int attemptCount,
            int failureCount,
            int callbackCount,
            int redirectCount,
            bool doNotCall,
            int updatedAtUnix,
            object dynamicVariables,
            global::ElevenLabs.FlattenedConfigOverrides overrides,
            string? recipientId,
            global::System.Collections.Generic.IList<string>? phoneNumbers,
            global::ElevenLabs.TerminalDisposition? terminalDisposition,
            int? createdAtUnix,
            global::ElevenLabs.LeadDeliveryView? delivery)
        {
            this.LeadId = leadId ?? throw new global::System.ArgumentNullException(nameof(leadId));
            this.RecipientId = recipientId;
            this.PhoneNumber = phoneNumber ?? throw new global::System.ArgumentNullException(nameof(phoneNumber));
            this.PhoneNumbers = phoneNumbers;
            this.PhoneNumbersIndex = phoneNumbersIndex;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.AttemptCount = attemptCount;
            this.FailureCount = failureCount;
            this.CallbackCount = callbackCount;
            this.RedirectCount = redirectCount;
            this.DoNotCall = doNotCall;
            this.TerminalDisposition = terminalDisposition;
            this.CreatedAtUnix = createdAtUnix;
            this.UpdatedAtUnix = updatedAtUnix;
            this.DynamicVariables = dynamicVariables ?? throw new global::System.ArgumentNullException(nameof(dynamicVariables));
            this.Overrides = overrides ?? throw new global::System.ArgumentNullException(nameof(overrides));
            this.Delivery = delivery;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LeadDetailResponse" /> class.
        /// </summary>
        public LeadDetailResponse()
        {
        }

    }
}