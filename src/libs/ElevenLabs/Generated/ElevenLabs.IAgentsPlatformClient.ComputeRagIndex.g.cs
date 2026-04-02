#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Compute Rag Index.<br/>
        /// In case the document is not RAG indexed, it triggers rag indexing task, otherwise it just returns the current status.
        /// </summary>
        /// <param name="documentationId">
        /// The id of a document from the knowledge base. This is returned on document addition.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.RAGDocumentIndexResponseModel> ComputeRagIndexAsync(
            string documentationId,

            global::ElevenLabs.RAGIndexRequestModel request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Compute Rag Index.<br/>
        /// In case the document is not RAG indexed, it triggers rag indexing task, otherwise it just returns the current status.
        /// </summary>
        /// <param name="documentationId">
        /// The id of a document from the knowledge base. This is returned on document addition.
        /// </param>
        /// <param name="model">
        /// Default Value: e5_mistral_7b_instruct
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.RAGDocumentIndexResponseModel> ComputeRagIndexAsync(
            string documentationId,
            global::ElevenLabs.EmbeddingModelEnum model = global::ElevenLabs.EmbeddingModelEnum.E5Mistral7bInstruct,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}