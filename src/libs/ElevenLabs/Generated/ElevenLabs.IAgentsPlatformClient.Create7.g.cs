#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Create Convai Workspace Secret<br/>
        /// Create a new secret for the workspace
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.PostWorkspaceSecretResponseModel> Create7Async(

            global::ElevenLabs.PostWorkspaceSecretRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Convai Workspace Secret<br/>
        /// Create a new secret for the workspace
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.PostWorkspaceSecretResponseModel> Create7Async(
            string name,
            string value,
            string type = "new",
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}