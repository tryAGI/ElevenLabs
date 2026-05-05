#nullable enable

namespace ElevenLabs
{
    public partial interface IConversationalAi2Client
    {
        /// <summary>
        /// Delete Rag Index.<br/>
        /// Delete RAG index for the knowledgebase document.
        /// </summary>
        /// <param name="documentationId">
        /// The id of a document from the knowledge base. This is returned on document addition.
        /// </param>
        /// <param name="ragIndexId">
        /// The id of RAG index of document from the knowledge base.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.RAGDocumentIndexResponseModel> DeleteDocumentRagIndexAsync(
            string documentationId,
            string ragIndexId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Rag Index.<br/>
        /// Delete RAG index for the knowledgebase document.
        /// </summary>
        /// <param name="documentationId">
        /// The id of a document from the knowledge base. This is returned on document addition.
        /// </param>
        /// <param name="ragIndexId">
        /// The id of RAG index of document from the knowledge base.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.RAGDocumentIndexResponseModel>> DeleteDocumentRagIndexAsResponseAsync(
            string documentationId,
            string ragIndexId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}