#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// List Analysis Items<br/>
        /// List analysis items available in the workspace.
        /// </summary>
        /// <param name="search">
        /// If specified, only analysis items whose names start with this string are returned, ordered by relevance rather than sort_direction.
        /// </param>
        /// <param name="pageSize">
        /// How many documents to return at maximum. Can not exceed 100, defaults to 30.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="kind">
        /// If specified, only analysis items of this kind are returned.
        /// </param>
        /// <param name="analysisItemIds">
        /// If specified, only analysis items with these IDs are returned.
        /// </param>
        /// <param name="createdByUserId">
        /// Filter by creator user ID. Use '@me' to refer to the authenticated user.
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
        global::System.Threading.Tasks.Task<global::ElevenLabs.AnalysisItemsResponseModel> List10Async(
            string? search = default,
            int? pageSize = default,
            global::ElevenLabs.AnalysisItemKind? kind = default,
            global::System.Collections.Generic.IList<string>? analysisItemIds = default,
            string? createdByUserId = default,
            global::ElevenLabs.SortDirection? sortDirection = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Analysis Items<br/>
        /// List analysis items available in the workspace.
        /// </summary>
        /// <param name="search">
        /// If specified, only analysis items whose names start with this string are returned, ordered by relevance rather than sort_direction.
        /// </param>
        /// <param name="pageSize">
        /// How many documents to return at maximum. Can not exceed 100, defaults to 30.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="kind">
        /// If specified, only analysis items of this kind are returned.
        /// </param>
        /// <param name="analysisItemIds">
        /// If specified, only analysis items with these IDs are returned.
        /// </param>
        /// <param name="createdByUserId">
        /// Filter by creator user ID. Use '@me' to refer to the authenticated user.
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
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.AnalysisItemsResponseModel>> List10AsResponseAsync(
            string? search = default,
            int? pageSize = default,
            global::ElevenLabs.AnalysisItemKind? kind = default,
            global::System.Collections.Generic.IList<string>? analysisItemIds = default,
            string? createdByUserId = default,
            global::ElevenLabs.SortDirection? sortDirection = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps List10Async as an IAsyncEnumerable&lt;global::ElevenLabs.AnalysisItemResponseModel&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="search">
        /// If specified, only analysis items whose names start with this string are returned, ordered by relevance rather than sort_direction.
        /// </param>
        /// <param name="pageSize">
        /// How many documents to return at maximum. Can not exceed 100, defaults to 30.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="kind">
        /// If specified, only analysis items of this kind are returned.
        /// </param>
        /// <param name="analysisItemIds">
        /// If specified, only analysis items with these IDs are returned.
        /// </param>
        /// <param name="createdByUserId">
        /// Filter by creator user ID. Use '@me' to refer to the authenticated user.
        /// </param>
        /// <param name="sortDirection">
        /// The direction to sort the results<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="cursor">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::ElevenLabs.AnalysisItemResponseModel> List10AutoPagingAsync(
              string? search = default,
            int? pageSize = default,
            global::ElevenLabs.AnalysisItemKind? kind = default,
            global::System.Collections.Generic.IList<string>? analysisItemIds = default,
            string? createdByUserId = default,
            global::ElevenLabs.SortDirection? sortDirection = default,
            string? cursor = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}