#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Get Agent Branch<br/>
        /// Get information about a single agent branch
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="branchId">
        /// Unique identifier for the branch.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AgentBranchResponse> Get19Async(
            string agentId,
            string branchId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}