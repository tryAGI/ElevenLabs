#nullable enable

namespace ElevenLabs
{
    public partial interface IElevenLabsClient
    {
        /// <summary>
        /// Add Turn Comment To Agent Conversation Ticket<br/>
        /// Append a turn-level comment to a ticket. Requires viewer access to the ticket's agent.
        /// </summary>
        /// <param name="agentqaTicketId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AgentConversationTicketResponseModel> CreateConvaiTriageTicketsByAgentqaTicketIdTurnCommentsAsync(
            string agentqaTicketId,

            global::ElevenLabs.AddTurnCommentRequestModel request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Turn Comment To Agent Conversation Ticket<br/>
        /// Append a turn-level comment to a ticket. Requires viewer access to the ticket's agent.
        /// </summary>
        /// <param name="agentqaTicketId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.AgentConversationTicketResponseModel>> CreateConvaiTriageTicketsByAgentqaTicketIdTurnCommentsAsResponseAsync(
            string agentqaTicketId,

            global::ElevenLabs.AddTurnCommentRequestModel request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Turn Comment To Agent Conversation Ticket<br/>
        /// Append a turn-level comment to a ticket. Requires viewer access to the ticket's agent.
        /// </summary>
        /// <param name="agentqaTicketId"></param>
        /// <param name="turnIndex">
        /// Zero-based index of the transcript turn this comment refers to.
        /// </param>
        /// <param name="comment">
        /// What went wrong at this turn.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AgentConversationTicketResponseModel> CreateConvaiTriageTicketsByAgentqaTicketIdTurnCommentsAsync(
            string agentqaTicketId,
            int turnIndex,
            string comment,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}