#nullable enable

namespace ElevenLabs
{
    public partial interface IDubbingClient
    {
        /// <summary>
        /// Create A Segment For The Speaker<br/>
        /// Creates a new segment in dubbing resource with a start and end time for the speaker in every available language. Does not automatically generate transcripts/translations/audio.
        /// </summary>
        /// <param name="dubbingId">
        /// ID of the dubbing project.
        /// </param>
        /// <param name="speakerId">
        /// ID of the speaker.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.SegmentCreateResponse> CreateAsync(
            string dubbingId,
            string speakerId,

            global::ElevenLabs.SegmentCreatePayload request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create A Segment For The Speaker<br/>
        /// Creates a new segment in dubbing resource with a start and end time for the speaker in every available language. Does not automatically generate transcripts/translations/audio.
        /// </summary>
        /// <param name="dubbingId">
        /// ID of the dubbing project.
        /// </param>
        /// <param name="speakerId">
        /// ID of the speaker.
        /// </param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="text"></param>
        /// <param name="translations"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.SegmentCreateResponse> CreateAsync(
            string dubbingId,
            string speakerId,
            double startTime,
            double endTime,
            string? text = default,
            global::System.Collections.Generic.Dictionary<string, string>? translations = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}