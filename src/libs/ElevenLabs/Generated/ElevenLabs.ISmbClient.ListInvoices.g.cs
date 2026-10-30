#nullable enable

namespace ElevenLabs
{
    public partial interface ISmbClient
    {
        /// <summary>
        /// List Reseller Invoices<br/>
        /// List the invoices charged to the reseller's card, newest first, one per workspace invoice
        /// </summary>
        /// <param name="cursor">
        /// Pagination cursor from previous response
        /// </param>
        /// <param name="pageSize">
        /// Number of invoices per page<br/>
        /// Default Value: 25
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ResellerInvoicesResponse> ListInvoicesAsync(
            string? cursor = default,
            int? pageSize = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Reseller Invoices<br/>
        /// List the invoices charged to the reseller's card, newest first, one per workspace invoice
        /// </summary>
        /// <param name="cursor">
        /// Pagination cursor from previous response
        /// </param>
        /// <param name="pageSize">
        /// Number of invoices per page<br/>
        /// Default Value: 25
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.ResellerInvoicesResponse>> ListInvoicesAsResponseAsync(
            string? cursor = default,
            int? pageSize = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps ListInvoicesAsync as an IAsyncEnumerable&lt;global::ElevenLabs.ResellerInvoiceSummary&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="pageSize">
        /// Number of invoices per page<br/>
        /// Default Value: 25
        /// </param>
        /// <param name="cursor">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::ElevenLabs.ResellerInvoiceSummary> ListInvoicesAutoPagingAsync(
              int? pageSize = default,
            string? cursor = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}