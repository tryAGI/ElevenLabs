#nullable enable

namespace ElevenLabs
{
    public partial interface ICustomerSupportClient
    {
        /// <summary>
        /// List Support Requesters<br/>
        /// List active Agents Users for the workspace as support requesters. Requires support read permission.
        /// </summary>
        /// <param name="ids">
        /// Only return requesters with these IDs.
        /// </param>
        /// <param name="pageSize">
        /// Number of requesters to return.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "ELEVENLABS_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::ElevenLabs.PaginatedResultTicketRequesterResponse> ListAsync(
            global::System.Collections.Generic.IList<string>? ids = default,
            int? pageSize = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Support Requesters<br/>
        /// List active Agents Users for the workspace as support requesters. Requires support read permission.
        /// </summary>
        /// <param name="ids">
        /// Only return requesters with these IDs.
        /// </param>
        /// <param name="pageSize">
        /// Number of requesters to return.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "ELEVENLABS_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.PaginatedResultTicketRequesterResponse>> ListAsResponseAsync(
            global::System.Collections.Generic.IList<string>? ids = default,
            int? pageSize = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps ListAsync as an IAsyncEnumerable&lt;global::ElevenLabs.TicketRequesterResponse&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="ids">
        /// Only return requesters with these IDs.
        /// </param>
        /// <param name="pageSize">
        /// Number of requesters to return.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="cursor">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::ElevenLabs.TicketRequesterResponse> ListAutoPagingAsync(
              global::System.Collections.Generic.IList<string>? ids = default,
            int? pageSize = default,
            string? cursor = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}