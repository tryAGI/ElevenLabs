#nullable enable

namespace ElevenLabs
{
    public partial interface IDubbingClient
    {
        /// <summary>
        /// Update Dubbing Transcript Segment<br/>
        /// Edit a source segment's text, speaker, or timing.
        /// </summary>
        /// <param name="projectId">
        /// Identifier of the dubbing project.
        /// </param>
        /// <param name="segmentId">
        /// Identifier of the segment to edit.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.SourceSegmentUpdateResponse> UpdateSegmentAsync(
            string projectId,
            string segmentId,

            global::ElevenLabs.SegmentUpdateRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Dubbing Transcript Segment<br/>
        /// Edit a source segment's text, speaker, or timing.
        /// </summary>
        /// <param name="projectId">
        /// Identifier of the dubbing project.
        /// </param>
        /// <param name="segmentId">
        /// Identifier of the segment to edit.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.SourceSegmentUpdateResponse>> UpdateSegmentAsResponseAsync(
            string projectId,
            string segmentId,

            global::ElevenLabs.SegmentUpdateRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Dubbing Transcript Segment<br/>
        /// Edit a source segment's text, speaker, or timing.
        /// </summary>
        /// <param name="projectId">
        /// Identifier of the dubbing project.
        /// </param>
        /// <param name="segmentId">
        /// Identifier of the segment to edit.
        /// </param>
        /// <param name="text">
        /// New text for the segment.
        /// </param>
        /// <param name="speakerId">
        /// New speaker id for the segment.
        /// </param>
        /// <param name="startS">
        /// New start time, in seconds.
        /// </param>
        /// <param name="endS">
        /// New end time, in seconds.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.SourceSegmentUpdateResponse> UpdateSegmentAsync(
            string projectId,
            string segmentId,
            string? text = default,
            string? speakerId = default,
            double? startS = default,
            double? endS = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}