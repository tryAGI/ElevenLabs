#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// List Agents<br/>
        /// Returns a list of your agents and their metadata.
        /// </summary>
        /// <param name="pageSize">
        /// How many Agents to return at maximum. Can not exceed 100, defaults to 30.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="search">
        /// Search by agents name.
        /// </param>
        /// <param name="archived">
        /// Filter agents by archived status<br/>
        /// Default Value: false
        /// </param>
        /// <param name="showOnlyOwnedAgents">
        /// If set to true, the endpoint will omit any agents that were shared with you by someone else and include only the ones you own. Deprecated: use created_by_user_id instead.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="createdByUserId">
        /// Filter agents by creator user ID. When set, only agents created by this user are returned. Takes precedence over show_only_owned_agents. Use '@me' to refer to the authenticated user.
        /// </param>
        /// <param name="sortDirection">
        /// The direction to sort the results<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="sortBy">
        /// The field to sort the results by
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetAgentsPageResponseModel> ListAsync(
            int? pageSize = default,
            string? search = default,
            bool? archived = default,
            bool? showOnlyOwnedAgents = default,
            string? createdByUserId = default,
            global::ElevenLabs.SortDirection? sortDirection = default,
            global::ElevenLabs.AgentSortBy? sortBy = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Agents<br/>
        /// Returns a list of your agents and their metadata.
        /// </summary>
        /// <param name="pageSize">
        /// How many Agents to return at maximum. Can not exceed 100, defaults to 30.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="search">
        /// Search by agents name.
        /// </param>
        /// <param name="archived">
        /// Filter agents by archived status<br/>
        /// Default Value: false
        /// </param>
        /// <param name="showOnlyOwnedAgents">
        /// If set to true, the endpoint will omit any agents that were shared with you by someone else and include only the ones you own. Deprecated: use created_by_user_id instead.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="createdByUserId">
        /// Filter agents by creator user ID. When set, only agents created by this user are returned. Takes precedence over show_only_owned_agents. Use '@me' to refer to the authenticated user.
        /// </param>
        /// <param name="sortDirection">
        /// The direction to sort the results<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="sortBy">
        /// The field to sort the results by
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.GetAgentsPageResponseModel>> ListAsResponseAsync(
            int? pageSize = default,
            string? search = default,
            bool? archived = default,
            bool? showOnlyOwnedAgents = default,
            string? createdByUserId = default,
            global::ElevenLabs.SortDirection? sortDirection = default,
            global::ElevenLabs.AgentSortBy? sortBy = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}