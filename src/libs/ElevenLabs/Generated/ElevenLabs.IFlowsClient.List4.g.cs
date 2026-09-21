#nullable enable

namespace ElevenLabs
{
    public partial interface IFlowsClient
    {
        /// <summary>
        /// List Template Runs<br/>
        /// List this template's runs created through this API, newest first.
        /// </summary>
        /// <param name="templateId">
        /// The ID of the template, as shown in the ElevenLabs app or by `GET /v1/flows/templates`.
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor: the `next_cursor` value of the previous page's response. Omit it for the first page.
        /// </param>
        /// <param name="pageSize">
        /// How many runs to return per page.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="versionId">
        /// Only return runs of this template version id.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.TemplateRunListResponse> List4Async(
            string templateId,
            string? cursor = default,
            int? pageSize = default,
            string? versionId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Template Runs<br/>
        /// List this template's runs created through this API, newest first.
        /// </summary>
        /// <param name="templateId">
        /// The ID of the template, as shown in the ElevenLabs app or by `GET /v1/flows/templates`.
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor: the `next_cursor` value of the previous page's response. Omit it for the first page.
        /// </param>
        /// <param name="pageSize">
        /// How many runs to return per page.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="versionId">
        /// Only return runs of this template version id.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.TemplateRunListResponse>> List4AsResponseAsync(
            string templateId,
            string? cursor = default,
            int? pageSize = default,
            string? versionId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps List4Async as an IAsyncEnumerable&lt;global::ElevenLabs.TemplateRunResponse&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="templateId">
        /// The ID of the template, as shown in the ElevenLabs app or by `GET /v1/flows/templates`.
        /// </param>
        /// <param name="pageSize">
        /// How many runs to return per page.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="versionId">
        /// Only return runs of this template version id.
        /// </param>
        /// <param name="cursor">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::ElevenLabs.TemplateRunResponse> List4AutoPagingAsync(
            string templateId,             int? pageSize = default,
            string? versionId = default,
            string? cursor = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}