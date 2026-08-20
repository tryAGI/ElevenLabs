#nullable enable

namespace ElevenLabs
{
    public partial interface IElevenLabsClient
    {
        /// <summary>
        /// Add Comment To Agent Conversation Ticket<br/>
        /// Append a comment discussing how to resolve the ticket. Requires viewer access to the ticket's agent.
        /// </summary>
        /// <param name="agentqaTicketId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AgentConversationTicketResponseModel> CreateConvaiTriageTicketsByAgentqaTicketIdCommentsAsync(
            string agentqaTicketId,

            global::ElevenLabs.AddTicketCommentRequestModel request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Comment To Agent Conversation Ticket<br/>
        /// Append a comment discussing how to resolve the ticket. Requires viewer access to the ticket's agent.
        /// </summary>
        /// <param name="agentqaTicketId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.AgentConversationTicketResponseModel>> CreateConvaiTriageTicketsByAgentqaTicketIdCommentsAsResponseAsync(
            string agentqaTicketId,

            global::ElevenLabs.AddTicketCommentRequestModel request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Comment To Agent Conversation Ticket<br/>
        /// Append a comment discussing how to resolve the ticket. Requires viewer access to the ticket's agent.
        /// </summary>
        /// <param name="agentqaTicketId"></param>
        /// <param name="comment">
        /// A comment discussing how to resolve the ticket.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AgentConversationTicketResponseModel> CreateConvaiTriageTicketsByAgentqaTicketIdCommentsAsync(
            string agentqaTicketId,
            string comment,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}