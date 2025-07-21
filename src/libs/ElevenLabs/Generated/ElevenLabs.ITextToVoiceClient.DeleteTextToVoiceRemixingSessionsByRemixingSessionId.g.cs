#nullable enable

namespace ElevenLabs
{
    public partial interface ITextToVoiceClient
    {
        /// <summary>
        /// Delete Voice Remixing Session<br/>
        /// Delete voice remixing session
        /// </summary>
        /// <param name="remixingSessionId">
        /// The remixing session id.<br/>
        /// Example: 123
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.DeleteVoiceRemixingSessionResponseModel> DeleteTextToVoiceRemixingSessionsByRemixingSessionIdAsync(
            string remixingSessionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}