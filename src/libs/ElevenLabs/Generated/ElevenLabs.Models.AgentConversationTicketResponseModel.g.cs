
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentConversationTicketResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentqa_ticket_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentqaTicketId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkspaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("needs_clustering")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool NeedsClustering { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue_type")]
        public global::ElevenLabs.AgentConversationTicketIssueType? IssueType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Labels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ConversationIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_seen_unix_secs")]
        public int? FirstSeenUnixSecs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_seen_unix_secs")]
        public int? LastSeenUnixSecs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("qa_comment")]
        public string? QaComment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ticket_comments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.TicketCommentResponseModel> TicketComments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_comments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.TurnCommentResponseModel> TurnComments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AgentConversationTicketStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.AgentConversationTicketStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AgentConversationTicketSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.AgentConversationTicketSource Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignee_user_id")]
        public string? AssigneeUserId { get; set; }

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
        /// Initializes a new instance of the <see cref="AgentConversationTicketResponseModel" /> class.
        /// </summary>
        /// <param name="agentqaTicketId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="ownerUserId"></param>
        /// <param name="agentId"></param>
        /// <param name="needsClustering"></param>
        /// <param name="labels"></param>
        /// <param name="conversationIds"></param>
        /// <param name="ticketComments"></param>
        /// <param name="turnComments"></param>
        /// <param name="status"></param>
        /// <param name="source"></param>
        /// <param name="createdAtUnixSecs"></param>
        /// <param name="updatedAtUnixSecs"></param>
        /// <param name="issueType"></param>
        /// <param name="firstSeenUnixSecs"></param>
        /// <param name="lastSeenUnixSecs"></param>
        /// <param name="qaComment"></param>
        /// <param name="assigneeUserId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentConversationTicketResponseModel(
            string agentqaTicketId,
            string workspaceId,
            string ownerUserId,
            string agentId,
            bool needsClustering,
            global::System.Collections.Generic.IList<string> labels,
            global::System.Collections.Generic.IList<string> conversationIds,
            global::System.Collections.Generic.IList<global::ElevenLabs.TicketCommentResponseModel> ticketComments,
            global::System.Collections.Generic.IList<global::ElevenLabs.TurnCommentResponseModel> turnComments,
            global::ElevenLabs.AgentConversationTicketStatus status,
            global::ElevenLabs.AgentConversationTicketSource source,
            int createdAtUnixSecs,
            int updatedAtUnixSecs,
            global::ElevenLabs.AgentConversationTicketIssueType? issueType,
            int? firstSeenUnixSecs,
            int? lastSeenUnixSecs,
            string? qaComment,
            string? assigneeUserId)
        {
            this.AgentqaTicketId = agentqaTicketId ?? throw new global::System.ArgumentNullException(nameof(agentqaTicketId));
            this.WorkspaceId = workspaceId ?? throw new global::System.ArgumentNullException(nameof(workspaceId));
            this.OwnerUserId = ownerUserId ?? throw new global::System.ArgumentNullException(nameof(ownerUserId));
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.NeedsClustering = needsClustering;
            this.IssueType = issueType;
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
            this.ConversationIds = conversationIds ?? throw new global::System.ArgumentNullException(nameof(conversationIds));
            this.FirstSeenUnixSecs = firstSeenUnixSecs;
            this.LastSeenUnixSecs = lastSeenUnixSecs;
            this.QaComment = qaComment;
            this.TicketComments = ticketComments ?? throw new global::System.ArgumentNullException(nameof(ticketComments));
            this.TurnComments = turnComments ?? throw new global::System.ArgumentNullException(nameof(turnComments));
            this.Status = status;
            this.Source = source;
            this.AssigneeUserId = assigneeUserId;
            this.CreatedAtUnixSecs = createdAtUnixSecs;
            this.UpdatedAtUnixSecs = updatedAtUnixSecs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConversationTicketResponseModel" /> class.
        /// </summary>
        public AgentConversationTicketResponseModel()
        {
        }

    }
}