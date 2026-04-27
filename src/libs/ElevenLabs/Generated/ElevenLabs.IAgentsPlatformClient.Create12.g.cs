#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Create Mcp Server Tool Approval<br/>
        /// Add approval for a specific MCP tool when using per-tool approval mode.
        /// </summary>
        /// <param name="mcpServerId">
        /// ID of the MCP Server.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.MCPServerResponseModel> Create12Async(
            string mcpServerId,

            global::ElevenLabs.MCPToolAddApprovalRequestModel request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Mcp Server Tool Approval<br/>
        /// Add approval for a specific MCP tool when using per-tool approval mode.
        /// </summary>
        /// <param name="mcpServerId">
        /// ID of the MCP Server.
        /// </param>
        /// <param name="toolName">
        /// The name of the MCP tool
        /// </param>
        /// <param name="toolDescription">
        /// The description of the MCP tool
        /// </param>
        /// <param name="inputSchema">
        /// The input schema of the MCP tool (the schema defined on the MCP server before ElevenLabs does any extra processing)
        /// </param>
        /// <param name="approvalPolicy">
        /// The tool-level approval policy<br/>
        /// Default Value: requires_approval
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.MCPServerResponseModel> Create12Async(
            string mcpServerId,
            string toolName,
            string toolDescription,
            object? inputSchema = default,
            global::ElevenLabs.MCPToolApprovalPolicy? approvalPolicy = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}