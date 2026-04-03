#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Create Agent Test Folder<br/>
        /// Creates a folder for organizing agent tests.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.CreateAgentTestFolderResponseModel> Create3Async(

            global::ElevenLabs.BodyCreateAgentTestFolderV1ConvaiAgentTestingFoldersPost request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Agent Test Folder<br/>
        /// Creates a folder for organizing agent tests.
        /// </summary>
        /// <param name="name">
        /// The name of the folder to create
        /// </param>
        /// <param name="parentFolderId">
        /// The ID of the parent folder. If not provided, the folder will be created at the root level.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.CreateAgentTestFolderResponseModel> Create3Async(
            string name,
            string? parentFolderId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}