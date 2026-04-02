#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Get Live Count<br/>
        /// Get the live count of the ongoing conversations.
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent to restrict the analytics to.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetLiveCountResponse> Get8Async(
            string? agentId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}