#nullable enable

namespace ElevenLabs
{
    public partial interface IDubbingClient
    {
        /// <summary>
        /// Modify A Single Segment<br/>
        /// Modifies a single segment with new text and/or start/end times. Will update the values for only a specific language of a segment. Does not automatically regenerate the dub.
        /// </summary>
        /// <param name="dubbingId">
        /// ID of the dubbing project.
        /// </param>
        /// <param name="segmentId">
        /// ID of the segment
        /// </param>
        /// <param name="language">
        /// ID of the language.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.SegmentUpdateResponse> UpdateAsync(
            string dubbingId,
            string segmentId,
            string language,

            global::ElevenLabs.SegmentUpdatePayload request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Modify A Single Segment<br/>
        /// Modifies a single segment with new text and/or start/end times. Will update the values for only a specific language of a segment. Does not automatically regenerate the dub.
        /// </summary>
        /// <param name="dubbingId">
        /// ID of the dubbing project.
        /// </param>
        /// <param name="segmentId">
        /// ID of the segment
        /// </param>
        /// <param name="language">
        /// ID of the language.
        /// </param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="text"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.SegmentUpdateResponse> UpdateAsync(
            string dubbingId,
            string segmentId,
            string language,
            double? startTime = default,
            double? endTime = default,
            string? text = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}