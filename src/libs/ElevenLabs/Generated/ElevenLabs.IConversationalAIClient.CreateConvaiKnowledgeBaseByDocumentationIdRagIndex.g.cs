#nullable enable

namespace ElevenLabs
{
    public partial interface IConversationalAIClient
    {
        /// <summary>
        /// Compute Rag Index.<br/>
        /// In case the document is not RAG indexed, it triggers rag indexing task, otherwise it just returns the current status.
        /// </summary>
        /// <param name="documentationId">
        /// The id of a document from the knowledge base. This is returned on document addition.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="forceReindex">
        /// In case the document is indexed and for some reason you want to reindex it, set this param as true.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.RAGIndexResponseModel> CreateConvaiKnowledgeBaseByDocumentationIdRagIndexAsync(
            string documentationId,
            global::ElevenLabs.AllOf<global::ElevenLabs.RAGIndexRequestModel> request,
            bool? forceReindex = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Compute Rag Index.<br/>
        /// In case the document is not RAG indexed, it triggers rag indexing task, otherwise it just returns the current status.
        /// </summary>
        /// <param name="documentationId">
        /// The id of a document from the knowledge base. This is returned on document addition.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="forceReindex">
        /// In case the document is indexed and for some reason you want to reindex it, set this param as true.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.RAGIndexResponseModel> CreateConvaiKnowledgeBaseByDocumentationIdRagIndexAsync(
            string documentationId,
            bool? forceReindex = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}