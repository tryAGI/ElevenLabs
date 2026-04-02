#nullable enable

namespace ElevenLabs
{
    public partial interface IPvcVoicesClient
    {
        /// <summary>
        /// Retrieve Voice Sample Audio<br/>
        /// Retrieve the first 30 seconds of voice sample audio with or without noise removal.
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.
        /// </param>
        /// <param name="sampleId">
        /// Sample ID to be used
        /// </param>
        /// <param name="removeBackgroundNoise">
        /// If set will remove background noise for voice samples using our audio isolation model. If the samples do not include background noise, it can make the quality worse.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.VoiceSamplePreviewResponseModel> GetAsync(
            string voiceId,
            string sampleId,
            bool? removeBackgroundNoise = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}