#nullable enable

namespace ElevenLabs
{
    public partial interface ITextToVoiceClient
    {
        /// <summary>
        /// Generate A Voice Preview From Description<br/>
        /// Generate a custom voice based on voice description. This method returns a list of voice previews. Each preview has a generated_voice_id and a sample of the voice as base64 encoded mp3 audio. If you like the a voice previewand want to create the voice call /v1/text-to-voice/create-voice-from-preview with the generated_voice_id to create the voice.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.VoicePreviewsResponseModel> CreateTextToVoiceCreatePreviewsAsync(
            global::ElevenLabs.BodyGenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Generate A Voice Preview From Description<br/>
        /// Generate a custom voice based on voice description. This method returns a list of voice previews. Each preview has a generated_voice_id and a sample of the voice as base64 encoded mp3 audio. If you like the a voice previewand want to create the voice call /v1/text-to-voice/create-voice-from-preview with the generated_voice_id to create the voice.
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