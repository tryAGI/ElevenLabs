#nullable enable

namespace ElevenLabs
{
    public partial interface IDubbingClient
    {
        /// <summary>
        /// Deletes A Single Segment<br/>
        /// Deletes a single segment from the dubbing.
        /// </summary>
        /// <param name="dubbingId">
        /// ID of the dubbing project.
        /// </param>
        /// <param name="segmentId">
        /// ID of the segment
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.SegmentDeleteResponse> DeleteAsync(
            string dubbingId,
            string segmentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}