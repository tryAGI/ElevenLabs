#nullable enable

namespace ElevenLabs
{
    public partial interface ITextToVoiceClient
    {
        /// <summary>
        /// Text To Voice Preview Streaming<br/>
        /// Stream a the voice preview for a generated voice as it is being generated.
        /// </summary>
        /// <param name="generatedVoiceId">
        /// The generated_voice_id to stream.<br/>
        /// Example: 37HceQefKmEi3bGovXjL
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> GetTextToVoiceByGeneratedVoiceIdStreamAsync(
            string generatedVoiceId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}