#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Calculate Expected Llm Usage For An Agent<br/>
        /// Calculates expected number of LLM tokens needed for the specified agent.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.LLMUsageCalculatorResponseModel> CalculateAsync(
            string agentId,

            global::ElevenLabs.LLMUsageCalculatorRequestModel request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Calculate Expected Llm Usage For An Agent<br/>
        /// Calculates expected number of LLM tokens needed for the specified agent.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.LLMUsageCalculatorResponseModel>> CalculateAsResponseAsync(
            string agentId,

            global::ElevenLabs.LLMUsageCalculatorRequestModel request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Calculate Expected Llm Usage For An Agent<br/>
        /// Calculates expected number of LLM tokens needed for the specified agent.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="promptLength">
        /// Length of the prompt in characters.
        /// </param>
        /// <param name="numberOfPages">
        /// Pages of content in pdf documents OR urls in agent's Knowledge Base.
        /// </param>
        /// <param name="ragEnabled">
        /// Whether RAG is enabled.
        /// </param>
        /// <param name="serviceTier">
        /// Service tier to price against. Only affects models that offer the tier; others fall back to their standard price.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.LLMUsageCalculatorResponseModel> CalculateAsync(
            string agentId,
            int? promptLength = default,
            int? numberOfPages = default,
            bool? ragEnabled = default,
            global::ElevenLabs.LLMServiceTier? serviceTier = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}