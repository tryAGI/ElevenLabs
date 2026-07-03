#nullable enable

namespace ElevenLabs
{
    public partial interface IDubbingClient
    {
        /// <summary>
        /// Get Dubbing Language Target<br/>
        /// Full language-target detail.
        /// </summary>
        /// <param name="projectId">
        /// Identifier of the parent dubbing project.
        /// </param>
        /// <param name="languageId">
        /// Identifier of the language target to fetch.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.LanguageResponse> Get2Async(
            string projectId,
            string languageId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Dubbing Language Target<br/>
        /// Full language-target detail.
        /// </summary>
        /// <param name="projectId">
        /// Identifier of the parent dubbing project.
        /// </param>
        /// <param name="languageId">
        /// Identifier of the language target to fetch.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.LanguageResponse>> Get2AsResponseAsync(
            string projectId,
            string languageId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}