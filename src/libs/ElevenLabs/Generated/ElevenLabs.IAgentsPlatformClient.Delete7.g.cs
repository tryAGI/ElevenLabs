#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Delete Convai Workspace Secret<br/>
        /// Delete a workspace secret if it's not in use
        /// </summary>
        /// <param name="secretId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task Delete7Async(
            string secretId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}