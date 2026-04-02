#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Get Tools<br/>
        /// Get all available tools in the workspace.
        /// </summary>
        /// <param name="search">
        /// If specified, the endpoint returns only tools whose names start with this string.
        /// </param>
        /// <param name="pageSize">
        /// How many documents to return at maximum. Can not exceed 100, defaults to 30.
        /// </param>
        /// <param name="showOnlyOwnedDocuments">
        /// If set to true, the endpoint will return only tools owned by you (and not shared from somebody else). Deprecated: use created_by_user_id instead.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="createdByUserId">
        /// Filter tools by creator user ID. When set, only tools created by this user are returned. Takes precedence over show_only_owned_documents. Use '@me' to refer to the authenticated user.
        /// </param>
        /// <param name="types">
        /// If present, the endpoint will return only tools of the given types.
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ToolsResponseModel> List7Async(
            string? search = default,
            int? pageSize = default,
            bool? showOnlyOwnedDocuments = default,
            string? createdByUserId = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.ToolTypeFilter>? types = default,
            global::ElevenLabs.SortDirection? sortDirection = default,
            global::ElevenLabs.ToolSortBy? sortBy = default,
            string? cursor = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}