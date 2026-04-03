#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Get Agent Test Folder By Id<br/>
        /// Gets an agent test folder by ID, including its folder path.
        /// </summary>
        /// <param name="folderId">
        /// The folder ID.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetAgentTestFolderResponseModel> Get5Async(
            string folderId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}