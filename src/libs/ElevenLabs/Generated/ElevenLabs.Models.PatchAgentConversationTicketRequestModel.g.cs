
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PatchAgentConversationTicketRequestModel
    {
        /// <summary>
        /// If provided, updates the ticket status. Omit to leave unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public global::ElevenLabs.AgentConversationTicketStatus? Status { get; set; }

        /// <summary>
        /// If provided, updates who is responsible for resolving this ticket. Must be a workspace member with at least viewer access to the agent. Pass null to unassign. Omit to leave unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignee_user_id")]
        public string? AssigneeUserId { get; set; }

        /// <summary>
        /// If provided, updates how urgently the ticket needs attention. Pass null to clear it. Omit to leave unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        public global::ElevenLabs.AgentConversationTicketPriority? Priority { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchAgentConversationTicketRequestModel" /> class.
        /// </summary>
        /// <param name="status">
        /// If provided, updates the ticket status. Omit to leave unchanged.
        /// </param>
        /// <param name="assigneeUserId">
        /// If provided, updates who is responsible for resolving this ticket. Must be a workspace member with at least viewer access to the agent. Pass null to unassign. Omit to leave unchanged.
        /// </param>
        /// <param name="priority">
        /// If provided, updates how urgently the ticket needs attention. Pass null to clear it. Omit to leave unchanged.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchAgentConversationTicketRequestModel(
            global::ElevenLabs.AgentConversationTicketStatus? status,
            string? assigneeUserId,
            global::ElevenLabs.AgentConversationTicketPriority? priority)
        {
            this.Status = status;
            this.AssigneeUserId = assigneeUserId;
            this.Priority = priority;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchAgentConversationTicketRequestModel" /> class.
        /// </summary>
        public PatchAgentConversationTicketRequestModel()
        {
        }

    }
}