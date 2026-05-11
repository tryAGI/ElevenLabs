#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Get All Rag Chunks For A Document<br/>
        /// Get all RAG chunks for a specific knowledge base document.
        /// </summary>
        /// <param name="documentationId">
        /// The id of a document from the knowledge base. This is returned on document addition.
        /// </param>
        /// <param name="embeddingModel">
        /// The embedding model used to retrieve the chunk.<br/>
        /// Default Value: e5_mistral_7b_instruct
        /// </param>
        /// <param name="pageSize">
        /// How many documents to return at maximum. Can not exceed 100, defaults to 30.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.KnowledgeBaseDocumentChunksResponseModel> List8Async(
            string documentationId,
            global::ElevenLabs.EmbeddingModelEnum embeddingModel = global::ElevenLabs.EmbeddingModelEnum.E5Mistral7bInstruct,
            int? pageSize = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get All Rag Chunks For A Document<br/>
        /// Get all RAG chunks for a specific knowledge base document.
        /// </summary>
        /// <param name="documentationId">
        /// The id of a document from the knowledge base. This is returned on document addition.
        /// </param>
        /// <param name="embeddingModel">
        /// The embedding model used to retrieve the chunk.<br/>
        /// Default Value: e5_mistral_7b_instruct
        /// </param>
        /// <param name="pageSize">
        /// How many documents to return at maximum. Can not exceed 100, defaults to 30.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.KnowledgeBaseDocumentChunksResponseModel>> List8AsResponseAsync(
            string documentationId,
            global::ElevenLabs.EmbeddingModelEnum embeddingModel = global::ElevenLabs.EmbeddingModelEnum.E5Mistral7bInstruct,
            int? pageSize = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}