
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateAgentConversationTicketRequestModel
    {
        /// <summary>
        /// Conversation this ticket is about.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConversationId { get; set; }

        /// <summary>
        /// One-line headline shown in the triage list. Defaults to one derived from the comments, falling back to the conversation's summary title. Ignored when the comment is added to the conversation's open ticket.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The issue this ticket is about, covering the whole conversation rather than a single turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("qa_comment")]
        public string? QaComment { get; set; }

        /// <summary>
        /// Optional turn-level comments on what went wrong.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_comments")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.TurnCommentRequestModel>? TurnComments { get; set; }

        /// <summary>
        /// How urgently the ticket needs attention. If the conversation already has an open ticket, it is raised to this priority when lower.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        public global::ElevenLabs.AgentConversationTicketPriority? Priority { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentConversationTicketRequestModel" /> class.
        /// </summary>
        /// <param name="conversationId">
        /// Conversation this ticket is about.
        /// </param>
        /// <param name="title">
        /// One-line headline shown in the triage list. Defaults to one derived from the comments, falling back to the conversation's summary title. Ignored when the comment is added to the conversation's open ticket.
        /// </param>
        /// <param name="qaComment">
        /// The issue this ticket is about, covering the whole conversation rather than a single turn.
        /// </param>
        /// <param name="turnComments">
        /// Optional turn-level comments on what went wrong.
        /// </param>
        /// <param name="priority">
        /// How urgently the ticket needs attention. If the conversation already has an open ticket, it is raised to this priority when lower.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentConversationTicketRequestModel(
            string conversationId,
            string? title,
            string? qaComment,
            global::System.Collections.Generic.IList<global::ElevenLabs.TurnCommentRequestModel>? turnComments,
            global::ElevenLabs.AgentConversationTicketPriority? priority)
        {
            this.ConversationId = conversationId ?? throw new global::System.ArgumentNullException(nameof(conversationId));
            this.Title = title;
            this.QaComment = qaComment;
            this.TurnComments = turnComments;
            this.Priority = priority;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentConversationTicketRequestModel" /> class.
        /// </summary>
        public CreateAgentConversationTicketRequestModel()
        {
        }

    }
}