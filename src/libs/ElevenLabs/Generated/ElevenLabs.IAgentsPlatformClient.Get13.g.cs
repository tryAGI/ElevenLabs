#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Get Tool<br/>
        /// Get tool that is available in the workspace.
        /// </summary>
        /// <param name="toolId">
        /// ID of the requested tool.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ToolResponseModel> Get13Async(
            string toolId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}