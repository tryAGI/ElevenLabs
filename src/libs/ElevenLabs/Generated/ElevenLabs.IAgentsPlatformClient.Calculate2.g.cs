#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Calculate Expected Llm Usage<br/>
        /// Returns a list of LLM models and the expected cost for using them based on the provided values.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.LLMUsageCalculatorResponseModel> Calculate2Async(

            global::ElevenLabs.LLMUsageCalculatorPublicRequestModel request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Calculate Expected Llm Usage<br/>
        /// Returns a list of LLM models and the expected cost for using them based on the provided values.
        /// </summary>
        /// <param name="promptLength">
        /// Length of the prompt in characters.
        /// </param>
        /// <param name="numberOfPages">
        /// Pages of content in PDF documents or URLs in the agent's knowledge base.
        /// </param>
        /// <param name="ragEnabled">
        /// Whether RAG is enabled.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.LLMUsageCalculatorResponseModel> Calculate2Async(
            int promptLength,
            int numberOfPages,
            bool ragEnabled,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}