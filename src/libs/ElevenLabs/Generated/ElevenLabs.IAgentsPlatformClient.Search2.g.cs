#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Search Knowledge Base Content<br/>
        /// Fuzzy text search over knowledge base document content
        /// </summary>
        /// <param name="query">
        /// The search query text
        /// </param>
        /// <param name="pageSize">
        /// How many documents to return at maximum. Can not exceed 100, defaults to 30.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="types">
        /// If present, the endpoint will return only documents of the given types.
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.KnowledgeBaseContentSearchResponseModel> Search2Async(
            string query,
            int? pageSize = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseDocumentType>? types = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search Knowledge Base Content<br/>
        /// Fuzzy text search over knowledge base document content
        /// </summary>
        /// <param name="query">
        /// The search query text
        /// </param>
        /// <param name="pageSize">
        /// How many documents to return at maximum. Can not exceed 100, defaults to 30.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="types">
        /// If present, the endpoint will return only documents of the given types.
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.KnowledgeBaseContentSearchResponseModel>> Search2AsResponseAsync(
            string query,
            int? pageSize = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseDocumentType>? types = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}