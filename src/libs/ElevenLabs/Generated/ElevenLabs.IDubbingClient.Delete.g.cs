#nullable enable

namespace ElevenLabs
{
    public partial interface IDubbingClient
    {
        /// <summary>
        /// Delete Dubbing Project<br/>
        /// Delete a project, every language target under it, and their stored media and outputs. This cannot be undone, and a dub already running is still billed.
        /// </summary>
        /// <param name="projectId">
        /// Identifier of the dubbing project to delete.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAsync(
            string projectId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Dubbing Project<br/>
        /// Delete a project, every language target under it, and their stored media and outputs. This cannot be undone, and a dub already running is still billed.
        /// </summary>
        /// <param name="projectId">
        /// Identifier of the dubbing project to delete.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse> DeleteAsResponseAsync(
            string projectId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}