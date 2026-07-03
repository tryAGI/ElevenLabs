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
        global::System.Threading.Tasks.Task<global::ElevenLabs.ProjectResponse> CreateAsync(

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
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.ProjectResponse>> CreateAsResponseAsync(

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
        /// BCP-47 language tag of the source media. Omit to auto-detect.
        /// </param>
        /// <param name="modelId">
        /// Default dubbing model id for the project's language targets; a target may override it. Omit to use the system default.
        /// </param>
        /// <param name="keyterms">
        /// Key terms to bias transcription/translation toward (e.g. product or brand names).
        /// </param>
        /// <param name="targetLanguage">
        /// Optional shortcut: also create a language target in this BCP-47 language, queued to start once the project is ready.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ProjectResponse> CreateAsync(
            byte[]? file = default,
            string? filename = default,
            string? sourceUrl = default,
            string? reference = default,
            string? sourceLanguage = default,
            string? modelId = default,
            global::System.Collections.Generic.IList<string>? keyterms = default,
            string? targetLanguage = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}