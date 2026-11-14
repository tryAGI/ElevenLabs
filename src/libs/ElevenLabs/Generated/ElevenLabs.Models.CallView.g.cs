
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CallView
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IntentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lead_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LeadId { get; set; }

        /// <summary>
        /// `initial` for a lead's first call, else a `retry`, `callback` or `redirect`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intent_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.CampaignConversationTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.CampaignConversationType IntentType { get; set; }

        /// <summary>
        /// `1` for the first call and `+1` per retry of it; unset for callbacks, redirects and their retries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cold_attempt")]
        public int? ColdAttempt { get; set; }

        /// <summary>
        /// `submitted` calls have been handed off for dialing; `attention` calls are held back by an attention item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.CallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.CallStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PhoneNumber { get; set; }

        /// <summary>
        /// When the call is due to be placed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduled_time_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ScheduledTimeUnix { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        public string? ConversationId { get; set; }

        /// <summary>
        /// The call's final dialing status, set once it ends.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outcome")]
        public global::ElevenLabs.BatchCallRecipientStatus? Outcome { get; set; }

        /// <summary>
        /// How the call ended.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_result")]
        public global::ElevenLabs.CallResult? CallResult { get; set; }

        /// <summary>
        /// When the call ended.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outcome_at_unix")]
        public int? OutcomeAtUnix { get; set; }

        /// <summary>
        /// What the campaign did after the call, such as queue a retry or a callback, or finish the lead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decision_disposition")]
        public global::ElevenLabs.DecisionDisposition? DecisionDisposition { get; set; }

        /// <summary>
        /// Data collection results this call copied into the lead's dynamic variables for later calls, with secrets redacted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collected_dynamic_variables")]
        public object? CollectedDynamicVariables { get; set; }

        /// <summary>
        /// The message's delivery; set on message campaigns.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delivery")]
        public global::ElevenLabs.LeadDeliveryView? Delivery { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallView" /> class.
        /// </summary>
        /// <param name="intentId"></param>
        /// <param name="leadId"></param>
        /// <param name="intentType">
        /// `initial` for a lead's first call, else a `retry`, `callback` or `redirect`.
        /// </param>
        /// <param name="status">
        /// `submitted` calls have been handed off for dialing; `attention` calls are held back by an attention item.
        /// </param>
        /// <param name="phoneNumber"></param>
        /// <param name="scheduledTimeUnix">
        /// When the call is due to be placed.
        /// </param>
        /// <param name="coldAttempt">
        /// `1` for the first call and `+1` per retry of it; unset for callbacks, redirects and their retries.
        /// </param>
        /// <param name="conversationId"></param>
        /// <param name="outcome">
        /// The call's final dialing status, set once it ends.
        /// </param>
        /// <param name="callResult">
        /// How the call ended.
        /// </param>
        /// <param name="outcomeAtUnix">
        /// When the call ended.
        /// </param>
        /// <param name="decisionDisposition">
        /// What the campaign did after the call, such as queue a retry or a callback, or finish the lead.
        /// </param>
        /// <param name="collectedDynamicVariables">
        /// Data collection results this call copied into the lead's dynamic variables for later calls, with secrets redacted.
        /// </param>
        /// <param name="delivery">
        /// The message's delivery; set on message campaigns.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallView(
            string intentId,
            string leadId,
            global::ElevenLabs.CampaignConversationType intentType,
            global::ElevenLabs.CallStatus status,
            string phoneNumber,
            int scheduledTimeUnix,
            int? coldAttempt,
            string? conversationId,
            global::ElevenLabs.BatchCallRecipientStatus? outcome,
            global::ElevenLabs.CallResult? callResult,
            int? outcomeAtUnix,
            global::ElevenLabs.DecisionDisposition? decisionDisposition,
            object? collectedDynamicVariables,
            global::ElevenLabs.LeadDeliveryView? delivery)
        {
            this.IntentId = intentId ?? throw new global::System.ArgumentNullException(nameof(intentId));
            this.LeadId = leadId ?? throw new global::System.ArgumentNullException(nameof(leadId));
            this.IntentType = intentType;
            this.ColdAttempt = coldAttempt;
            this.Status = status;
            this.PhoneNumber = phoneNumber ?? throw new global::System.ArgumentNullException(nameof(phoneNumber));
            this.ScheduledTimeUnix = scheduledTimeUnix;
            this.ConversationId = conversationId;
            this.Outcome = outcome;
            this.CallResult = callResult;
            this.OutcomeAtUnix = outcomeAtUnix;
            this.DecisionDisposition = decisionDisposition;
            this.CollectedDynamicVariables = collectedDynamicVariables;
            this.Delivery = delivery;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallView" /> class.
        /// </summary>
        public CallView()
        {
        }

    }
}