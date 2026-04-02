#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Update Convai Workspace Secret<br/>
        /// Update an existing secret for the workspace
        /// </summary>
        /// <param name="secretId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.PostWorkspaceSecretResponseModel> Update7Async(
            string secretId,

            global::ElevenLabs.PatchWorkspaceSecretRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Convai Workspace Secret<br/>
        /// Update an existing secret for the workspace
        /// </summary>
        /// <param name="secretId"></param>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.PostWorkspaceSecretResponseModel> Update7Async(
            string secretId,
            string name,
            string value,
            string type = "update",
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}