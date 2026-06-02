#nullable enable

namespace ElevenLabs
{
    public partial interface IContentTemplatesClient
    {
        /// <summary>
        /// Preflight A Template Run Anonymously<br/>
        /// Anonymous (hCaptcha + IP-rate-limited) preflight for globally-published flow templates. Mirrors `POST /v1/templates/{template_id}/runs/preflight` for unauthenticated callers.
        /// </summary>
        /// <param name="templateId">
        /// The template ID
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.NodeRunPreflightResponseModel> CreateTemplatesAnonymousByTemplateIdRunsPreflightAsync(
            string templateId,

            global::ElevenLabs.TemplateRunPreflightRequestModel request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Preflight A Template Run Anonymously<br/>
        /// Anonymous (hCaptcha + IP-rate-limited) preflight for globally-published flow templates. Mirrors `POST /v1/templates/{template_id}/runs/preflight` for unauthenticated callers.
        /// </summary>
        /// <param name="templateId">
        /// The template ID
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.NodeRunPreflightResponseModel>> CreateTemplatesAnonymousByTemplateIdRunsPreflightAsResponseAsync(
            string templateId,

            global::ElevenLabs.TemplateRunPreflightRequestModel request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Preflight A Template Run Anonymously<br/>
        /// Anonymous (hCaptcha + IP-rate-limited) preflight for globally-published flow templates. Mirrors `POST /v1/templates/{template_id}/runs/preflight` for unauthenticated callers.
        /// </summary>
        /// <param name="templateId">
        /// The template ID
        /// </param>
        /// <param name="inputs">
        /// Input values for the run, keyed by input port id. Each value is a Reference{Text,Image,Video,Audio} object re-validated against the input port's modality — see `TemplateRunCreateRequestModel.inputs`.
        /// </param>
        /// <param name="hcaptchaToken">
        /// hCaptcha token for verification. Required only on the anonymous preflight endpoint; ignored when called by an authenticated user.
        /// </param>
        /// <param name="versionId">
        /// Optional content snapshot ``version_id`` to preflight. Same semantics as `TemplateRunCreateRequestModel.version_id`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.NodeRunPreflightResponseModel> CreateTemplatesAnonymousByTemplateIdRunsPreflightAsync(
            string templateId,
            object? inputs = default,
            string? hcaptchaToken = default,
            string? versionId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}