#nullable enable

namespace ElevenLabs
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Edit Voice Settings<br/>
        /// Edit your settings for a specific voice. "similarity_boost" corresponds to "Clarity + Similarity Enhancement" in the web app and "stability" corresponds to "Stability" slider in the web app.
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.EditVoiceSettingsResponseModel> CreateVoicesByVoiceIdSettingsEditAsync(
            string voiceId,
            global::ElevenLabs.VoiceSettingsResponseModel request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Edit Voice Settings<br/>
        /// Edit your settings for a specific voice. "similarity_boost" corresponds to "Clarity + Similarity Enhancement" in the web app and "stability" corresponds to "Stability" slider in the web app.
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="stability">
        /// Determines how stable the voice is and the randomness between each generation. Lower values introduce broader emotional range for the voice. Higher values can result in a monotonous voice with limited emotion.
        /// </param>
        /// <param name="similarityBoost">
        /// Determines how closely the AI should adhere to the original voice when attempting to replicate it.
        /// </param>
        /// <param name="style">
        /// Determines the style exaggeration of the voice. This setting attempts to amplify the style of the original speaker. It does consume additional computational resources and might increase latency if set to anything other than 0.
        /// </param>
        /// <param name="useSpeakerBoost">
        /// This setting boosts the similarity to the original speaker. Using this setting requires a slightly higher computational load, which in turn increases latency.
        /// </param>
        /// <param name="speed">
        /// Controls the speed of the generated speech. Values range from 0.7 to 1.2, with 1.0 being the default speed. Lower values create slower, more deliberate speech while higher values produce faster-paced speech. Extreme values can impact the quality of the generated speech.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.EditVoiceSettingsResponseModel> CreateVoicesByVoiceIdSettingsEditAsync(
            string voiceId,
            string? xiApiKey = default,
            double? stability = default,
            double? similarityBoost = default,
            double? style = default,
            bool? useSpeakerBoost = default,
            double? speed = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}