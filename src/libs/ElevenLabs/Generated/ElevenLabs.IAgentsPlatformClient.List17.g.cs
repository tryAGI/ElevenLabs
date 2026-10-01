#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// List Proposals<br/>
        /// List the proposals for an agent, newest first.
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="status">
        /// Only return proposals with this status.
        /// </param>
        /// <param name="search">
        /// Case-insensitive substring match over title and description.
        /// </param>
        /// <param name="pageSize">
        /// How many results at most should be returned<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.PaginatedResultAgentMergeProposalResponse> List17Async(
            string agentId,
            global::ElevenLabs.MergeProposalStatus? status = default,
            string? search = default,
            int? pageSize = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Proposals<br/>
        /// List the proposals for an agent, newest first.
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="status">
        /// Only return proposals with this status.
        /// </param>
        /// <param name="search">
        /// Case-insensitive substring match over title and description.
        /// </param>
        /// <param name="pageSize">
        /// How many results at most should be returned<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.PaginatedResultAgentMergeProposalResponse>> List17AsResponseAsync(
            string agentId,
            global::ElevenLabs.MergeProposalStatus? status = default,
            string? search = default,
            int? pageSize = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps List17Async as an IAsyncEnumerable&lt;global::ElevenLabs.AgentMergeProposalResponse&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="status">
        /// Only return proposals with this status.
        /// </param>
        /// <param name="search">
        /// Case-insensitive substring match over title and description.
        /// </param>
        /// <param name="pageSize">
        /// How many results at most should be returned<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="cursor">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::ElevenLabs.AgentMergeProposalResponse> List17AutoPagingAsync(
            string agentId,             global::ElevenLabs.MergeProposalStatus? status = default,
            string? search = default,
            int? pageSize = default,
            string? cursor = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}