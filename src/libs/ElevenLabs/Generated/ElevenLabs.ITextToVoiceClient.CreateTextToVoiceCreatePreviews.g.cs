#nullable enable

namespace ElevenLabs
{
    public partial interface ITextToVoiceClient
    {
        /// <summary>
        /// Generate Voice Previews From Description<br/>
        /// Generate custom voice previews based on provided voice description. The response includes a list of voice previews, each containing an id and a sample of the voice audio. If you like the voice preview and want to create a permanent voice, call `/v1/text-to-voice/create-voice-from-preview` with the corresponding voice id.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.VoicePreviewsResponseModel> CreateTextToVoiceCreatePreviewsAsync(
            global::ElevenLabs.BodyGenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Generate Voice Previews From Description<br/>
        /// Generate custom voice previews based on provided voice description. The response includes a list of voice previews, each containing an id and a sample of the voice audio. If you like the voice preview and want to create a permanent voice, call `/v1/text-to-voice/create-voice-from-preview` with the corresponding voice id.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="voiceDescription">
        /// Description to use for the created voice.<br/>
        /// Example: A sassy little squeaky mouse
        /// </param>
        /// <param name="text">
        /// Text to generate, text length has to be between 100 and 1000.<br/>
        /// Example: Every act of kindness, no matter how small, carries value and can make a difference, as no gesture of goodwill is ever wasted.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.VoicePreviewsResponseModel> CreateTextToVoiceCreatePreviewsAsync(
            string voiceDescription,
            string text,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}