#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Add Tool<br/>
        /// Add a new tool to the available tools in the workspace.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ToolResponseModel> Create7Async(

            global::ElevenLabs.ToolRequestModel request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Tool<br/>
        /// Add a new tool to the available tools in the workspace.
        /// </summary>
        /// <param name="toolConfig">
        /// Configuration for the tool
        /// </param>
        /// <param name="responseMocks">
        /// Mock responses with optional parameter conditions. Evaluated top-to-bottom; first match wins.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ToolResponseModel> Create7Async(
            global::ElevenLabs.ToolConfig toolConfig,
            global::System.Collections.Generic.IList<global::ElevenLabs.ToolResponseMockConfigInput>? responseMocks = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}