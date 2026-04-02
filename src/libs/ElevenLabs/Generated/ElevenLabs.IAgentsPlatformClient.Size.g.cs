#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Returns The Size Of The Agent'S Knowledge Base<br/>
        /// Returns the number of pages in the agent's knowledge base.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetAgentKnowledgebaseSizeResponseModel> SizeAsync(
            string agentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}