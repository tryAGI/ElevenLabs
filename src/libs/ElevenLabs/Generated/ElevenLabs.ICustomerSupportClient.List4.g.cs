#nullable enable

namespace ElevenLabs
{
    public partial interface ICustomerSupportClient
    {
        /// <summary>
        /// List Tickets<br/>
        /// List tickets
        /// </summary>
        /// <param name="pageSize">
        /// Default Value: 30
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="search"></param>
        /// <param name="status"></param>
        /// <param name="priority"></param>
        /// <param name="slaStatus"></param>
        /// <param name="deadlineStatus"></param>
        /// <param name="requesterUserId"></param>
        /// <param name="assigneeId"></param>
        /// <param name="tagIds">
        /// Only return tickets with any of these tag IDs.
        /// </param>
        /// <param name="unassigned">
        /// Default Value: false
        /// </param>
        /// <param name="sortBy">
        /// The field to sort the results by<br/>
        /// Default Value: updated_at
        /// </param>
        /// <param name="sortDirection">
        /// The direction to sort the results<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "ELEVENLABS_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::ElevenLabs.PaginatedResultTicketListItemResponse> List4Async(
            int? pageSize = default,
            string? cursor = default,
            string? search = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.TicketStatus>? status = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.TicketPriority>? priority = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.TicketSLAStatus>? slaStatus = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.TicketDeadlineStatus>? deadlineStatus = default,
            global::System.Collections.Generic.IList<string>? requesterUserId = default,
            global::System.Collections.Generic.IList<string>? assigneeId = default,
            global::System.Collections.Generic.IList<string>? tagIds = default,
            bool? unassigned = default,
            global::ElevenLabs.TicketSortBy? sortBy = default,
            global::ElevenLabs.SortDirection? sortDirection = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Tickets<br/>
        /// List tickets
        /// </summary>
        /// <param name="pageSize">
        /// Default Value: 30
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="search"></param>
        /// <param name="status"></param>
        /// <param name="priority"></param>
        /// <param name="slaStatus"></param>
        /// <param name="deadlineStatus"></param>
        /// <param name="requesterUserId"></param>
        /// <param name="assigneeId"></param>
        /// <param name="tagIds">
        /// Only return tickets with any of these tag IDs.
        /// </param>
        /// <param name="unassigned">
        /// Default Value: false
        /// </param>
        /// <param name="sortBy">
        /// The field to sort the results by<br/>
        /// Default Value: updated_at
        /// </param>
        /// <param name="sortDirection">
        /// The direction to sort the results<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "ELEVENLABS_ALPHA_001")]
#endif
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.PaginatedResultTicketListItemResponse>> List4AsResponseAsync(
            int? pageSize = default,
            string? cursor = default,
            string? search = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.TicketStatus>? status = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.TicketPriority>? priority = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.TicketSLAStatus>? slaStatus = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.TicketDeadlineStatus>? deadlineStatus = default,
            global::System.Collections.Generic.IList<string>? requesterUserId = default,
            global::System.Collections.Generic.IList<string>? assigneeId = default,
            global::System.Collections.Generic.IList<string>? tagIds = default,
            bool? unassigned = default,
            global::ElevenLabs.TicketSortBy? sortBy = default,
            global::ElevenLabs.SortDirection? sortDirection = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps List4Async as an IAsyncEnumerable&lt;global::ElevenLabs.TicketListItemResponse&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="pageSize">
        /// Default Value: 30
        /// </param>
        /// <param name="search"></param>
        /// <param name="status"></param>
        /// <param name="priority"></param>
        /// <param name="slaStatus"></param>
        /// <param name="deadlineStatus"></param>
        /// <param name="requesterUserId"></param>
        /// <param name="assigneeId"></param>
        /// <param name="tagIds">
        /// Only return tickets with any of these tag IDs.
        /// </param>
        /// <param name="unassigned">
        /// Default Value: false
        /// </param>
        /// <param name="sortBy">
        /// The field to sort the results by<br/>
        /// Default Value: updated_at
        /// </param>
        /// <param name="sortDirection">
        /// The direction to sort the results<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="cursor">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::ElevenLabs.TicketListItemResponse> List4AutoPagingAsync(
              int? pageSize = default,
            string? search = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.TicketStatus>? status = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.TicketPriority>? priority = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.TicketSLAStatus>? slaStatus = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.TicketDeadlineStatus>? deadlineStatus = default,
            global::System.Collections.Generic.IList<string>? requesterUserId = default,
            global::System.Collections.Generic.IList<string>? assigneeId = default,
            global::System.Collections.Generic.IList<string>? tagIds = default,
            bool? unassigned = default,
            global::ElevenLabs.TicketSortBy? sortBy = default,
            global::ElevenLabs.SortDirection? sortDirection = default,
            string? cursor = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}