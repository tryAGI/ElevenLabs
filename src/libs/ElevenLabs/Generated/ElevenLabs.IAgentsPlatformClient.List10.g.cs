#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// List Mcp Servers<br/>
        /// Retrieve all MCP server configurations available in the workspace.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.MCPServersResponseModel> List10Async(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}