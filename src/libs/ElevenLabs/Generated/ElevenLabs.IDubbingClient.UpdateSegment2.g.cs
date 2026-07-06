#nullable enable

namespace ElevenLabs
{
    public partial interface IDubbingClient
    {
        /// <summary>
        /// Update Dubbing Target Transcript Segment<br/>
        /// Edit a segment's translation for a language target.
        /// </summary>
        /// <param name="projectId">
        /// Identifier of the dubbing project.
        /// </param>
        /// <param name="languageId">
        /// Identifier of the language target.
        /// </param>
        /// <param name="segmentId">
        /// Identifier of the segment to edit.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.DubbingTargetSegmentUpdateResponse> UpdateSegment2Async(
            string projectId,
            string languageId,
            string segmentId,

            global::ElevenLabs.DubbingTargetSegmentUpdateRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Dubbing Target Transcript Segment<br/>
        /// Edit a segment's translation for a language target.
        /// </summary>
        /// <param name="projectId">
        /// Identifier of the dubbing project.
        /// </param>
        /// <param name="languageId">
        /// Identifier of the language target.
        /// </param>
        /// <param name="segmentId">
        /// Identifier of the segment to edit.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.DubbingTargetSegmentUpdateResponse>> UpdateSegment2AsResponseAsync(
            string projectId,
            string languageId,
            string segmentId,

            global::ElevenLabs.DubbingTargetSegmentUpdateRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Dubbing Target Transcript Segment<br/>
        /// Edit a segment's translation for a language target.
        /// </summary>
        /// <param name="projectId">
        /// Identifier of the dubbing project.
        /// </param>
        /// <param name="languageId">
        /// Identifier of the language target.
        /// </param>
        /// <param name="segmentId">
        /// Identifier of the segment to edit.
        /// </param>
        /// <param name="translation">
        /// New translated text, or null to mark the segment for re-translation.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.DubbingTargetSegmentUpdateResponse> UpdateSegment2Async(
            string projectId,
            string languageId,
            string segmentId,
            string? translation = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}