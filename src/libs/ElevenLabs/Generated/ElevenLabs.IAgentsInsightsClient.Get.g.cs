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
        /// <param name="fromUnixSecs">
        /// Start of the window to view topics for. When set with to_unix_secs, per-day topics in the range are aggregated together.
        /// </param>
        /// <param name="toUnixSecs">
        /// End of the window to view topics for.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetAgentTopicsResponseModel> GetAsync(
            string agentId,
            int? fromUnixSecs = default,
            int? toUnixSecs = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Agent Conversation Topics<br/>
        /// Returns the latest topic discovery run results for a given agent.
        /// </summary>
        /// <param name="agentId">
        /// ID of the agent
        /// </param>
        /// <param name="fromUnixSecs">
        /// Start of the window to view topics for. When set with to_unix_secs, per-day topics in the range are aggregated together.
        /// </param>
        /// <param name="toUnixSecs">
        /// End of the window to view topics for.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.GetAgentTopicsResponseModel>> GetAsResponseAsync(
            string agentId,
            int? fromUnixSecs = default,
            int? toUnixSecs = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}