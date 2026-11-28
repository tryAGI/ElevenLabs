
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTicketRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requester")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.RequesterJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.Requester Requester { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AuthorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.Author Author { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Subject { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

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
        public global::ElevenLabs.AssigneeVariant12? Assignee { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secondary_assignee")]
        public global::ElevenLabs.SecondaryAssigneeVariant12? SecondaryAssignee { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateTicketRequest" /> class.
        /// </summary>
        /// <param name="requester"></param>
        /// <param name="author"></param>
        /// <param name="subject"></param>
        /// <param name="description"></param>
        /// <param name="priority"></param>
        /// <param name="deadlineAtUnixSecs"></param>
        /// <param name="tagIds"></param>
        /// <param name="assignee"></param>
        /// <param name="secondaryAssignee"></param>
        /// <param name="subscribers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTicketRequest(
            global::ElevenLabs.Requester requester,
            global::ElevenLabs.Author author,
            string subject,
            string? description,
            global::ElevenLabs.TicketPriority? priority,
            int? deadlineAtUnixSecs,
            global::System.Collections.Generic.IList<string>? tagIds,
            global::ElevenLabs.AssigneeVariant12? assignee,
            global::ElevenLabs.SecondaryAssigneeVariant12? secondaryAssignee,
            global::System.Collections.Generic.IList<global::ElevenLabs.TicketSubscriberRequest>? subscribers)
        {
            this.Requester = requester;
            this.Author = author;
            this.Subject = subject ?? throw new global::System.ArgumentNullException(nameof(subject));
            this.Description = description;
            this.Priority = priority;
            this.DeadlineAtUnixSecs = deadlineAtUnixSecs;
            this.TagIds = tagIds;
            this.Assignee = assignee;
            this.SecondaryAssignee = secondaryAssignee;
            this.Subscribers = subscribers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTicketRequest" /> class.
        /// </summary>
        public CreateTicketRequest()
        {
        }

    }
}