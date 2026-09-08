#nullable enable

namespace ElevenLabs
{
    public partial interface IElevenLabsClient
    {
        /// <summary>
        /// List Workspace Conversation Tickets<br/>
        /// List conversation triage tickets across every agent in the workspace, ordered by most recently created first. Use this to build a workspace-wide view (for example, tickets assigned to the caller); for a single agent's tickets, use the per-agent endpoint instead. Tickets for agents the caller cannot access are omitted.
        /// </summary>
        /// <param name="pageSize">
        /// How many agent conversation tickets to return. Can not exceed 100.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="status">
        /// Filter tickets by status.
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
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetAgentConversationTicketsPageResponseModel> ListForWorkspaceAsync(
            int? pageSize = default,
            global::ElevenLabs.AgentConversationTicketStatus? status = default,
            string? assigneeUserId = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Workspace Conversation Tickets<br/>
        /// List conversation triage tickets across every agent in the workspace, ordered by most recently created first. Use this to build a workspace-wide view (for example, tickets assigned to the caller); for a single agent's tickets, use the per-agent endpoint instead. Tickets for agents the caller cannot access are omitted.
        /// </summary>
        /// <param name="pageSize">
        /// How many agent conversation tickets to return. Can not exceed 100.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="status">
        /// Filter tickets by status.
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
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.GetAgentConversationTicketsPageResponseModel>> ListForWorkspaceAsResponseAsync(
            int? pageSize = default,
            global::ElevenLabs.AgentConversationTicketStatus? status = default,
            string? assigneeUserId = default,
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
        /// <param name="status">
        /// Filter tickets by status.
        /// </param>
        /// <param name="assigneeUserId">
        /// Filter tickets by assignee. Use 'unassigned' for tickets with no assignee.
        /// </param>
        /// <param name="cursor">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::ElevenLabs.AgentConversationTicketResponseModel> ListForWorkspaceAutoPagingAsync(
              int? pageSize = default,
            global::ElevenLabs.AgentConversationTicketStatus? status = default,
            string? assigneeUserId = default,
            string? cursor = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}