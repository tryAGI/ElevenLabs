#nullable enable

namespace ElevenLabs
{
    public partial interface IConversationalAIClient
    {
        /// <summary>
        /// Update Convai Dashboard Settings<br/>
        /// Update Convai dashboard settings for the workspace
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetConvAIDashboardSettingsResponseModel> EditConvaiSettingsDashboardAsync(
            global::ElevenLabs.PatchConvAIDashboardSettingsRequest request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Convai Dashboard Settings<br/>
        /// Update Convai dashboard settings for the workspace
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="charts"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetConvAIDashboardSettingsResponseModel> EditConvaiSettingsDashboardAsync(
            string? xiApiKey = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.ChartsItem2>? charts = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}