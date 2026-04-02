#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Delete Mcp Server Tool Approval<br/>
        /// Remove approval for a specific MCP tool when using per-tool approval mode.
        /// </summary>
        /// <param name="mcpServerId">
        /// ID of the MCP Server.
        /// </param>
        /// <param name="toolName">
        /// Name of the MCP tool to remove approval for.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.MCPServerResponseModel> Delete10Async(
            string mcpServerId,
            string toolName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}