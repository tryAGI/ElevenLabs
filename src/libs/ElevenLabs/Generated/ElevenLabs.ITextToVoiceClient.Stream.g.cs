#nullable enable

namespace ElevenLabs
{
    public partial interface ITextToVoiceClient
    {
        /// <summary>
        /// Text To Voice Preview Streaming<br/>
        /// Stream a voice preview that was created via the /v1/text-to-voice/design endpoint.
        /// </summary>
        /// <param name="generatedVoiceId">
        /// The generated_voice_id to stream.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> StreamAsync(
            string generatedVoiceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}