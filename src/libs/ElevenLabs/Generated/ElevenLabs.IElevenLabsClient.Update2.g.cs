#nullable enable

namespace ElevenLabs
{
    public partial interface IElevenLabsClient
    {
        /// <summary>
        /// Update Agent Conversation Ticket<br/>
        /// Update a ticket's comment, status, and/or assignee. Requires editor access to the ticket's agent.
        /// </summary>
        /// <param name="agentqaTicketId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AgentConversationTicketResponseModel> Update2Async(
            string agentqaTicketId,

            global::ElevenLabs.PatchAgentConversationTicketRequestModel request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Agent Conversation Ticket<br/>
        /// Update a ticket's comment, status, and/or assignee. Requires editor access to the ticket's agent.
        /// </summary>
        /// <param name="agentqaTicketId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.AgentConversationTicketResponseModel>> Update2AsResponseAsync(
            string agentqaTicketId,

            global::ElevenLabs.PatchAgentConversationTicketRequestModel request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Agent Conversation Ticket<br/>
        /// Update a ticket's comment, status, and/or assignee. Requires editor access to the ticket's agent.
        /// </summary>
        /// <param name="agentqaTicketId"></param>
        /// <param name="status">
        /// If provided, updates the ticket status. Omit to leave unchanged.
        /// </param>
        /// <param name="assigneeUserId">
        /// If provided, updates who is responsible for resolving this ticket. Must be a workspace member with at least viewer access to the agent. Pass null to unassign. Omit to leave unchanged.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AgentConversationTicketResponseModel> Update2Async(
            string agentqaTicketId,
            global::ElevenLabs.AgentConversationTicketStatus? status = default,
            string? assigneeUserId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}