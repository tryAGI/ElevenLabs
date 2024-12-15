#nullable enable

namespace ElevenLabs
{
    public partial interface ITextToVoiceClient
    {
        /// <summary>
        /// Generate A Voice Preview From Description<br/>
        /// Generate a custom voice based on voice description. This method returns a list of voice previews. Each preview has a generated_voice_id and a sample of the voice as base64 encoded mp3 audio. If you like the a voice previewand want to create the voice call /v1/text-to-voice/create-voice-from-preview with the generated_voice_id to create the voice.
        /// </summary>
        /// <param name="outputFormat">
        /// Output format of the generated audio. Must be one of:<br/>
        /// mp3_22050_32 - output format, mp3 with 22.05kHz sample rate at 32kbps.<br/>
        /// mp3_44100_32 - output format, mp3 with 44.1kHz sample rate at 32kbps.<br/>
        /// mp3_44100_64 - output format, mp3 with 44.1kHz sample rate at 64kbps.<br/>
        /// mp3_44100_96 - output format, mp3 with 44.1kHz sample rate at 96kbps.<br/>
        /// mp3_44100_128 - default output format, mp3 with 44.1kHz sample rate at 128kbps.<br/>
        /// mp3_44100_192 - output format, mp3 with 44.1kHz sample rate at 192kbps. Requires you to be subscribed to Creator tier or above.<br/>
        /// pcm_16000 - PCM format (S16LE) with 16kHz sample rate.<br/>
        /// pcm_22050 - PCM format (S16LE) with 22.05kHz sample rate.<br/>
        /// pcm_24000 - PCM format (S16LE) with 24kHz sample rate.<br/>
        /// pcm_44100 - PCM format (S16LE) with 44.1kHz sample rate. Requires you to be subscribed to Pro tier or above.<br/>
        /// ulaw_8000 - μ-law format (sometimes written mu-law, often approximated as u-law) with 8kHz sample rate. Note that this format is commonly used for Twilio audio inputs.<br/>
        /// Default Value: mp3_44100_192
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.VoicePreviewsResponseModel> CreateTextToVoiceCreatePreviewsAsync(
            global::ElevenLabs.VoicePreviewsRequestModel request,
            global::ElevenLabs.GenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPostOutputFormat? outputFormat = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Generate A Voice Preview From Description<br/>
        /// Generate a custom voice based on voice description. This method returns a list of voice previews. Each preview has a generated_voice_id and a sample of the voice as base64 encoded mp3 audio. If you like the a voice previewand want to create the voice call /v1/text-to-voice/create-voice-from-preview with the generated_voice_id to create the voice.
        /// </summary>
        /// <param name="outputFormat">
        /// Output format of the generated audio. Must be one of:<br/>
        /// mp3_22050_32 - output format, mp3 with 22.05kHz sample rate at 32kbps.<br/>
        /// mp3_44100_32 - output format, mp3 with 44.1kHz sample rate at 32kbps.<br/>
        /// mp3_44100_64 - output format, mp3 with 44.1kHz sample rate at 64kbps.<br/>
        /// mp3_44100_96 - output format, mp3 with 44.1kHz sample rate at 96kbps.<br/>
        /// mp3_44100_128 - default output format, mp3 with 44.1kHz sample rate at 128kbps.<br/>
        /// mp3_44100_192 - output format, mp3 with 44.1kHz sample rate at 192kbps. Requires you to be subscribed to Creator tier or above.<br/>
        /// pcm_16000 - PCM format (S16LE) with 16kHz sample rate.<br/>
        /// pcm_22050 - PCM format (S16LE) with 22.05kHz sample rate.<br/>
        /// pcm_24000 - PCM format (S16LE) with 24kHz sample rate.<br/>
        /// pcm_44100 - PCM format (S16LE) with 44.1kHz sample rate. Requires you to be subscribed to Pro tier or above.<br/>
        /// ulaw_8000 - μ-law format (sometimes written mu-law, often approximated as u-law) with 8kHz sample rate. Note that this format is commonly used for Twilio audio inputs.<br/>
        /// Default Value: mp3_44100_192
        /// </param>
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
        /// <param name="autoGenerateText">
        /// Whether to automatically generate a text suitable for the voice description.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.VoicePreviewsResponseModel> CreateTextToVoiceCreatePreviewsAsync(
            string voiceDescription,
            string text,
            global::ElevenLabs.GenerateAVoicePreviewFromDescriptionV1TextToVoiceCreatePreviewsPostOutputFormat? outputFormat = default,
            string? xiApiKey = default,
            bool? autoGenerateText = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}