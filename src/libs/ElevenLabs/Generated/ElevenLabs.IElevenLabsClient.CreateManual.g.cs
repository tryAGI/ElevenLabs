#nullable enable

namespace ElevenLabs
{
    public partial interface IElevenLabsClient
    {
        /// <summary>
        /// Create Manual Agent Ticket<br/>
        /// Manually raise a follow-up ticket against an agent, not tied to any conversation (for example a task like 'add the KB about X'). The comment is shown as the ticket title. Requires viewer access to the agent.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AgentConversationTicketResponseModel> CreateManualAsync(
            string agentId,

            global::ElevenLabs.CreateManualTicketRequestModel request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Manual Agent Ticket<br/>
        /// Manually raise a follow-up ticket against an agent, not tied to any conversation (for example a task like 'add the KB about X'). The comment is shown as the ticket title. Requires viewer access to the agent.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.AgentConversationTicketResponseModel>> CreateManualAsResponseAsync(
            string agentId,

            global::ElevenLabs.CreateManualTicketRequestModel request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Manual Agent Ticket<br/>
        /// Manually raise a follow-up ticket against an agent, not tied to any conversation (for example a task like 'add the KB about X'). The comment is shown as the ticket title. Requires viewer access to the agent.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="qaComment">
        /// What the ticket is about, e.g. a follow-up task for the agent. This is shown as the ticket title.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AgentConversationTicketResponseModel> CreateManualAsync(
            string agentId,
            string qaComment,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}