#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Get Convai Settings<br/>
        /// Retrieve Convai settings for the workspace
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetConvAISettingsResponseModel> Get13Async(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}