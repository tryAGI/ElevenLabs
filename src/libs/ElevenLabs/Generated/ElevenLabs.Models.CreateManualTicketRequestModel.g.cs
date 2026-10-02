
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateManualTicketRequestModel
    {
        /// <summary>
        /// One-line headline shown in the triage list. Defaults to one derived from qa_comment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// What the ticket is about, e.g. a follow-up task for the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("qa_comment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string QaComment { get; set; }

        /// <summary>
        /// How urgently the ticket needs attention.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        public global::ElevenLabs.AgentConversationTicketPriority? Priority { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateManualTicketRequestModel" /> class.
        /// </summary>
        /// <param name="qaComment">
        /// What the ticket is about, e.g. a follow-up task for the agent.
        /// </param>
        /// <param name="title">
        /// One-line headline shown in the triage list. Defaults to one derived from qa_comment.
        /// </param>
        /// <param name="priority">
        /// How urgently the ticket needs attention.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateManualTicketRequestModel(
            string qaComment,
            string? title,
            global::ElevenLabs.AgentConversationTicketPriority? priority)
        {
            this.Title = title;
            this.QaComment = qaComment ?? throw new global::System.ArgumentNullException(nameof(qaComment));
            this.Priority = priority;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateManualTicketRequestModel" /> class.
        /// </summary>
        public CreateManualTicketRequestModel()
        {
        }

    }
}