#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsInsightsClient
    {
        /// <summary>
        /// Get Agent Conversation Topics<br/>
        /// Returns the latest topic discovery run results for a given agent.
        /// </summary>
        /// <param name="agentId">
        /// ID of the agent
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetAgentTopicsResponseModel> GetAsync(
            string agentId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}