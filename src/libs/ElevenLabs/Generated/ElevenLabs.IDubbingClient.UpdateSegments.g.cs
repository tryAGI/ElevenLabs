#nullable enable

namespace ElevenLabs
{
    public partial interface IDubbingClient
    {
        /// <summary>
        /// Update Dubbing Transcript Segments<br/>
        /// Enterprise only. Edit several source segments' text, speaker, or timing in one atomic request: every edit applies or none does. Bumps the project's `revision`, discards the affected translations in every language target, and marks any target that had already completed `stale`. No audio changes until you regenerate a target.
        /// </summary>
        /// <param name="projectId">
        /// Identifier of the dubbing project.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.DubbingBulkSourceSegmentUpdateResponse> UpdateSegmentsAsync(
            string projectId,

            global::ElevenLabs.DubbingBulkSegmentUpdateRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Dubbing Transcript Segments<br/>
        /// Enterprise only. Edit several source segments' text, speaker, or timing in one atomic request: every edit applies or none does. Bumps the project's `revision`, discards the affected translations in every language target, and marks any target that had already completed `stale`. No audio changes until you regenerate a target.
        /// </summary>
        /// <param name="projectId">
        /// Identifier of the dubbing project.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.DubbingBulkSourceSegmentUpdateResponse>> UpdateSegmentsAsResponseAsync(
            string projectId,

            global::ElevenLabs.DubbingBulkSegmentUpdateRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Dubbing Transcript Segments<br/>
        /// Enterprise only. Edit several source segments' text, speaker, or timing in one atomic request: every edit applies or none does. Bumps the project's `revision`, discards the affected translations in every language target, and marks any target that had already completed `stale`. No audio changes until you regenerate a target.
        /// </summary>
        /// <param name="projectId">
        /// Identifier of the dubbing project.
        /// </param>
        /// <param name="segments">
        /// Map of segment ID to the partial update to apply to that segment. At least one entry and at most 500.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.DubbingBulkSourceSegmentUpdateResponse> UpdateSegmentsAsync(
            string projectId,
            global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.DubbingSegmentUpdateRequest> segments,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}