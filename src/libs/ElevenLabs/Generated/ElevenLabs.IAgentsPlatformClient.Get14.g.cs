#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Get Convai Dashboard Settings<br/>
        /// Retrieve Convai dashboard settings for the workspace
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetConvAIDashboardSettingsResponseModel> Get14Async(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}