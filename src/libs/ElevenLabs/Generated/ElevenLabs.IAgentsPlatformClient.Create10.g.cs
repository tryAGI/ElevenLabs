#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Create Mcp Server<br/>
        /// Create a new MCP server configuration in the workspace.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.MCPServerResponseModel> Create10Async(

            global::ElevenLabs.MCPServerRequestModel request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Mcp Server<br/>
        /// Create a new MCP server configuration in the workspace.
        /// </summary>
        /// <param name="config">
        /// Configuration details for the MCP Server.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.MCPServerResponseModel> Create10Async(
            global::ElevenLabs.MCPServerConfigInput config,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}