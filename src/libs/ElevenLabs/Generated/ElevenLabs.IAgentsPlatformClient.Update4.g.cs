#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Update Document<br/>
        /// Update the name of a document
        /// </summary>
        /// <param name="documentationId">
        /// The id of a document from the knowledge base. This is returned on document addition.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.UpdateDocumentRouteResponse> Update4Async(
            string documentationId,

            global::ElevenLabs.BodyUpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatch request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Document<br/>
        /// Update the name of a document
        /// </summary>
        /// <param name="documentationId">
        /// The id of a document from the knowledge base. This is returned on document addition.
        /// </param>
        /// <param name="name">
        /// A custom, human-readable name for the document.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.UpdateDocumentRouteResponse> Update4Async(
            string documentationId,
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}