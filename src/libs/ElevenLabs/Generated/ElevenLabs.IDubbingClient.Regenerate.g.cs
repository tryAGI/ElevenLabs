#nullable enable

namespace ElevenLabs
{
    public partial interface IDubbingClient
    {
        /// <summary>
        /// Regenerate Dubbing Target<br/>
        /// Enterprise only. Re-dub a target from its edited transcript, re-synthesizing only the edited regions (charged like a generation, less the free-regeneration allowance). Accepted asynchronously: the target returns to `processing` and sends a `dubbing_language_completed` event to the project's `webhook_ids` when the re-dub lands, carrying the new output URLs. Returns a conflict when the target has no edits to apply — nothing is dispatched and nothing is charged.
        /// </summary>
        /// <param name="projectId">
        /// Identifier of the dubbing project.
        /// </param>
        /// <param name="languageId">
        /// Identifier of the language target.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.DubbingRegenerateResponse> RegenerateAsync(
            string projectId,
            string languageId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Regenerate Dubbing Target<br/>
        /// Enterprise only. Re-dub a target from its edited transcript, re-synthesizing only the edited regions (charged like a generation, less the free-regeneration allowance). Accepted asynchronously: the target returns to `processing` and sends a `dubbing_language_completed` event to the project's `webhook_ids` when the re-dub lands, carrying the new output URLs. Returns a conflict when the target has no edits to apply — nothing is dispatched and nothing is charged.
        /// </summary>
        /// <param name="projectId">
        /// Identifier of the dubbing project.
        /// </param>
        /// <param name="languageId">
        /// Identifier of the language target.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.DubbingRegenerateResponse>> RegenerateAsResponseAsync(
            string projectId,
            string languageId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}