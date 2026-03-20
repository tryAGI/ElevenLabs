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
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.RAGDocumentIndexResponseModel> CreateConvaiKnowledgeBaseByDocumentationIdRagIndexAsync(
            string documentationId,

            global::ElevenLabs.RAGIndexRequestModel request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Compute Rag Index.<br/>
        /// In case the document is not RAG indexed, it triggers rag indexing task, otherwise it just returns the current status.
        /// </summary>
        /// <param name="documentationId">
        /// The id of a document from the knowledge base. This is returned on document addition.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="model">
        /// Default Value: e5_mistral_7b_instruct
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.RAGDocumentIndexResponseModel> CreateConvaiKnowledgeBaseByDocumentationIdRagIndexAsync(
            string documentationId,
            string? xiApiKey = default,
            global::ElevenLabs.EmbeddingModelEnum model = global::ElevenLabs.EmbeddingModelEnum.E5Mistral7bInstruct,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}