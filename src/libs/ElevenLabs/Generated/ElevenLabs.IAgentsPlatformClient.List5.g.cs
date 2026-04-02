#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// List Available Llms<br/>
        /// Returns a list of available LLM models that can be used with agents, including their capabilities and any deprecation status. The response is filtered based on the data residency of the deployment and any compliance requirements (e.g. HIPAA) of the workspace subscription.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.LLMListResponseModelInput> List5Async(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}