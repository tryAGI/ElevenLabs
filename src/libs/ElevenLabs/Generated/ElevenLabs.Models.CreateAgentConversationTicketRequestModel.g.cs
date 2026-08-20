
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
        /// The QA finding covering the whole conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("qa_comment")]
        public string? QaComment { get; set; }

        /// <summary>
        /// Optional turn-level comments on what went wrong.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_comments")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.TurnCommentRequestModel>? TurnComments { get; set; }

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
        /// <param name="qaComment">
        /// The QA finding covering the whole conversation.
        /// </param>
        /// <param name="turnComments">
        /// Optional turn-level comments on what went wrong.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentConversationTicketRequestModel(
            string conversationId,
            string? qaComment,
            global::System.Collections.Generic.IList<global::ElevenLabs.TurnCommentRequestModel>? turnComments)
        {
            this.ConversationId = conversationId ?? throw new global::System.ArgumentNullException(nameof(conversationId));
            this.QaComment = qaComment;
            this.TurnComments = turnComments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentConversationTicketRequestModel" /> class.
        /// </summary>
        public CreateAgentConversationTicketRequestModel()
        {
        }

    }
}