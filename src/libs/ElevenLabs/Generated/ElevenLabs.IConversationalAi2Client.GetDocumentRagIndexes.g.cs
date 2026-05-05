#nullable enable

namespace ElevenLabs
{
    public partial interface IConversationalAi2Client
    {
        /// <summary>
        /// Get Rag Indexes Of The Specified Knowledgebase Document.<br/>
        /// Provides information about all RAG indexes of the specified knowledgebase document.
        /// </summary>
        /// <param name="documentationId">
        /// The id of a document from the knowledge base. This is returned on document addition.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.RAGDocumentIndexesResponseModel> GetDocumentRagIndexesAsync(
            string documentationId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Rag Indexes Of The Specified Knowledgebase Document.<br/>
        /// Provides information about all RAG indexes of the specified knowledgebase document.
        /// </summary>
        /// <param name="documentationId">
        /// The id of a document from the knowledge base. This is returned on document addition.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.RAGDocumentIndexesResponseModel>> GetDocumentRagIndexesAsResponseAsync(
            string documentationId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}