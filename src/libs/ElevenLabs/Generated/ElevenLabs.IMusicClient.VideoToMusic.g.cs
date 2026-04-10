#nullable enable

namespace ElevenLabs
{
    public partial interface IMusicClient
    {
        /// <summary>
        /// Video To Music<br/>
        /// Generate background music from one or more video files. Videos are combined in order. Optional description and style tags influence the generated music.
        /// </summary>
        /// <param name="outputFormat">
        /// Output format of the generated audio. Formatted as codec_sample_rate_bitrate. So an mp3 with 22.05kHz sample rate at 32kbs is represented as mp3_22050_32. MP3 with 192kbps bitrate requires you to be subscribed to Creator tier or above. PCM with 44.1kHz sample rate requires you to be subscribed to Pro tier or above. Note that the μ-law format (sometimes written mu-law, often approximated as u-law) is commonly used for Twilio audio inputs.<br/>
        /// Default Value: mp3_44100_128
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> VideoToMusicAsync(

            global::ElevenLabs.BodyVideoToMusicV1MusicVideoToMusicPost request,
            global::ElevenLabs.AllowedOutputFormats? outputFormat = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Video To Music<br/>
        /// Generate background music from one or more video files. Videos are combined in order. Optional description and style tags influence the generated music.
        /// </summary>
        /// <param name="outputFormat">
        /// Output format of the generated audio. Formatted as codec_sample_rate_bitrate. So an mp3 with 22.05kHz sample rate at 32kbs is represented as mp3_22050_32. MP3 with 192kbps bitrate requires you to be subscribed to Creator tier or above. PCM with 44.1kHz sample rate requires you to be subscribed to Pro tier or above. Note that the μ-law format (sometimes written mu-law, often approximated as u-law) is commonly used for Twilio audio inputs.<br/>
        /// Default Value: mp3_44100_128
        /// </param>
        /// <param name="videos">
        ///             One or more video files sent via FormData array (multipart/form-data). They will be combined into one codec in order.<br/>
        ///             A maximum of 10 videos is allowed, where the total size of the combined video is limited to 200MB.<br/>
        ///             In total, the video can be up to 600 seconds long. Note that combining multiple videos may increase the request duration significantly. If possible, combine the videos beforehand.<br/>
        ///             
        /// </param>
        /// <param name="description">
        /// Optional text description of the music you want. A maximum of 1000 characters is allowed.
        /// </param>
        /// <param name="tags">
        /// Optional list of style tags (e.g. ['upbeat', 'cinematic']). A maximum of 10 tags is allowed.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="signWithC2pa">
        /// Whether to sign the generated song with C2PA. Applicable only for mp3 files.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> VideoToMusicAsync(
            global::System.Collections.Generic.IList<byte[]> videos,
            global::ElevenLabs.AllowedOutputFormats? outputFormat = default,
            string? description = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            bool? signWithC2pa = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}