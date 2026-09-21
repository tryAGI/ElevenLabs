#nullable enable

namespace ElevenLabs
{
    public partial interface IFlowsClient
    {
        /// <summary>
        /// Get Template Run<br/>
        /// Retrieve a template run: its `status`, rolled up from its outputs, and each output's own status and download URL once completed.
        /// </summary>
        /// <param name="templateId">
        /// The ID of the template, as shown in the ElevenLabs app or by `GET /v1/flows/templates`.
        /// </param>
        /// <param name="runId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.TemplateRunResponse> Get4Async(
            string templateId,
            string runId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Template Run<br/>
        /// Retrieve a template run: its `status`, rolled up from its outputs, and each output's own status and download URL once completed.
        /// </summary>
        /// <param name="templateId">
        /// The ID of the template, as shown in the ElevenLabs app or by `GET /v1/flows/templates`.
        /// </param>
        /// <param name="runId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.TemplateRunResponse>> Get4AsResponseAsync(
            string templateId,
            string runId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}