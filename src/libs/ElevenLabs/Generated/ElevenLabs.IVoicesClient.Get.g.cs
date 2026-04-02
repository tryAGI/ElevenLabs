#nullable enable

namespace ElevenLabs
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Get Voice Settings<br/>
        /// Returns the settings for a specific voice. "similarity_boost" corresponds to"Clarity + Similarity Enhancement" in the web app and "stability" corresponds to "Stability" slider in the web app.
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.VoiceSettingsResponseModel> GetAsync(
            string voiceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}