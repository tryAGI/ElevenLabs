#nullable enable

namespace ElevenLabs
{
    public partial interface IDubbingClient
    {
        /// <summary>
        /// Create Dubbing Language Target<br/>
        /// Queue a language target for a project (starts once the project is ready).
        /// </summary>
        /// <param name="projectId">
        /// Identifier of the parent dubbing project.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.DubbingLanguageResponse> Create2Async(
            string projectId,

            global::ElevenLabs.BodyCreateDubbingLanguageTargetV1DubbingProjectProjectIdLanguagePost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Dubbing Language Target<br/>
        /// Queue a language target for a project (starts once the project is ready).
        /// </summary>
        /// <param name="projectId">
        /// Identifier of the parent dubbing project.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.DubbingLanguageResponse>> Create2AsResponseAsync(
            string projectId,

            global::ElevenLabs.BodyCreateDubbingLanguageTargetV1DubbingProjectProjectIdLanguagePost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Dubbing Language Target<br/>
        /// Queue a language target for a project (starts once the project is ready).
        /// </summary>
        /// <param name="projectId">
        /// Identifier of the parent dubbing project.
        /// </param>
        /// <param name="targetLanguage">
        /// BCP-47 language tag to dub the project into (e.g. 'fr', 'es-MX'); must be a language the dubbing model supports. A region-qualified tag must be one of the supported dialects.
        /// </param>
        /// <param name="voiceSettings">
        /// Voice settings applied to the whole language (e.g. cloning strength).
        /// </param>
        /// <param name="translations">
        /// Enterprise only. Optional translations to use instead of machine translation. A map from each source segment's external_id (or its id, if you supplied none) to the translated text; every source segment must be covered exactly once. At most 20000 entries, totalling at most 4 MiB of text.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.DubbingLanguageResponse> Create2Async(
            string projectId,
            string targetLanguage,
            global::ElevenLabs.VoiceSettings? voiceSettings = default,
            global::System.Collections.Generic.Dictionary<string, string>? translations = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}