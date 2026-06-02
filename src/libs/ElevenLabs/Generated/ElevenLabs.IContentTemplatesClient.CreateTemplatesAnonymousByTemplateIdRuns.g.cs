#nullable enable

namespace ElevenLabs
{
    public partial interface IContentTemplatesClient
    {
        /// <summary>
        /// Start A Template Run Anonymously<br/>
        /// Anonymous (hCaptcha + IP-rate-limited) execution of a globally-published flow template. Inputs may reference assets uploaded via `POST /v1/creative-templates/anonymous/upload` — the workflow asset is promoted to a ContentAsset transparently. Mirrors `POST /v1/templates/{template_id}/runs` for unauthenticated callers.
        /// </summary>
        /// <param name="templateId">
        /// The template ID
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.TemplateRunResponseModel> CreateTemplatesAnonymousByTemplateIdRunsAsync(
            string templateId,

            global::ElevenLabs.TemplateRunCreateRequestModel request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start A Template Run Anonymously<br/>
        /// Anonymous (hCaptcha + IP-rate-limited) execution of a globally-published flow template. Inputs may reference assets uploaded via `POST /v1/creative-templates/anonymous/upload` — the workflow asset is promoted to a ContentAsset transparently. Mirrors `POST /v1/templates/{template_id}/runs` for unauthenticated callers.
        /// </summary>
        /// <param name="templateId">
        /// The template ID
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.TemplateRunResponseModel>> CreateTemplatesAnonymousByTemplateIdRunsAsResponseAsync(
            string templateId,

            global::ElevenLabs.TemplateRunCreateRequestModel request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start A Template Run Anonymously<br/>
        /// Anonymous (hCaptcha + IP-rate-limited) execution of a globally-published flow template. Inputs may reference assets uploaded via `POST /v1/creative-templates/anonymous/upload` — the workflow asset is promoted to a ContentAsset transparently. Mirrors `POST /v1/templates/{template_id}/runs` for unauthenticated callers.
        /// </summary>
        /// <param name="templateId">
        /// The template ID
        /// </param>
        /// <param name="inputs">
        /// Input values for the run, keyed by input port id. Each value is a Reference{Text,Image,Video,Audio} object; the server re-validates the binding against the input port's modality at run time, so populate the fields that match the value you have (`content_asset_id`, `generation_id`, `template_node_id`, `studio_clip`, or `inline_text` for text).
        /// </param>
        /// <param name="hcaptchaToken">
        /// hCaptcha token for verification.
        /// </param>
        /// <param name="versionId">
        /// Optional content snapshot ``version_id`` to execute. Omit to use the live template in the owning workspace, or the latest approved snapshot for anonymous / cross-workspace access.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.TemplateRunResponseModel> CreateTemplatesAnonymousByTemplateIdRunsAsync(
            string templateId,
            object? inputs = default,
            string? hcaptchaToken = default,
            string? versionId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}