#nullable enable

namespace ElevenLabs
{
    public partial interface IPvcVoicesClient
    {
        /// <summary>
        /// Delete Pvc Voice Sample<br/>
        /// Delete a sample from a PVC voice.
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.
        /// </param>
        /// <param name="sampleId">
        /// Sample ID to be used
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.DeleteVoiceSampleResponseModel> DeleteAsync(
            string voiceId,
            string sampleId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}