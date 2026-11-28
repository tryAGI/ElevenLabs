#nullable enable

namespace ElevenLabs
{
    public partial interface ICustomerSupportClient
    {
        /// <summary>
        /// List Ticket Tags<br/>
        /// List active ticket tags for the workspace, newest first. Requires support read permission.
        /// </summary>
        /// <param name="ids">
        /// Only return ticket tags with these IDs.
        /// </param>
        /// <param name="includeArchived">
        /// Whether to include archived ticket tags.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="pageSize">
        /// Number of ticket tags to return.<br/>
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
        global::System.Threading.Tasks.Task<global::ElevenLabs.PaginatedResultTicketTagResponse> List2Async(
            global::System.Collections.Generic.IList<string>? ids = default,
            bool? includeArchived = default,
            int? pageSize = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Ticket Tags<br/>
        /// List active ticket tags for the workspace, newest first. Requires support read permission.
        /// </summary>
        /// <param name="ids">
        /// Only return ticket tags with these IDs.
        /// </param>
        /// <param name="includeArchived">
        /// Whether to include archived ticket tags.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="pageSize">
        /// Number of ticket tags to return.<br/>
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
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.PaginatedResultTicketTagResponse>> List2AsResponseAsync(
            global::System.Collections.Generic.IList<string>? ids = default,
            bool? includeArchived = default,
            int? pageSize = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps List2Async as an IAsyncEnumerable&lt;global::ElevenLabs.TicketTagResponse&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="ids">
        /// Only return ticket tags with these IDs.
        /// </param>
        /// <param name="includeArchived">
        /// Whether to include archived ticket tags.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="pageSize">
        /// Number of ticket tags to return.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="cursor">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::ElevenLabs.TicketTagResponse> List2AutoPagingAsync(
              global::System.Collections.Generic.IList<string>? ids = default,
            bool? includeArchived = default,
            int? pageSize = default,
            string? cursor = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}