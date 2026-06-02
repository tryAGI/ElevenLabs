#nullable enable

namespace ElevenLabs
{
    public partial interface IContentTemplatesClient
    {
        /// <summary>
        /// Stream An Anonymous Template Run Via Sse<br/>
        /// Subscribe to generation status updates for an anonymous template run. Mirrors `GET /v1/templates/{template_id}/runs/{session_id}/stream` for unauthenticated callers.
        /// </summary>
        /// <param name="templateId">
        /// The template ID
        /// </param>
        /// <param name="sessionId">
        /// The session ID
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task GetTemplatesAnonymousByTemplateIdRunsBySessionIdStreamAsync(
            string templateId,
            string sessionId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stream An Anonymous Template Run Via Sse<br/>
        /// Subscribe to generation status updates for an anonymous template run. Mirrors `GET /v1/templates/{template_id}/runs/{session_id}/stream` for unauthenticated callers.
        /// </summary>
        /// <param name="templateId">
        /// The template ID
        /// </param>
        /// <param name="sessionId">
        /// The session ID
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse> GetTemplatesAnonymousByTemplateIdRunsBySessionIdStreamAsResponseAsync(
            string templateId,
            string sessionId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}