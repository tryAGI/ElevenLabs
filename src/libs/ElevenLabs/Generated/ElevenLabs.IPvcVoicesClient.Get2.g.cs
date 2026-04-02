#nullable enable

namespace ElevenLabs
{
    public partial interface IPvcVoicesClient
    {
        /// <summary>
        /// Retrieve Voice Sample Visual Waveform<br/>
        /// Retrieve the visual waveform of a voice sample.
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.
        /// </param>
        /// <param name="sampleId">
        /// Sample ID to be used
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.VoiceSampleVisualWaveformResponseModel> Get2Async(
            string voiceId,
            string sampleId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}