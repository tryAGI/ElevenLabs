#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Bulk Move Tests To Folder<br/>
        /// Moves multiple tests or folders from one folder to another.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> MoveAsync(

            global::ElevenLabs.BodyBulkMoveTestsToFolderV1ConvaiAgentTestingBulkMovePost request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk Move Tests To Folder<br/>
        /// Moves multiple tests or folders from one folder to another.
        /// </summary>
        /// <param name="entityIds">
        /// The IDs of tests or folders to move.
        /// </param>
        /// <param name="moveTo">
        /// The folder to move the entities to. If not set, the entities will be moved to the root folder.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> MoveAsync(
            global::System.Collections.Generic.IList<string> entityIds,
            string? moveTo = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}