#nullable enable

namespace ElevenLabs
{
    public partial interface IDubbingClient
    {
        /// <summary>
        /// Dubs All Or Some Segments And Languages<br/>
        /// Regenerate the dubs for either the entire resource or the specified segments/languages. Will automatically transcribe and translate any missing transcriptions and translations.
        /// </summary>
        /// <param name="dubbingId">
        /// ID of the dubbing project.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.SegmentDubResponse> DubAsync(
            string dubbingId,

            global::ElevenLabs.BodyDubsAllOrSomeSegmentsAndLanguagesV1DubbingResourceDubbingIdDubPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Dubs All Or Some Segments And Languages<br/>
        /// Regenerate the dubs for either the entire resource or the specified segments/languages. Will automatically transcribe and translate any missing transcriptions and translations.
        /// </summary>
        /// <param name="dubbingId">
        /// ID of the dubbing project.
        /// </param>
        /// <param name="segments">
        /// Dub only this list of segments.
        /// </param>
        /// <param name="languages">
        /// Dub only these languages for each segment.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.SegmentDubResponse> DubAsync(
            string dubbingId,
            global::System.Collections.Generic.IList<string> segments,
            global::System.Collections.Generic.IList<string>? languages = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}