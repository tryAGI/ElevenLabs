#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Update Agent Test Folder<br/>
        /// Updates an agent test folder. Currently only supports updating the folder name.
        /// </summary>
        /// <param name="folderId">
        /// The folder ID.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetAgentTestFolderResponseModel> Update2Async(
            string folderId,

            global::ElevenLabs.BodyUpdateAgentTestFolderV1ConvaiAgentTestingFoldersFolderIdPatch request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Agent Test Folder<br/>
        /// Updates an agent test folder. Currently only supports updating the folder name.
        /// </summary>
        /// <param name="folderId">
        /// The folder ID.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.GetAgentTestFolderResponseModel>> Update2AsResponseAsync(
            string folderId,

            global::ElevenLabs.BodyUpdateAgentTestFolderV1ConvaiAgentTestingFoldersFolderIdPatch request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Agent Test Folder<br/>
        /// Updates an agent test folder. Currently only supports updating the folder name.
        /// </summary>
        /// <param name="folderId">
        /// The folder ID.
        /// </param>
        /// <param name="name">
        /// The new name for the folder
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetAgentTestFolderResponseModel> Update2Async(
            string folderId,
            string name,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}