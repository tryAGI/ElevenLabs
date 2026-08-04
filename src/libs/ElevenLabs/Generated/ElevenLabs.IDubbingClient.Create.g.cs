#nullable enable

namespace ElevenLabs
{
    public partial interface IDubbingClient
    {
        /// <summary>
        /// Create Dubbing Project<br/>
        /// Create a dubbing project from an uploaded file or a source URL.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.DubbingProjectResponse> CreateAsync(

            global::ElevenLabs.BodyCreateDubbingProjectV1DubbingProjectPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Dubbing Project<br/>
        /// Create a dubbing project from an uploaded file or a source URL.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.DubbingProjectResponse>> CreateAsResponseAsync(

            global::ElevenLabs.BodyCreateDubbingProjectV1DubbingProjectPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Dubbing Project<br/>
        /// Create a dubbing project from an uploaded file or a source URL.
        /// </summary>
        /// <param name="file">
        /// The source media file to dub. Provide this or source_url.
        /// </param>
        /// <param name="filename">
        /// The source media file to dub. Provide this or source_url.
        /// </param>
        /// <param name="sourceUrl">
        /// Public URL to fetch the source media from. Provide this or file.
        /// </param>
        /// <param name="reference">
        /// Optional free-form string (max 500 characters) to identify the project on your end.
        /// </param>
        /// <param name="sourceLanguage">
        /// BCP-47 language tag of the source media; must be a language the transcription model supports. Any region or script subtag is ignored, since transcription is per-language. Omit to auto-detect.
        /// </param>
        /// <param name="modelId">
        /// Default dubbing model id for the project's language targets; a target may override it. Omit to use the system default.
        /// </param>
        /// <param name="keyterms">
        /// Key terms to bias transcription/translation toward (e.g. product or brand names). At most 1000 terms; each term at most 50 characters and 5 words; the characters `&lt;&gt;{}[]\` are not allowed.
        /// </param>
        /// <param name="targetLanguage">
        /// Optional shortcut: also create a language target in this BCP-47 language, queued to start once the project is ready. Must be a language the dubbing model supports, and a region-qualified tag must be one of the supported dialects.
        /// </param>
        /// <param name="transcript">
        /// Optional JSON transcript to use instead of automatic transcription. When provided, source_language is required. Segments may include an optional external_id and an optional translation; if any segment includes a translation, target_language is required and every segment must include one (used to seed the target created via target_language).
        /// </param>
        /// <param name="transcriptname">
        /// Optional JSON transcript to use instead of automatic transcription. When provided, source_language is required. Segments may include an optional external_id and an optional translation; if any segment includes a translation, target_language is required and every segment must include one (used to seed the target created via target_language).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.DubbingProjectResponse> CreateAsync(
            byte[]? file = default,
            string? filename = default,
            string? sourceUrl = default,
            string? reference = default,
            string? sourceLanguage = default,
            string? modelId = default,
            global::System.Collections.Generic.IList<string>? keyterms = default,
            string? targetLanguage = default,
            byte[]? transcript = default,
            string? transcriptname = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}