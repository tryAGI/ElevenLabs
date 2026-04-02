#nullable enable

namespace ElevenLabs
{
    public partial interface IPvcVoicesClient
    {
        /// <summary>
        /// Verify Pvc Voice Captcha<br/>
        /// Submit captcha verification for PVC voice.
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.VerifyPVCVoiceCaptchaResponseModel> VerifyAsync(
            string voiceId,

            global::ElevenLabs.BodyVerifyPvcVoiceCaptchaV1VoicesPvcVoiceIdCaptchaPost request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Verify Pvc Voice Captcha<br/>
        /// Submit captcha verification for PVC voice.
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.
        /// </param>
        /// <param name="recording">
        /// Audio recording of the user
        /// </param>
        /// <param name="recordingname">
        /// Audio recording of the user
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.VerifyPVCVoiceCaptchaResponseModel> VerifyAsync(
            string voiceId,
            byte[] recording,
            string recordingname,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}