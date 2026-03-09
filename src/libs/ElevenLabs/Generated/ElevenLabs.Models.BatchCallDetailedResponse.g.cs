
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Detailed response model for a batch call including all recipients.
    /// </summary>
    public sealed partial class BatchCallDetailedResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string PhoneNumberId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TelephonyProviderJsonConverter))]
        public global::ElevenLabs.TelephonyProvider? PhoneProvider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int CreatedAtUnix { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduled_time_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int ScheduledTimeUnix { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_calls_dispatched")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int TotalCallsDispatched { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_calls_scheduled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int TotalCallsScheduled { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_at_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int LastUpdatedAtUnix { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.BatchCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::ElevenLabs.BatchCallStatus Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string AgentName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recipients")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<global::ElevenLabs.OutboundCallRecipientResponseModel> Recipients { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchCallDetailedResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="phoneNumberId"></param>
        /// <param name="phoneProvider"></param>
        /// <param name="name"></param>
        /// <param name="agentId"></param>
        /// <param name="createdAtUnix"></param>
        /// <param name="scheduledTimeUnix"></param>
        /// <param name="totalCallsDispatched"></param>
        /// <param name="totalCallsScheduled"></param>
        /// <param name="lastUpdatedAtUnix"></param>
        /// <param name="status"></param>
        /// <param name="agentName"></param>
        /// <param name="recipients"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchCallDetailedResponse(
            string id,
            string phoneNumberId,
            string name,
            string agentId,
            int createdAtUnix,
            int scheduledTimeUnix,
            int totalCallsDispatched,
            int totalCallsScheduled,
            int lastUpdatedAtUnix,
            global::ElevenLabs.BatchCallStatus status,
            string agentName,
            global::System.Collections.Generic.IList<global::ElevenLabs.OutboundCallRecipientResponseModel> recipients,
            global::ElevenLabs.TelephonyProvider? phoneProvider)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.PhoneNumberId = phoneNumberId ?? throw new global::System.ArgumentNullException(nameof(phoneNumberId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.CreatedAtUnix = createdAtUnix;
            this.ScheduledTimeUnix = scheduledTimeUnix;
            this.TotalCallsDispatched = totalCallsDispatched;
            this.TotalCallsScheduled = totalCallsScheduled;
            this.LastUpdatedAtUnix = lastUpdatedAtUnix;
            this.Status = status;
            this.AgentName = agentName ?? throw new global::System.ArgumentNullException(nameof(agentName));
            this.Recipients = recipients ?? throw new global::System.ArgumentNullException(nameof(recipients));
            this.PhoneProvider = phoneProvider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchCallDetailedResponse" /> class.
        /// </summary>
        public BatchCallDetailedResponse()
        {
        }
    }
}