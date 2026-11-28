
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateTicketRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject")]
        public string? Subject { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public global::ElevenLabs.TicketStatus? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        public global::ElevenLabs.TicketPriority? Priority { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deadline_at_unix_secs")]
        public int? DeadlineAtUnixSecs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_ids")]
        public global::System.Collections.Generic.IList<string>? TagIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignee")]
        public global::ElevenLabs.AssigneeVariant13? Assignee { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secondary_assignee")]
        public global::ElevenLabs.SecondaryAssigneeVariant13? SecondaryAssignee { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscribers")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.TicketSubscriberRequest>? Subscribers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTicketRequest" /> class.
        /// </summary>
        /// <param name="subject"></param>
        /// <param name="status"></param>
        /// <param name="priority"></param>
        /// <param name="deadlineAtUnixSecs"></param>
        /// <param name="tagIds"></param>
        /// <param name="assignee"></param>
        /// <param name="secondaryAssignee"></param>
        /// <param name="subscribers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateTicketRequest(
            string? subject,
            global::ElevenLabs.TicketStatus? status,
            global::ElevenLabs.TicketPriority? priority,
            int? deadlineAtUnixSecs,
            global::System.Collections.Generic.IList<string>? tagIds,
            global::ElevenLabs.AssigneeVariant13? assignee,
            global::ElevenLabs.SecondaryAssigneeVariant13? secondaryAssignee,
            global::System.Collections.Generic.IList<global::ElevenLabs.TicketSubscriberRequest>? subscribers)
        {
            this.Subject = subject;
            this.Status = status;
            this.Priority = priority;
            this.DeadlineAtUnixSecs = deadlineAtUnixSecs;
            this.TagIds = tagIds;
            this.Assignee = assignee;
            this.SecondaryAssignee = secondaryAssignee;
            this.Subscribers = subscribers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTicketRequest" /> class.
        /// </summary>
        public UpdateTicketRequest()
        {
        }

    }
}