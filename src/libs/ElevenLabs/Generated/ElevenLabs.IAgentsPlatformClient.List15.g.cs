#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// List Agent Branches<br/>
        /// Returns a list of branches an agent has
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="includeArchived">
        /// Whether archived branches should be included<br/>
        /// Default Value: false
        /// </param>
        /// <param name="limit">
        /// How many results at most should be returned<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="includeCommitStatus">
        /// Whether to compute how far each branch has diverged from main (commits_ahead/commits_behind). This walks the version DAG of every branch, so it is slow on agents with long histories and is off by default, leaving those fields null.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ListResponseAgentBranchSummary> List15Async(
            string agentId,
            bool? includeArchived = default,
            int? limit = default,
            bool? includeCommitStatus = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Agent Branches<br/>
        /// Returns a list of branches an agent has
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="includeArchived">
        /// Whether archived branches should be included<br/>
        /// Default Value: false
        /// </param>
        /// <param name="limit">
        /// How many results at most should be returned<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="includeCommitStatus">
        /// Whether to compute how far each branch has diverged from main (commits_ahead/commits_behind). This walks the version DAG of every branch, so it is slow on agents with long histories and is off by default, leaving those fields null.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.ListResponseAgentBranchSummary>> List15AsResponseAsync(
            string agentId,
            bool? includeArchived = default,
            int? limit = default,
            bool? includeCommitStatus = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}