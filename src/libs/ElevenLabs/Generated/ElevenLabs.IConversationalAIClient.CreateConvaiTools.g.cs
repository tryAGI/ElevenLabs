#nullable enable

namespace ElevenLabs
{
    public partial interface IConversationalAIClient
    {
        /// <summary>
        /// Add Tool<br/>
        /// Add a new tool to the available tools in the workspace.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ToolResponseModel> CreateConvaiToolsAsync(
            global::ElevenLabs.AllOf<global::ElevenLabs.ToolRequestModel> request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add Tool<br/>
        /// Add a new tool to the available tools in the workspace.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ToolResponseModel> CreateConvaiToolsAsync(
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}