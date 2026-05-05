#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Get Knowledge Base Summaries By Ids<br/>
        /// Gets multiple knowledge base document summaries by their IDs.
        /// </summary>
        /// <param name="documentIds">
        /// The ids of knowledge base documents.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> Get11Async(
            global::System.Collections.Generic.IList<string> documentIds,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Knowledge Base Summaries By Ids<br/>
        /// Gets multiple knowledge base document summaries by their IDs.
        /// </summary>
        /// <param name="documentIds">
        /// The ids of knowledge base documents.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<string>> Get11AsResponseAsync(
            global::System.Collections.Generic.IList<string> documentIds,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}