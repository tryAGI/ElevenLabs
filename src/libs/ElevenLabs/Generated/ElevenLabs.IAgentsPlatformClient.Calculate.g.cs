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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.LLMUsageCalculatorResponseModel> CalculateAsync(
            string agentId,

            global::ElevenLabs.LLMUsageCalculatorRequestModel request,
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.LLMUsageCalculatorResponseModel> CalculateAsync(
            string agentId,
            int? promptLength = default,
            int? numberOfPages = default,
            bool? ragEnabled = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}