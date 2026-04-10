#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Get Documentation Chunk From Knowledge Base<br/>
        /// Get details about a specific documentation part used by RAG.
        /// </summary>
        /// <param name="documentationId">
        /// The id of a document from the knowledge base. This is returned on document addition.
        /// </param>
        /// <param name="chunkId">
        /// The id of a document RAG chunk from the knowledge base.
        /// </param>
        /// <param name="embeddingModel">
        /// The embedding model used to retrieve the chunk.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.KnowledgeBaseDocumentChunkResponseModel> Get12Async(
            string documentationId,
            string chunkId,
            global::ElevenLabs.EmbeddingModelEnum? embeddingModel = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}