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
        /// The id of the agent you're taking the action on.
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
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Conversation Users<br/>
        /// Get distinct users from conversations with pagination.
        /// </summary>
        /// <param name="agentId">
        /// The id of the agent you're taking the action on.
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
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}