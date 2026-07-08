#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Get Conversation Users<br/>
        /// Get distinct users from conversations with pagination.
        /// </summary>
        /// <param name="agentId">
        /// Agent id (agent_…) or speech engine external id (seng_), resolved to the same underlying resource.
        /// </param>
        /// <param name="branchId">
        /// Filter conversations by branch ID.
        /// </param>
        /// <param name="callStartBeforeUnix">
        /// Unix timestamp (in seconds) to filter conversations up to this start date.
        /// </param>
        /// <param name="callStartAfterUnix">
        /// Unix timestamp (in seconds) to filter conversations after to this start date.
        /// </param>
        /// <param name="search">
        /// Search/filter by user ID (exact match).
        /// </param>
        /// <param name="pageSize">
        /// How many users to return at maximum. Defaults to 30.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="sortBy">
        /// The field to sort the results by. Defaults to last_contact_unix_secs.<br/>
        /// Default Value: last_contact_unix_secs
        /// </param>
        /// <param name="sortDirection">
        /// The direction to sort the results<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetConversationUsersPageResponseModel> List3Async(
            string? agentId = default,
            string? branchId = default,
            int? callStartBeforeUnix = default,
            int? callStartAfterUnix = default,
            string? search = default,
            int? pageSize = default,
            global::ElevenLabs.UsersSortBy? sortBy = default,
            global::ElevenLabs.SortDirection? sortDirection = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Conversation Users<br/>
        /// Get distinct users from conversations with pagination.
        /// </summary>
        /// <param name="agentId">
        /// Agent id (agent_…) or speech engine external id (seng_), resolved to the same underlying resource.
        /// </param>
        /// <param name="branchId">
        /// Filter conversations by branch ID.
        /// </param>
        /// <param name="callStartBeforeUnix">
        /// Unix timestamp (in seconds) to filter conversations up to this start date.
        /// </param>
        /// <param name="callStartAfterUnix">
        /// Unix timestamp (in seconds) to filter conversations after to this start date.
        /// </param>
        /// <param name="search">
        /// Search/filter by user ID (exact match).
        /// </param>
        /// <param name="pageSize">
        /// How many users to return at maximum. Defaults to 30.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="sortBy">
        /// The field to sort the results by. Defaults to last_contact_unix_secs.<br/>
        /// Default Value: last_contact_unix_secs
        /// </param>
        /// <param name="sortDirection">
        /// The direction to sort the results<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.GetConversationUsersPageResponseModel>> List3AsResponseAsync(
            string? agentId = default,
            string? branchId = default,
            int? callStartBeforeUnix = default,
            int? callStartAfterUnix = default,
            string? search = default,
            int? pageSize = default,
            global::ElevenLabs.UsersSortBy? sortBy = default,
            global::ElevenLabs.SortDirection? sortDirection = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps List3Async as an IAsyncEnumerable&lt;global::ElevenLabs.ConversationUserResponseModel&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="agentId">
        /// Agent id (agent_…) or speech engine external id (seng_), resolved to the same underlying resource.
        /// </param>
        /// <param name="branchId">
        /// Filter conversations by branch ID.
        /// </param>
        /// <param name="callStartBeforeUnix">
        /// Unix timestamp (in seconds) to filter conversations up to this start date.
        /// </param>
        /// <param name="callStartAfterUnix">
        /// Unix timestamp (in seconds) to filter conversations after to this start date.
        /// </param>
        /// <param name="search">
        /// Search/filter by user ID (exact match).
        /// </param>
        /// <param name="pageSize">
        /// How many users to return at maximum. Defaults to 30.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="sortBy">
        /// The field to sort the results by. Defaults to last_contact_unix_secs.<br/>
        /// Default Value: last_contact_unix_secs
        /// </param>
        /// <param name="sortDirection">
        /// The direction to sort the results<br/>
        /// Default Value: desc
        /// </param> 
        /// <param name="cursor">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::ElevenLabs.ConversationUserResponseModel> List3AutoPagingAsync(
              string? agentId = default,
            string? branchId = default,
            int? callStartBeforeUnix = default,
            int? callStartAfterUnix = default,
            string? search = default,
            int? pageSize = default,
            global::ElevenLabs.UsersSortBy? sortBy = default,
            global::ElevenLabs.SortDirection? sortDirection = default,
            string? cursor = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}