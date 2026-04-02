#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Update Mcp Server Configuration<br/>
        /// Update the configuration settings for an MCP server.
        /// </summary>
        /// <param name="mcpServerId">
        /// ID of the MCP Server.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.MCPServerResponseModel> Update8Async(
            string mcpServerId,

            global::ElevenLabs.MCPServerConfigUpdateRequestModel request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Mcp Server Configuration<br/>
        /// Update the configuration settings for an MCP server.
        /// </summary>
        /// <param name="mcpServerId">
        /// ID of the MCP Server.
        /// </param>
        /// <param name="approvalPolicy">
        /// The approval mode to set for the MCP server
        /// </param>
        /// <param name="forcePreToolSpeech">
        /// If set, overrides the server's force_pre_tool_speech setting for this tool
        /// </param>
        /// <param name="disableInterruptions">
        /// If set, overrides the server's disable_interruptions setting for this tool
        /// </param>
        /// <param name="toolCallSound">
        /// Predefined tool call sound type to play during tool execution for all tools from this MCP server
        /// </param>
        /// <param name="toolCallSoundBehavior">
        /// Determines when the tool call sound should play for all tools from this MCP server
        /// </param>
        /// <param name="executionMode">
        /// If set, overrides the server's execution_mode setting for this tool
        /// </param>
        /// <param name="requestHeaders">
        /// The headers to include in requests to the MCP server
        /// </param>
        /// <param name="disableCompression">
        /// Whether to disable HTTP compression for this MCP server
        /// </param>
        /// <param name="secretToken">
        /// Optional secret token for authentication with this MCP server
        /// </param>
        /// <param name="authConnection">
        /// Optional auth connection to use for authentication with this MCP server
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.MCPServerResponseModel> Update8Async(
            string mcpServerId,
            global::ElevenLabs.MCPApprovalPolicy? approvalPolicy = default,
            bool? forcePreToolSpeech = default,
            bool? disableInterruptions = default,
            global::ElevenLabs.ToolCallSoundType? toolCallSound = default,
            global::ElevenLabs.ToolCallSoundBehavior? toolCallSoundBehavior = default,
            global::ElevenLabs.ToolExecutionMode? executionMode = default,
            object? requestHeaders = default,
            bool? disableCompression = default,
            global::ElevenLabs.ConvAISecretLocator? secretToken = default,
            global::ElevenLabs.AnyOf<global::ElevenLabs.AuthConnectionLocator, global::ElevenLabs.EnvironmentAuthConnectionLocator, object>? authConnection = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}