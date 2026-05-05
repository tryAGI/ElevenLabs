#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Get Knowledge Base List<br/>
        /// Get a list of available knowledge base documents
        /// </summary>
        /// <param name="pageSize">
        /// How many documents to return at maximum. Can not exceed 100, defaults to 30.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="search">
        /// If specified, the endpoint returns only such knowledge base documents whose names start with this string.
        /// </param>
        /// <param name="showOnlyOwnedDocuments">
        /// If set to true, the endpoint will return only documents owned by you (and not shared from somebody else). Deprecated: use created_by_user_id instead.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="createdByUserId">
        /// Filter documents by creator user ID. When set, only documents created by this user are returned. Takes precedence over show_only_owned_documents. Use '@me' to refer to the authenticated user.
        /// </param>
        /// <param name="types">
        /// If present, the endpoint will return only documents of the given types.
        /// </param>
        /// <param name="parentFolderId">
        /// If set, the endpoint will return only documents that are direct children of the given folder.
        /// </param>
        /// <param name="ancestorFolderId">
        /// If set, the endpoint will return only documents that are descendants of the given folder.
        /// </param>
        /// <param name="foldersFirst">
        /// Whether folders should be returned first in the list of documents.<br/>
        /// Default Value: false
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
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetKnowledgeBaseListResponseModel> List7Async(
            int? pageSize = default,
            string? search = default,
            bool? showOnlyOwnedDocuments = default,
            string? createdByUserId = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseDocumentType>? types = default,
            string? parentFolderId = default,
            string? ancestorFolderId = default,
            bool? foldersFirst = default,
            global::ElevenLabs.SortDirection? sortDirection = default,
            global::ElevenLabs.KnowledgeBaseSortBy? sortBy = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Knowledge Base List<br/>
        /// Get a list of available knowledge base documents
        /// </summary>
        /// <param name="pageSize">
        /// How many documents to return at maximum. Can not exceed 100, defaults to 30.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="search">
        /// If specified, the endpoint returns only such knowledge base documents whose names start with this string.
        /// </param>
        /// <param name="showOnlyOwnedDocuments">
        /// If set to true, the endpoint will return only documents owned by you (and not shared from somebody else). Deprecated: use created_by_user_id instead.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="createdByUserId">
        /// Filter documents by creator user ID. When set, only documents created by this user are returned. Takes precedence over show_only_owned_documents. Use '@me' to refer to the authenticated user.
        /// </param>
        /// <param name="types">
        /// If present, the endpoint will return only documents of the given types.
        /// </param>
        /// <param name="parentFolderId">
        /// If set, the endpoint will return only documents that are direct children of the given folder.
        /// </param>
        /// <param name="ancestorFolderId">
        /// If set, the endpoint will return only documents that are descendants of the given folder.
        /// </param>
        /// <param name="foldersFirst">
        /// Whether folders should be returned first in the list of documents.<br/>
        /// Default Value: false
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
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.GetKnowledgeBaseListResponseModel>> List7AsResponseAsync(
            int? pageSize = default,
            string? search = default,
            bool? showOnlyOwnedDocuments = default,
            string? createdByUserId = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseDocumentType>? types = default,
            string? parentFolderId = default,
            string? ancestorFolderId = default,
            bool? foldersFirst = default,
            global::ElevenLabs.SortDirection? sortDirection = default,
            global::ElevenLabs.KnowledgeBaseSortBy? sortBy = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}