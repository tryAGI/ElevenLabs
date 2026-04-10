#nullable enable

namespace ElevenLabs
{
    public partial interface IConversationalAiClient
    {
        /// <summary>
        /// Bulk Move Entities To Folder<br/>
        /// Moves multiple entities from one folder to another.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task BulkMoveAsync(

            global::ElevenLabs.BodyBulkMoveEntitiesToFolderV1ConvaiKnowledgeBaseBulkMovePost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk Move Entities To Folder<br/>
        /// Moves multiple entities from one folder to another.
        /// </summary>
        /// <param name="documentIds">
        /// The ids of documents or folders from the knowledge base.
        /// </param>
        /// <param name="moveTo">
        /// The folder to move the entities to. If not set, the entities will be moved to the root folder.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task BulkMoveAsync(
            global::System.Collections.Generic.IList<string> documentIds,
            string? moveTo = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}