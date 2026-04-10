#nullable enable

namespace ElevenLabs
{
    public partial interface IDubbingClient
    {
        /// <summary>
        /// Translates All Or Some Segments And Languages<br/>
        /// Regenerate the translations for either the entire resource or the specified segments/languages. Will automatically transcribe missing transcriptions. Will not automatically regenerate the dubs.
        /// </summary>
        /// <param name="dubbingId">
        /// ID of the dubbing project.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.SegmentTranslationResponse> TranslateAsync(
            string dubbingId,

            global::ElevenLabs.BodyTranslatesAllOrSomeSegmentsAndLanguagesV1DubbingResourceDubbingIdTranslatePost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Translates All Or Some Segments And Languages<br/>
        /// Regenerate the translations for either the entire resource or the specified segments/languages. Will automatically transcribe missing transcriptions. Will not automatically regenerate the dubs.
        /// </summary>
        /// <param name="dubbingId">
        /// ID of the dubbing project.
        /// </param>
        /// <param name="segments">
        /// Translate only this list of segments.
        /// </param>
        /// <param name="languages">
        /// Translate only these languages for each segment.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.SegmentTranslationResponse> TranslateAsync(
            string dubbingId,
            global::System.Collections.Generic.IList<string> segments,
            global::System.Collections.Generic.IList<string>? languages = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}