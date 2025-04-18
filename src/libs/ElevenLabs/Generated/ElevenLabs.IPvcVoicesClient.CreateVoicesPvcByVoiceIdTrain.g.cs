#nullable enable

namespace ElevenLabs
{
    public partial interface IPvcVoicesClient
    {
        /// <summary>
        /// Run Pvc Training<br/>
        /// Start PVC training process for a voice.
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
        global::System.Threading.Tasks.Task<global::ElevenLabs.StartPVCVoiceTrainingResponseModel> CreateVoicesPvcByVoiceIdTrainAsync(
            string voiceId,
            global::ElevenLabs.BodyRunPVCTrainingV1VoicesPvcVoiceIdTrainPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Run Pvc Training<br/>
        /// Start PVC training process for a voice.
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="modelId">
        /// The model ID to use for the conversion.<br/>
        /// Example: eleven_turbo_v2
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.StartPVCVoiceTrainingResponseModel> CreateVoicesPvcByVoiceIdTrainAsync(
            string voiceId,
            string? xiApiKey = default,
            string? modelId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}