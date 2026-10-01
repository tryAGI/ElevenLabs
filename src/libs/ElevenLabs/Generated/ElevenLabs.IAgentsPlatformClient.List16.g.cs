#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// List Agent Deployments<br/>
        /// List the traffic split history of an agent, newest first
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="page">
        /// Page number, starting at 1<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// How many results at most should be returned<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ListResponseAgentDeploymentHistoryItem> List16Async(
            string agentId,
            int? page = default,
            int? pageSize = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Agent Deployments<br/>
        /// List the traffic split history of an agent, newest first
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="page">
        /// Page number, starting at 1<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// How many results at most should be returned<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.ListResponseAgentDeploymentHistoryItem>> List16AsResponseAsync(
            string agentId,
            int? page = default,
            int? pageSize = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps List16Async as an IAsyncEnumerable&lt;global::ElevenLabs.AgentDeploymentHistoryItem&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="pageSize">
        /// How many results at most should be returned<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="page">Initial page number to start enumerating from. Defaults to 1.</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::ElevenLabs.AgentDeploymentHistoryItem> List16AutoPagingAsync(
            string agentId,             int? pageSize = default,
            int? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}