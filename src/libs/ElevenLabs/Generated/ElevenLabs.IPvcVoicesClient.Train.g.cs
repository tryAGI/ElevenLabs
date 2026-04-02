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
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.StartPVCVoiceTrainingResponseModel> TrainAsync(
            string voiceId,

            global::ElevenLabs.BodyRunPvcTrainingV1VoicesPvcVoiceIdTrainPost request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run Pvc Training<br/>
        /// Start PVC training process for a voice.
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.
        /// </param>
        /// <param name="modelId">
        /// The model ID to use for the conversion.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.StartPVCVoiceTrainingResponseModel> TrainAsync(
            string voiceId,
            string? modelId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}