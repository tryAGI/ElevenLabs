#nullable enable

namespace ElevenLabs
{
    public partial interface IDubbingClient
    {
        /// <summary>
        /// Regenerate Dubbing Target<br/>
        /// Re-dub a target from its edited transcript (charged like a generation).
        /// </summary>
        /// <param name="projectId">
        /// Identifier of the dubbing project.
        /// </param>
        /// <param name="languageId">
        /// Identifier of the language target.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.LanguageResponse> RegenerateAsync(
            string projectId,
            string languageId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Regenerate Dubbing Target<br/>
        /// Re-dub a target from its edited transcript (charged like a generation).
        /// </summary>
        /// <param name="projectId">
        /// Identifier of the dubbing project.
        /// </param>
        /// <param name="languageId">
        /// Identifier of the language target.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.LanguageResponse>> RegenerateAsResponseAsync(
            string projectId,
            string languageId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}