#nullable enable

namespace ElevenLabs
{
    public partial interface IDubbingClient
    {
        /// <summary>
        /// Get Dubbing<br/>
        /// Returns metadata about a dubbing project, including whether it's still in progress or not
        /// </summary>
        /// <param name="dubbingId">
        /// ID of the dubbing project.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.DubbingMetadataResponse> Get2Async(
            string dubbingId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}