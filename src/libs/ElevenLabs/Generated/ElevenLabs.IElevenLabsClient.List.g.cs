#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs
{
    public partial interface IElevenLabsClient
    {
        /// <summary>
        /// List Agent Response Tests<br/>
        /// Lists all agent response tests with pagination support and optional search filtering.
        /// </summary>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="pageSize">
        /// How many Tests to return at maximum. Can not exceed 100, defaults to 30.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="search">
        /// Search query to filter tests by name.
        /// </param>
        /// <param name="parentFolderId">
        /// Filter by parent folder ID. Use 'root' to get items in the root folder.
        /// </param>
        /// <param name="types">
        /// If present, the endpoint will return only tests/folders of the given types.
        /// </param>
        /// <param name="includeFolders">
        /// Deprecated. Use the `types` query param and include `folder` instead.
        /// </param>
        /// <param name="sortMode">
        /// Sort mode for listing tests. Use 'folders_first' to place folders before tests.<br/>
        /// Default Value: default
        /// </param>
        /// <param name="sharingMode">
        /// Filter test visibility. Use `shared_with_me` to return only tests/folders shared with the current user that they did not create.<br/>
        /// Default Value: all
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetTestsPageResponseModel> ListAsync(
            string? cursor = default,
            int? pageSize = default,
            string? search = default,
            string? parentFolderId = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.TestType>? types = default,
            bool? includeFolders = default,
            global::ElevenLabs.ListChatResponseTestsRouteSortMode? sortMode = default,
            global::ElevenLabs.TestSharingMode? sharingMode = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}