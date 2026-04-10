#nullable enable

namespace ElevenLabs
{
    public partial interface IAudioIsolationClient
    {
        /// <summary>
        /// Audio Isolation Stream<br/>
        /// Removes background noise from audio and streams the result
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> StreamAsync(

            global::ElevenLabs.BodyAudioIsolationStreamV1AudioIsolationStreamPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Audio Isolation Stream<br/>
        /// Removes background noise from audio and streams the result
        /// </summary>
        /// <param name="audio">
        /// The audio file from which vocals/speech will be isolated from.
        /// </param>
        /// <param name="audioname">
        /// The audio file from which vocals/speech will be isolated from.
        /// </param>
        /// <param name="fileFormat">
        /// The format of input audio. Options are 'pcm_s16le_16' or 'other' For `pcm_s16le_16`, the input audio must be 16-bit PCM at a 16kHz sample rate, single channel (mono), and little-endian byte order. Latency will be lower than with passing an encoded waveform.<br/>
        /// Default Value: other
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> StreamAsync(
            byte[] audio,
            string audioname,
            global::ElevenLabs.BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat2? fileFormat = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}