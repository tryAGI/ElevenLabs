
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TicketListItemResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Subject { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TicketStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.TicketStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        public global::ElevenLabs.TicketPriority? Priority { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requester")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.TicketRequesterResponse Requester { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignee")]
        public global::ElevenLabs.AssigneeVariant14? Assignee { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secondary_assignee")]
        public global::ElevenLabs.SecondaryAssigneeVariant14? SecondaryAssignee { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscribers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.TicketSubscriberResponse> Subscribers { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> TagIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sla")]
        public global::ElevenLabs.TicketSLASummaryResponse? Sla { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deadline_at_unix_secs")]
        public int? DeadlineAtUnixSecs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_unix_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAtUnixSecs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at_unix_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UpdatedAtUnixSecs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TicketListItemResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="subject"></param>
        /// <param name="status"></param>
        /// <param name="requester"></param>
        /// <param name="subscribers"></param>
        /// <param name="tagIds"></param>
        /// <param name="createdAtUnixSecs"></param>
        /// <param name="updatedAtUnixSecs"></param>
        /// <param name="priority"></param>
        /// <param name="assignee"></param>
        /// <param name="secondaryAssignee"></param>
        /// <param name="sla"></param>
        /// <param name="deadlineAtUnixSecs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TicketListItemResponse(
            string id,
            string subject,
            global::ElevenLabs.TicketStatus status,
            global::ElevenLabs.TicketRequesterResponse requester,
            global::System.Collections.Generic.IList<global::ElevenLabs.TicketSubscriberResponse> subscribers,
            global::System.Collections.Generic.IList<string> tagIds,
            int createdAtUnixSecs,
            int updatedAtUnixSecs,
            global::ElevenLabs.TicketPriority? priority,
            global::ElevenLabs.AssigneeVariant14? assignee,
            global::ElevenLabs.SecondaryAssigneeVariant14? secondaryAssignee,
            global::ElevenLabs.TicketSLASummaryResponse? sla,
            int? deadlineAtUnixSecs)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Subject = subject ?? throw new global::System.ArgumentNullException(nameof(subject));
            this.Status = status;
            this.Priority = priority;
            this.Requester = requester ?? throw new global::System.ArgumentNullException(nameof(requester));
            this.Assignee = assignee;
            this.SecondaryAssignee = secondaryAssignee;
            this.Subscribers = subscribers ?? throw new global::System.ArgumentNullException(nameof(subscribers));
            this.TagIds = tagIds ?? throw new global::System.ArgumentNullException(nameof(tagIds));
            this.Sla = sla;
            this.DeadlineAtUnixSecs = deadlineAtUnixSecs;
            this.CreatedAtUnixSecs = createdAtUnixSecs;
            this.UpdatedAtUnixSecs = updatedAtUnixSecs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TicketListItemResponse" /> class.
        /// </summary>
        public TicketListItemResponse()
        {
        }

    }
}