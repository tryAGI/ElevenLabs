#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Get Shareable Agent Link<br/>
        /// Get the current link used to share the agent with others
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetAgentLinkResponseModel> Get4Async(
            string agentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}