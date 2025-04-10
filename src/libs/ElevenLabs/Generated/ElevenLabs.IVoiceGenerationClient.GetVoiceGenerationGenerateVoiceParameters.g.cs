#nullable enable

namespace ElevenLabs
{
    public partial interface IVoiceGenerationClient
    {
        /// <summary>
        /// Voice Generation Parameters<br/>
        /// Get possible parameters for the /v1/voice-generation/generate-voice endpoint.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.VoiceGenerationParameterResponseModel> GetVoiceGenerationGenerateVoiceParametersAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}