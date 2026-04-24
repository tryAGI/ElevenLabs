#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Create Mcp Tool Configuration Override<br/>
        /// Create configuration overrides for a specific MCP tool.
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

            global::ElevenLabs.MCPToolConfigOverrideCreateRequestModel request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Mcp Tool Configuration Override<br/>
        /// Create configuration overrides for a specific MCP tool.
        /// </summary>
        /// <param name="mcpServerId">
        /// ID of the MCP Server.
        /// </param>
        /// <param name="preToolSpeech">
        /// If set, overrides the server's pre_tool_speech setting for this tool.
        /// </param>
        /// <param name="disableInterruptions">
        /// If set, overrides the server's disable_interruptions setting for this tool
        /// </param>
        /// <param name="toolCallSound">
        /// If set, overrides the server's tool_call_sound setting for this tool
        /// </param>
        /// <param name="toolCallSoundBehavior">
        /// If set, overrides the server's tool_call_sound_behavior setting for this tool
        /// </param>
        /// <param name="executionMode">
        /// If set, overrides the server's execution_mode setting for this tool
        /// </param>
        /// <param name="responseTimeoutSecs">
        /// If set, overrides the server's response timeout for this MCP tool.
        /// </param>
        /// <param name="assignments">
        /// Dynamic variable assignments for this MCP tool
        /// </param>
        /// <param name="inputOverrides">
        /// Mapping of json path to input override configuration
        /// </param>
        /// <param name="responseMocks">
        /// Mock responses with optional parameter conditions. Evaluated top-to-bottom; first match wins.
        /// </param>
        /// <param name="toolName">
        /// The name of the MCP tool
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.MCPServerResponseModel> Create12Async(
            string mcpServerId,
            string toolName,
            global::ElevenLabs.PreToolSpeechMode? preToolSpeech = default,
            bool? disableInterruptions = default,
            global::ElevenLabs.ToolCallSoundType? toolCallSound = default,
            global::ElevenLabs.ToolCallSoundBehavior? toolCallSoundBehavior = default,
            global::ElevenLabs.ToolExecutionMode? executionMode = default,
            int? responseTimeoutSecs = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableAssignment>? assignments = default,
            object? inputOverrides = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.ToolResponseMockConfigInput>? responseMocks = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}