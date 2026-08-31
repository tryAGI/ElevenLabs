#nullable enable

namespace ElevenLabs
{
    public partial interface IDubbingClient
    {
        /// <summary>
        /// Create Dubbing Project<br/>
        /// Create a dubbing project from an uploaded file (`file`) or a source URL (`source_url`).<br/>
        /// Returns as soon as the project record exists, before the source has been fetched: the project starts `queued` and reaches `ready` once its source has been transcribed. Creating a project does not dub anything — add a language target to it for each language you want, or pass `target_language` to queue the first one here.<br/>
        /// Preparation can take minutes on a long source, so we recommend passing `webhook_ids` to be notified when the project turns `ready` or `failed`, rather than polling for it.
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
        /// Create a dubbing project from an uploaded file (`file`) or a source URL (`source_url`).<br/>
        /// Returns as soon as the project record exists, before the source has been fetched: the project starts `queued` and reaches `ready` once its source has been transcribed. Creating a project does not dub anything — add a language target to it for each language you want, or pass `target_language` to queue the first one here.<br/>
        /// Preparation can take minutes on a long source, so we recommend passing `webhook_ids` to be notified when the project turns `ready` or `failed`, rather than polling for it.
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
        /// Create a dubbing project from an uploaded file (`file`) or a source URL (`source_url`).<br/>
        /// Returns as soon as the project record exists, before the source has been fetched: the project starts `queued` and reaches `ready` once its source has been transcribed. Creating a project does not dub anything — add a language target to it for each language you want, or pass `target_language` to queue the first one here.<br/>
        /// Preparation can take minutes on a long source, so we recommend passing `webhook_ids` to be notified when the project turns `ready` or `failed`, rather than polling for it.
        /// </summary>
        /// <param name="file">
        /// The source media file to dub: an audio or video file of at most 3 GiB. Provide this or `source_url`, not both.
        /// </param>
        /// <param name="filename">
        /// The source media file to dub: an audio or video file of at most 3 GiB. Provide this or `source_url`, not both.
        /// </param>
        /// <param name="sourceUrl">
        /// Public HTTP(S) URL the source media is fetched from server-side, subject to the same size and format limits as an upload. Provide this or `file`, not both.
        /// </param>
        /// <param name="reference">
        /// Optional free-form string (at most 500 characters) to identify the project on your end. Stored and echoed back verbatim; it does not affect the dub.
        /// </param>
        /// <param name="sourceLanguage">
        /// BCP-47 language tag of the source media; must be a language the transcription model supports. Any region or script subtag is ignored, since transcription is per-language. Omit to auto-detect.
        /// </param>
        /// <param name="modelId">
        /// Dubbing model (`dubbing_v1` or `dubbing_v2`) every language target of this project is dubbed with. Defaults to `dubbing_v2`. Fixed at create time — the source is prepared for this model, so neither the project nor an individual target can change it later.
        /// </param>
        /// <param name="keyterms">
        /// Key terms to bias transcription and translation toward (for example, product or brand names). At most 1,000 terms; each term at most 50 characters and 5 words; the characters `&lt;&gt;{}[]\` are not allowed. Terms are trimmed and deduplicated.
        /// </param>
        /// <param name="webhookIds">
        /// IDs of workspace webhooks to notify as this project progresses — the alternative to polling, and what we recommend. Each receives a `dubbing_project_ready` or `dubbing_project_failed` event for the project, and a `dubbing_language_completed` or `dubbing_language_failed` event for every language under it; `dubbing_language_completed` carries the output download URLs. At most 3 IDs, each already configured in your workspace — see [Webhooks](https://elevenlabs.io/docs/eleven-api/resources/webhooks) for how to create one and verify its signature. Delivery is best-effort and can repeat, so we recommend handling events idempotently.
        /// </param>
        /// <param name="targetLanguage">
        /// Optional shortcut: also create a language target in this BCP-47 language, queued to start once the project is ready — equivalent to creating the project and then creating one language target. Must be one of the [languages the dubbing model supports](https://elevenlabs.io/docs/help-center/product/dubbing/which-languages-are-supported-in-dubbing), and a region-qualified tag must be one of the supported dialects. Its ID is returned in `language_ids`.
        /// </param>
        /// <param name="transcript">
        /// Enterprise only. Optional JSON transcript to use instead of transcribing the source: a `{"segments": [...]}` document, at most 20,000 segments and 4 MiB. See [Bring your own transcript](https://elevenlabs.io/docs/eleven-api/guides/how-to/dubbing/bring-your-own-transcript) for the segment fields and their constraints. `source_language` is required whenever a transcript is provided. If any segment carries a `translation`, `target_language` is required and every segment must carry one; those translations seed the target created via `target_language`, which then skips machine translation.
        /// </param>
        /// <param name="transcriptname">
        /// Enterprise only. Optional JSON transcript to use instead of transcribing the source: a `{"segments": [...]}` document, at most 20,000 segments and 4 MiB. See [Bring your own transcript](https://elevenlabs.io/docs/eleven-api/guides/how-to/dubbing/bring-your-own-transcript) for the segment fields and their constraints. `source_language` is required whenever a transcript is provided. If any segment carries a `translation`, `target_language` is required and every segment must carry one; those translations seed the target created via `target_language`, which then skips machine translation.
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
            global::ElevenLabs.AnyOf<global::ElevenLabs.BodyCreateDubbingProjectV1DubbingProjectPostModelId?, string, object>? modelId = default,
            global::System.Collections.Generic.IList<string>? keyterms = default,
            global::System.Collections.Generic.IList<string>? webhookIds = default,
            string? targetLanguage = default,
            byte[]? transcript = default,
            string? transcriptname = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}