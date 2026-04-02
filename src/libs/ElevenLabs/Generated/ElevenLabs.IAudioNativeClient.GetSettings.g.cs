#nullable enable

namespace ElevenLabs
{
    public partial interface IAudioNativeClient
    {
        /// <summary>
        /// Get Audio Native Project Settings<br/>
        /// Get player settings for the specific project.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the Studio project.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetAudioNativeProjectSettingsResponseModel> GetSettingsAsync(
            string projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}