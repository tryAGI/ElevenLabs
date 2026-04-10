#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Delete Agent Test Folder<br/>
        /// Deletes an agent test folder by ID. Use force=true to delete a non-empty folder and all its contents.
        /// </summary>
        /// <param name="folderId">
        /// The folder ID.
        /// </param>
        /// <param name="force">
        /// Force delete. Required for deleting non-empty folders.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task Delete2Async(
            string folderId,
            bool? force = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}