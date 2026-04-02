#nullable enable

namespace ElevenLabs
{
    public partial interface IDubbingClient
    {
        /// <summary>
        /// Transcribes Segments<br/>
        /// Regenerate the transcriptions for the specified segments. Does not automatically regenerate translations or dubs.
        /// </summary>
        /// <param name="dubbingId">
        /// ID of the dubbing project.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.SegmentTranscriptionResponse> TranscribeAsync(
            string dubbingId,

            global::ElevenLabs.BodyTranscribesSegmentsV1DubbingResourceDubbingIdTranscribePost request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Transcribes Segments<br/>
        /// Regenerate the transcriptions for the specified segments. Does not automatically regenerate translations or dubs.
        /// </summary>
        /// <param name="dubbingId">
        /// ID of the dubbing project.
        /// </param>
        /// <param name="segments">
        /// Transcribe this specific list of segments.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.SegmentTranscriptionResponse> TranscribeAsync(
            string dubbingId,
            global::System.Collections.Generic.IList<string> segments,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}