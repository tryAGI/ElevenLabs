#nullable enable

namespace ElevenLabs
{
    public partial interface IConversationalAiClient
    {
        /// <summary>
        /// Move Entity To Folder<br/>
        /// Moves the entity from one folder to another.
        /// </summary>
        /// <param name="documentId">
        /// The id of a document from the knowledge base. This is returned on document addition.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task MoveAsync(
            string documentId,

            global::ElevenLabs.BodyMoveEntityToFolderV1ConvaiKnowledgeBaseDocumentIdMovePost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Move Entity To Folder<br/>
        /// Moves the entity from one folder to another.
        /// </summary>
        /// <param name="documentId">
        /// The id of a document from the knowledge base. This is returned on document addition.
        /// </param>
        /// <param name="moveTo">
        /// The folder to move the entities to. If not set, the entities will be moved to the root folder.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task MoveAsync(
            string documentId,
            string? moveTo = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}