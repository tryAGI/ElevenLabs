#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Get Mcp Server<br/>
        /// Retrieve a specific MCP server configuration from the workspace.
        /// </summary>
        /// <param name="mcpServerId">
        /// ID of the MCP Server.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.MCPServerResponseModel> Get16Async(
            string mcpServerId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}