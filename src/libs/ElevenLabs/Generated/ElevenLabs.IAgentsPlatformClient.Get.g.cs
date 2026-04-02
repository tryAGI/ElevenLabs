#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Get Agent Summaries<br/>
        /// Returns summaries for the specified agents.
        /// </summary>
        /// <param name="agentIds">
        /// List of agent IDs to fetch summaries for
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetAsync(
            global::System.Collections.Generic.IList<string> agentIds,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}