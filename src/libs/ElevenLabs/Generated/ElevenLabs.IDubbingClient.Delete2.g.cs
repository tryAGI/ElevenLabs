#nullable enable

namespace ElevenLabs
{
    public partial interface IDubbingClient
    {
        /// <summary>
        /// Delete Dubbing Language Target<br/>
        /// Delete a language target.
        /// </summary>
        /// <param name="projectId">
        /// Identifier of the parent dubbing project.
        /// </param>
        /// <param name="languageId">
        /// Identifier of the language target to delete.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task Delete2Async(
            string projectId,
            string languageId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Dubbing Language Target<br/>
        /// Delete a language target.
        /// </summary>
        /// <param name="projectId">
        /// Identifier of the parent dubbing project.
        /// </param>
        /// <param name="languageId">
        /// Identifier of the language target to delete.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse> Delete2AsResponseAsync(
            string projectId,
            string languageId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}