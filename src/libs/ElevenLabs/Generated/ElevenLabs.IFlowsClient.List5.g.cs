#nullable enable

namespace ElevenLabs
{
    public partial interface IFlowsClient
    {
        /// <summary>
        /// List Templates<br/>
        /// List the published flows templates in your workspace, together with each runnable version's inputs and outputs. Use the ids here as `template_id` / `version_id` on `POST /v1/flows/templates/{template_id}/runs`. Versions built on models that are not available to you through the API are left out, so `versions` is empty when none of a template's published versions is runnable through this API. Templates shared with you by link, or published to Explore from another workspace, are not listed but can still be fetched and run by `template_id`.
        /// </summary>
        /// <param name="cursor">
        /// Pagination cursor: the `next_cursor` value of the previous page's response. Omit it for the first page.
        /// </param>
        /// <param name="pageSize">
        /// How many templates to return per page. Lower than the run list's ceiling because each row expands its versions' input and output schemas.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="versionsPerTemplate">
        /// How many of each template's published versions to return, newest first. `has_more_versions` tells you when a template has more.<br/>
        /// Default Value: 3
        /// </param>
        /// <param name="search">
        /// Only return templates whose name or description contains this text.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.TemplateListResponse> List5Async(
            string? cursor = default,
            int? pageSize = default,
            int? versionsPerTemplate = default,
            string? search = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Templates<br/>
        /// List the published flows templates in your workspace, together with each runnable version's inputs and outputs. Use the ids here as `template_id` / `version_id` on `POST /v1/flows/templates/{template_id}/runs`. Versions built on models that are not available to you through the API are left out, so `versions` is empty when none of a template's published versions is runnable through this API. Templates shared with you by link, or published to Explore from another workspace, are not listed but can still be fetched and run by `template_id`.
        /// </summary>
        /// <param name="cursor">
        /// Pagination cursor: the `next_cursor` value of the previous page's response. Omit it for the first page.
        /// </param>
        /// <param name="pageSize">
        /// How many templates to return per page. Lower than the run list's ceiling because each row expands its versions' input and output schemas.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="versionsPerTemplate">
        /// How many of each template's published versions to return, newest first. `has_more_versions` tells you when a template has more.<br/>
        /// Default Value: 3
        /// </param>
        /// <param name="search">
        /// Only return templates whose name or description contains this text.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.TemplateListResponse>> List5AsResponseAsync(
            string? cursor = default,
            int? pageSize = default,
            int? versionsPerTemplate = default,
            string? search = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps List5Async as an IAsyncEnumerable&lt;global::ElevenLabs.TemplateSummary&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="pageSize">
        /// How many templates to return per page. Lower than the run list's ceiling because each row expands its versions' input and output schemas.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="versionsPerTemplate">
        /// How many of each template's published versions to return, newest first. `has_more_versions` tells you when a template has more.<br/>
        /// Default Value: 3
        /// </param>
        /// <param name="search">
        /// Only return templates whose name or description contains this text.
        /// </param>
        /// <param name="cursor">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::ElevenLabs.TemplateSummary> List5AutoPagingAsync(
              int? pageSize = default,
            int? versionsPerTemplate = default,
            string? search = default,
            string? cursor = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}