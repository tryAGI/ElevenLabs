#nullable enable

namespace ElevenLabs
{
    public partial interface IDubbingClient
    {
        /// <summary>
        /// Add Dubbing Transcript Segment<br/>
        /// Add a new source segment to the transcript.
        /// </summary>
        /// <param name="projectId">
        /// Identifier of the dubbing project.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.SourceSegmentUpdateResponse> CreateSegmentAsync(
            string projectId,

            global::ElevenLabs.SegmentCreateRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Dubbing Transcript Segment<br/>
        /// Add a new source segment to the transcript.
        /// </summary>
        /// <param name="projectId">
        /// Identifier of the dubbing project.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.SourceSegmentUpdateResponse>> CreateSegmentAsResponseAsync(
            string projectId,

            global::ElevenLabs.SegmentCreateRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Dubbing Transcript Segment<br/>
        /// Add a new source segment to the transcript.
        /// </summary>
        /// <param name="projectId">
        /// Identifier of the dubbing project.
        /// </param>
        /// <param name="text">
        /// The text of the new segment.
        /// </param>
        /// <param name="speakerId">
        /// Identifier of the segment's speaker.
        /// </param>
        /// <param name="startS">
        /// Start time of the segment, in seconds.
        /// </param>
        /// <param name="endS">
        /// End time of the segment, in seconds.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.SourceSegmentUpdateResponse> CreateSegmentAsync(
            string projectId,
            string text,
            string speakerId,
            double startS,
            double endS,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}