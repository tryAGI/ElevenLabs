#nullable enable

namespace ElevenLabs
{
    public partial interface IFlowsClient
    {
        /// <summary>
        /// Create Template Run<br/>
        /// Start a run of a flows template. Pass `version_id` to pin a snapshot, or omit it / pass `latest` to run the latest published version. Set input values under `inputs`, keyed by input port id. The response is the run in its initial state, with every output already listed under its port id in `outputs`. Include `webhook` to receive a `flows_template_run` event carrying the finished run once its `status` is `completed` or `failed`; this is the recommended way to wait. Without one, fetch `GET /v1/flows/templates/{template_id}/runs/{run_id}` at a modest interval until the `status` is terminal.
        /// </summary>
        /// <param name="templateId">
        /// The ID of the template, as shown in the ElevenLabs app or by `GET /v1/flows/templates`.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.TemplateRunResponse> Create4Async(
            string templateId,

            global::ElevenLabs.TemplateRunCreateRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Template Run<br/>
        /// Start a run of a flows template. Pass `version_id` to pin a snapshot, or omit it / pass `latest` to run the latest published version. Set input values under `inputs`, keyed by input port id. The response is the run in its initial state, with every output already listed under its port id in `outputs`. Include `webhook` to receive a `flows_template_run` event carrying the finished run once its `status` is `completed` or `failed`; this is the recommended way to wait. Without one, fetch `GET /v1/flows/templates/{template_id}/runs/{run_id}` at a modest interval until the `status` is terminal.
        /// </summary>
        /// <param name="templateId">
        /// The ID of the template, as shown in the ElevenLabs app or by `GET /v1/flows/templates`.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.TemplateRunResponse>> Create4AsResponseAsync(
            string templateId,

            global::ElevenLabs.TemplateRunCreateRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Template Run<br/>
        /// Start a run of a flows template. Pass `version_id` to pin a snapshot, or omit it / pass `latest` to run the latest published version. Set input values under `inputs`, keyed by input port id. The response is the run in its initial state, with every output already listed under its port id in `outputs`. Include `webhook` to receive a `flows_template_run` event carrying the finished run once its `status` is `completed` or `failed`; this is the recommended way to wait. Without one, fetch `GET /v1/flows/templates/{template_id}/runs/{run_id}` at a modest interval until the `status` is terminal.
        /// </summary>
        /// <param name="templateId">
        /// The ID of the template, as shown in the ElevenLabs app or by `GET /v1/flows/templates`.
        /// </param>
        /// <param name="inputs">
        /// Input values keyed by input port id. Every input port of the version being run must be given; a missing or unknown id is rejected. Pass `{}` for a template with no inputs.
        /// </param>
        /// <param name="versionId">
        /// The template snapshot to run. Pass a specific version id to pin that snapshot, or `latest` (the default when omitted) to run the template's most recently published version. Only published versions can be pinned, except by the template's owner, who may also pin an unpublished saved snapshot to try it out before publishing. The live draft is never run through this API.
        /// </param>
        /// <param name="webhook">
        /// Include to send the run's result to the workspace's configured flows webhooks once the run's `status` reaches `completed` or `failed`. One event for the whole run: the `flows_template_run` event's `data` matches the terminal response of `GET /v1/flows/templates/{template_id}/runs/{run_id}`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.TemplateRunResponse> Create4Async(
            string templateId,
            global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.TemplateRunInput> inputs,
            string? versionId = default,
            global::ElevenLabs.WebhookTarget? webhook = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}