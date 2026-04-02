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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.RAGDocumentIndexesResponseModel> GetDocumentRagIndexesAsync(
            string documentationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}