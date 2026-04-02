#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Update Convai Dashboard Settings<br/>
        /// Update Convai dashboard settings for the workspace
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetConvAIDashboardSettingsResponseModel> Update6Async(

            global::ElevenLabs.PatchConvAIDashboardSettingsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Convai Dashboard Settings<br/>
        /// Update Convai dashboard settings for the workspace
        /// </summary>
        /// <param name="charts"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetConvAIDashboardSettingsResponseModel> Update6Async(
            global::System.Collections.Generic.IList<global::ElevenLabs.ChartsItem2>? charts = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}