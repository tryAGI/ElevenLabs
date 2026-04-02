#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Delete Agent<br/>
        /// Delete an agent
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAsync(
            string agentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}