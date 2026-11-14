#nullable enable

namespace ElevenLabs
{
    public partial interface IElevenLabsClient
    {
        /// <summary>
        /// List Agent Conversation Tickets<br/>
        /// List an agent's issues, ordered by most recently created first unless sorted by priority. These are issues about the agent's own performance on a conversation (to work on with Architect), not tickets an agent opens for end users.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="pageSize">
        /// How many agent issues to return. Can not exceed 100.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="conversationId">
        /// Filter agent issues by conversation id.
        /// </param>
        /// <param name="status">
        /// Filter agent issues by status.
        /// </param>
        /// <param name="sources">
        /// Filter agent issues by how they were raised (qa, agent, manual). Repeat the parameter to filter by multiple sources.
        /// </param>
        /// <param name="priorities">
        /// Filter agent issues by priority. Repeat the parameter to filter by multiple priorities.
        /// </param>
        /// <param name="sortBy">
        /// Order by most recently created, by priority (most urgent first, then most recently created), or by most recently reported (the newest report merged into the agent issue, else its creation).<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="ownerUserId">
        /// Filter agent issues by creator. Use 'agent' for agent-raised issues.
        /// </param>
        /// <param name="assigneeUserId">
        /// Filter agent issues by assignee. Use 'unassigned' for issues with no assignee.
        /// </param>
        /// <param name="issueType">
        /// Filter agent issues by type.
        /// </param>
        /// <param name="label">
        /// Filter agent issues by an exact label.
        /// </param>
        /// <param name="mergedIntoTicketId">
        /// Filter agent issues merged into this issue.
        /// </param>
        /// <param name="search">
        /// Case-insensitive free-text search across the agent issue's title, description, comments, and turn comments.
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetAgentConversationTicketsPageResponseModel> List3Async(
            string agentId,
            int? pageSize = default,
            string? conversationId = default,
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
        /// List Agent Conversation Tickets<br/>
        /// List an agent's issues, ordered by most recently created first unless sorted by priority. These are issues about the agent's own performance on a conversation (to work on with Architect), not tickets an agent opens for end users.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="pageSize">
        /// How many agent issues to return. Can not exceed 100.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="conversationId">
        /// Filter agent issues by conversation id.
        /// </param>
        /// <param name="status">
        /// Filter agent issues by status.
        /// </param>
        /// <param name="sources">
        /// Filter agent issues by how they were raised (qa, agent, manual). Repeat the parameter to filter by multiple sources.
        /// </param>
        /// <param name="priorities">
        /// Filter agent issues by priority. Repeat the parameter to filter by multiple priorities.
        /// </param>
        /// <param name="sortBy">
        /// Order by most recently created, by priority (most urgent first, then most recently created), or by most recently reported (the newest report merged into the agent issue, else its creation).<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="ownerUserId">
        /// Filter agent issues by creator. Use 'agent' for agent-raised issues.
        /// </param>
        /// <param name="assigneeUserId">
        /// Filter agent issues by assignee. Use 'unassigned' for issues with no assignee.
        /// </param>
        /// <param name="issueType">
        /// Filter agent issues by type.
        /// </param>
        /// <param name="label">
        /// Filter agent issues by an exact label.
        /// </param>
        /// <param name="mergedIntoTicketId">
        /// Filter agent issues merged into this issue.
        /// </param>
        /// <param name="search">
        /// Case-insensitive free-text search across the agent issue's title, description, comments, and turn comments.
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.GetAgentConversationTicketsPageResponseModel>> List3AsResponseAsync(
            string agentId,
            int? pageSize = default,
            string? conversationId = default,
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
        /// Wraps List3Async as an IAsyncEnumerable&lt;global::ElevenLabs.AgentConversationTicketResponseModel&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="pageSize">
        /// How many agent issues to return. Can not exceed 100.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="conversationId">
        /// Filter agent issues by conversation id.
        /// </param>
        /// <param name="status">
        /// Filter agent issues by status.
        /// </param>
        /// <param name="sources">
        /// Filter agent issues by how they were raised (qa, agent, manual). Repeat the parameter to filter by multiple sources.
        /// </param>
        /// <param name="priorities">
        /// Filter agent issues by priority. Repeat the parameter to filter by multiple priorities.
        /// </param>
        /// <param name="sortBy">
        /// Order by most recently created, by priority (most urgent first, then most recently created), or by most recently reported (the newest report merged into the agent issue, else its creation).<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="ownerUserId">
        /// Filter agent issues by creator. Use 'agent' for agent-raised issues.
        /// </param>
        /// <param name="assigneeUserId">
        /// Filter agent issues by assignee. Use 'unassigned' for issues with no assignee.
        /// </param>
        /// <param name="issueType">
        /// Filter agent issues by type.
        /// </param>
        /// <param name="label">
        /// Filter agent issues by an exact label.
        /// </param>
        /// <param name="mergedIntoTicketId">
        /// Filter agent issues merged into this issue.
        /// </param>
        /// <param name="search">
        /// Case-insensitive free-text search across the agent issue's title, description, comments, and turn comments.
        /// </param>
        /// <param name="cursor">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::ElevenLabs.AgentConversationTicketResponseModel> List3AutoPagingAsync(
            string agentId,             int? pageSize = default,
            string? conversationId = default,
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