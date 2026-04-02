#nullable enable

namespace ElevenLabs
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Delete Voice<br/>
        /// Deletes a voice by its ID.
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.DeleteVoiceResponseModel> DeleteAsync(
            string voiceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}