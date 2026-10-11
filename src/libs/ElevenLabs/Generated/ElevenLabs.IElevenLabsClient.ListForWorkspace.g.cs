#nullable enable

namespace ElevenLabs
{
    public partial interface IElevenLabsClient
    {
        /// <summary>
        /// List Workspace Conversation Tickets<br/>
        /// List conversation triage tickets across every agent in the workspace, ordered by most recently created first. Use this to build a workspace-wide view (for example, tickets assigned to the caller). Supports the same filters, sorting and search as the per-agent endpoint. Tickets for agents the caller cannot access are omitted.
        /// </summary>
        /// <param name="pageSize">
        /// How many agent conversation tickets to return. Can not exceed 100.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="agentId">
        /// Only tickets for this agent.
        /// </param>
        /// <param name="status">
        /// Filter tickets by status.
        /// </param>
        /// <param name="sources">
        /// Filter tickets by how they were raised (qa, agent, manual). Repeat the parameter to filter by multiple sources.
        /// </param>
        /// <param name="priorities">
        /// Filter tickets by priority. Repeat the parameter to filter by multiple priorities.
        /// </param>
        /// <param name="sortBy">
        /// Order by most recently created, or by priority (most urgent first, then most recently created).<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="ownerUserId">
        /// Filter tickets by creator. Use 'agent' for agent-raised tickets.
        /// </param>
        /// <param name="assigneeUserId">
        /// Filter tickets by assignee. Use 'unassigned' for tickets with no assignee.
        /// </param>
        /// <param name="issueType">
        /// Filter clusters by issue type.
        /// </param>
        /// <param name="label">
        /// Filter tickets by an exact label.
        /// </param>
        /// <param name="mergedIntoTicketId">
        /// Filter tickets merged into this ticket.
        /// </param>
        /// <param name="search">
        /// Case-insensitive free-text search across the ticket's title, description, comments, and turn comments.
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetAgentConversationTicketsPageResponseModel> ListForWorkspaceAsync(
            int? pageSize = default,
            string? agentId = default,
            global::ElevenLabs.AgentConversationTicketStatus? status = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.AgentConversationTicketSource>? sources = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.AgentConversationTicketPriority>? priorities = default,
            global::ElevenLabs.AgentConversationTicketSortBy? sortBy = default,
            string? ownerUserId = default,
            string? assigneeUserId = default,
            global::ElevenLabs.AgentConversationTicketIssueType? issueType = default,
            string? label = default,
            string? mergedIntoTicketId = default,
            string? search = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Workspace Conversation Tickets<br/>
        /// List conversation triage tickets across every agent in the workspace, ordered by most recently created first. Use this to build a workspace-wide view (for example, tickets assigned to the caller). Supports the same filters, sorting and search as the per-agent endpoint. Tickets for agents the caller cannot access are omitted.
        /// </summary>
        /// <param name="pageSize">
        /// How many agent conversation tickets to return. Can not exceed 100.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="agentId">
        /// Only tickets for this agent.
        /// </param>
        /// <param name="status">
        /// Filter tickets by status.
        /// </param>
        /// <param name="sources">
        /// Filter tickets by how they were raised (qa, agent, manual). Repeat the parameter to filter by multiple sources.
        /// </param>
        /// <param name="priorities">
        /// Filter tickets by priority. Repeat the parameter to filter by multiple priorities.
        /// </param>
        /// <param name="sortBy">
        /// Order by most recently created, or by priority (most urgent first, then most recently created).<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="ownerUserId">
        /// Filter tickets by creator. Use 'agent' for agent-raised tickets.
        /// </param>
        /// <param name="assigneeUserId">
        /// Filter tickets by assignee. Use 'unassigned' for tickets with no assignee.
        /// </param>
        /// <param name="issueType">
        /// Filter clusters by issue type.
        /// </param>
        /// <param name="label">
        /// Filter tickets by an exact label.
        /// </param>
        /// <param name="mergedIntoTicketId">
        /// Filter tickets merged into this ticket.
        /// </param>
        /// <param name="search">
        /// Case-insensitive free-text search across the ticket's title, description, comments, and turn comments.
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.GetAgentConversationTicketsPageResponseModel>> ListForWorkspaceAsResponseAsync(
            int? pageSize = default,
            string? agentId = default,
            global::ElevenLabs.AgentConversationTicketStatus? status = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.AgentConversationTicketSource>? sources = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.AgentConversationTicketPriority>? priorities = default,
            global::ElevenLabs.AgentConversationTicketSortBy? sortBy = default,
            string? ownerUserId = default,
            string? assigneeUserId = default,
            global::ElevenLabs.AgentConversationTicketIssueType? issueType = default,
            string? label = default,
            string? mergedIntoTicketId = default,
            string? search = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps ListForWorkspaceAsync as an IAsyncEnumerable&lt;global::ElevenLabs.AgentConversationTicketResponseModel&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="pageSize">
        /// How many agent conversation tickets to return. Can not exceed 100.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="agentId">
        /// Only tickets for this agent.
        /// </param>
        /// <param name="status">
        /// Filter tickets by status.
        /// </param>
        /// <param name="sources">
        /// Filter tickets by how they were raised (qa, agent, manual). Repeat the parameter to filter by multiple sources.
        /// </param>
        /// <param name="priorities">
        /// Filter tickets by priority. Repeat the parameter to filter by multiple priorities.
        /// </param>
        /// <param name="sortBy">
        /// Order by most recently created, or by priority (most urgent first, then most recently created).<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="ownerUserId">
        /// Filter tickets by creator. Use 'agent' for agent-raised tickets.
        /// </param>
        /// <param name="assigneeUserId">
        /// Filter tickets by assignee. Use 'unassigned' for tickets with no assignee.
        /// </param>
        /// <param name="issueType">
        /// Filter clusters by issue type.
        /// </param>
        /// <param name="label">
        /// Filter tickets by an exact label.
        /// </param>
        /// <param name="mergedIntoTicketId">
        /// Filter tickets merged into this ticket.
        /// </param>
        /// <param name="search">
        /// Case-insensitive free-text search across the ticket's title, description, comments, and turn comments.
        /// </param>
        /// <param name="cursor">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::ElevenLabs.AgentConversationTicketResponseModel> ListForWorkspaceAutoPagingAsync(
              int? pageSize = default,
            string? agentId = default,
            global::ElevenLabs.AgentConversationTicketStatus? status = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.AgentConversationTicketSource>? sources = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.AgentConversationTicketPriority>? priorities = default,
            global::ElevenLabs.AgentConversationTicketSortBy? sortBy = default,
            string? ownerUserId = default,
            string? assigneeUserId = default,
            global::ElevenLabs.AgentConversationTicketIssueType? issueType = default,
            string? label = default,
            string? mergedIntoTicketId = default,
            string? search = default,
            string? cursor = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}