#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Get Mcp Tool Configuration Override<br/>
        /// Retrieve configuration overrides for a specific MCP tool.
        /// </summary>
        /// <param name="mcpServerId">
        /// ID of the MCP Server.
        /// </param>
        /// <param name="toolName">
        /// Name of the MCP tool to retrieve config overrides for.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.MCPToolConfigOverride> Get17Async(
            string mcpServerId,
            string toolName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}