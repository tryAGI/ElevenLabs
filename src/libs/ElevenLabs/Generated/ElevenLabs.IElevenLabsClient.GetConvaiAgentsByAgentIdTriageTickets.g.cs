#nullable enable

namespace ElevenLabs
{
    public partial interface IElevenLabsClient
    {
        /// <summary>
        /// List Agent Conversation Tickets<br/>
        /// List an agent's conversation triage tickets, ordered by most recently created first. These are tickets about the agent's own performance on a conversation (for triage with Architect), not tickets an agent opens for end users.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="pageSize">
        /// How many agent conversation tickets to return. Can not exceed 100.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="conversationId">
        /// Filter tickets by conversation id.
        /// </param>
        /// <param name="status">
        /// Filter tickets by status.
        /// </param>
        /// <param name="sources">
        /// Filter tickets by how they were raised (qa, agent, manual). Repeat the parameter to filter by multiple sources.
        /// </param>
        /// <param name="ownerUserId">
        /// Filter tickets by creator. Use 'agent' for agent-raised tickets.
        /// </param>
        /// <param name="assigneeUserId">
        /// Filter tickets by assignee. Use 'unassigned' for tickets with no assignee.
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetAgentConversationTicketsPageResponseModel> GetConvaiAgentsByAgentIdTriageTicketsAsync(
            string agentId,
            int? pageSize = default,
            string? conversationId = default,
            global::ElevenLabs.AgentConversationTicketStatus? status = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.AgentConversationTicketSource>? sources = default,
            string? ownerUserId = default,
            string? assigneeUserId = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Agent Conversation Tickets<br/>
        /// List an agent's conversation triage tickets, ordered by most recently created first. These are tickets about the agent's own performance on a conversation (for triage with Architect), not tickets an agent opens for end users.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="pageSize">
        /// How many agent conversation tickets to return. Can not exceed 100.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="conversationId">
        /// Filter tickets by conversation id.
        /// </param>
        /// <param name="status">
        /// Filter tickets by status.
        /// </param>
        /// <param name="sources">
        /// Filter tickets by how they were raised (qa, agent, manual). Repeat the parameter to filter by multiple sources.
        /// </param>
        /// <param name="ownerUserId">
        /// Filter tickets by creator. Use 'agent' for agent-raised tickets.
        /// </param>
        /// <param name="assigneeUserId">
        /// Filter tickets by assignee. Use 'unassigned' for tickets with no assignee.
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.GetAgentConversationTicketsPageResponseModel>> GetConvaiAgentsByAgentIdTriageTicketsAsResponseAsync(
            string agentId,
            int? pageSize = default,
            string? conversationId = default,
            global::ElevenLabs.AgentConversationTicketStatus? status = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.AgentConversationTicketSource>? sources = default,
            string? ownerUserId = default,
            string? assigneeUserId = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps GetConvaiAgentsByAgentIdTriageTicketsAsync as an IAsyncEnumerable&lt;global::ElevenLabs.AgentConversationTicketResponseModel&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="pageSize">
        /// How many agent conversation tickets to return. Can not exceed 100.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="conversationId">
        /// Filter tickets by conversation id.
        /// </param>
        /// <param name="status">
        /// Filter tickets by status.
        /// </param>
        /// <param name="sources">
        /// Filter tickets by how they were raised (qa, agent, manual). Repeat the parameter to filter by multiple sources.
        /// </param>
        /// <param name="ownerUserId">
        /// Filter tickets by creator. Use 'agent' for agent-raised tickets.
        /// </param>
        /// <param name="assigneeUserId">
        /// Filter tickets by assignee. Use 'unassigned' for tickets with no assignee.
        /// </param> 
        /// <param name="cursor">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::ElevenLabs.AgentConversationTicketResponseModel> GetConvaiAgentsByAgentIdTriageTicketsAutoPagingAsync(
            string agentId,             int? pageSize = default,
            string? conversationId = default,
            global::ElevenLabs.AgentConversationTicketStatus? status = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.AgentConversationTicketSource>? sources = default,
            string? ownerUserId = default,
            string? assigneeUserId = default,
            string? cursor = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}