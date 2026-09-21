#nullable enable

namespace ElevenLabs
{
    public partial interface IFlowsClient
    {
        /// <summary>
        /// Get Template<br/>
        /// Retrieve one flows template, together with each runnable version's inputs and outputs. `versions` is empty when no published version is runnable through this API. Works for any template you can open, including templates shared with you by link or published to Explore from another workspace, which `GET /v1/flows/templates` does not list.
        /// </summary>
        /// <param name="templateId">
        /// The ID of the template, as shown in the ElevenLabs app or by `GET /v1/flows/templates`.
        /// </param>
        /// <param name="versionsPerTemplate">
        /// How many of each template's published versions to return, newest first. `has_more_versions` tells you when a template has more.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.TemplateSummary> Get5Async(
            string templateId,
            int? versionsPerTemplate = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Template<br/>
        /// Retrieve one flows template, together with each runnable version's inputs and outputs. `versions` is empty when no published version is runnable through this API. Works for any template you can open, including templates shared with you by link or published to Explore from another workspace, which `GET /v1/flows/templates` does not list.
        /// </summary>
        /// <param name="templateId">
        /// The ID of the template, as shown in the ElevenLabs app or by `GET /v1/flows/templates`.
        /// </param>
        /// <param name="versionsPerTemplate">
        /// How many of each template's published versions to return, newest first. `has_more_versions` tells you when a template has more.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.TemplateSummary>> Get5AsResponseAsync(
            string templateId,
            int? versionsPerTemplate = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}