#nullable enable

namespace ElevenLabs
{
    public partial interface IMusicClient
    {
        /// <summary>
        /// Upload Music<br/>
        /// Upload a music file to be later used for inpainting. Price for uploading is the same as the one for song generation. All uploaded content gets inspected for copyright infringement. If copyrighted content is detected, half of the request cost is still charged.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.MusicUploadResponse> UploadAsync(

            global::ElevenLabs.BodyUploadMusicV1MusicUploadPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Music<br/>
        /// Upload a music file to be later used for inpainting. Price for uploading is the same as the one for song generation. All uploaded content gets inspected for copyright infringement. If copyrighted content is detected, half of the request cost is still charged.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.MusicUploadResponse>> UploadAsResponseAsync(

            global::ElevenLabs.BodyUploadMusicV1MusicUploadPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Music<br/>
        /// Upload a music file to be later used for inpainting. Price for uploading is the same as the one for song generation. All uploaded content gets inspected for copyright infringement. If copyrighted content is detected, half of the request cost is still charged.
        /// </summary>
        /// <param name="file">
        /// The audio file to upload.
        /// </param>
        /// <param name="filename">
        /// The audio file to upload.
        /// </param>
        /// <param name="extractCompositionPlan">
        /// Whether to generate and return the composition plan for the uploaded song. Pass a model id (`music_v1` or `music_v2`) to control which composition plan format is returned. Passing `true`/`false` is deprecated; `true` defaults to the `music_v1` plan format. Enabling this will increase the latency.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="withTimestamps">
        /// Whether to transcribe the uploaded song and return word-level timestamps. If True, the response will include words_timestamps but will increase the latency.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.MusicUploadResponse> UploadAsync(
            byte[] file,
            string filename,
            global::ElevenLabs.AnyOf<bool?, string>? extractCompositionPlan = default,
            bool? withTimestamps = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload Music<br/>
        /// Upload a music file to be later used for inpainting. Price for uploading is the same as the one for song generation. All uploaded content gets inspected for copyright infringement. If copyrighted content is detected, half of the request cost is still charged.
        /// </summary>
        /// <param name="file">
        /// The audio file to upload.
        /// </param>
        /// <param name="filename">
        /// The audio file to upload.
        /// </param>
        /// <param name="extractCompositionPlan">
        /// Whether to generate and return the composition plan for the uploaded song. Pass a model id (`music_v1` or `music_v2`) to control which composition plan format is returned. Passing `true`/`false` is deprecated; `true` defaults to the `music_v1` plan format. Enabling this will increase the latency.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="withTimestamps">
        /// Whether to transcribe the uploaded song and return word-level timestamps. If True, the response will include words_timestamps but will increase the latency.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.MusicUploadResponse> UploadAsync(
            global::System.IO.Stream file,
            string filename,
            global::ElevenLabs.AnyOf<bool?, string>? extractCompositionPlan = default,
            bool? withTimestamps = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Music<br/>
        /// Upload a music file to be later used for inpainting. Price for uploading is the same as the one for song generation. All uploaded content gets inspected for copyright infringement. If copyrighted content is detected, half of the request cost is still charged.
        /// </summary>
        /// <param name="file">
        /// The audio file to upload.
        /// </param>
        /// <param name="filename">
        /// The audio file to upload.
        /// </param>
        /// <param name="extractCompositionPlan">
        /// Whether to generate and return the composition plan for the uploaded song. Pass a model id (`music_v1` or `music_v2`) to control which composition plan format is returned. Passing `true`/`false` is deprecated; `true` defaults to the `music_v1` plan format. Enabling this will increase the latency.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="withTimestamps">
        /// Whether to transcribe the uploaded song and return word-level timestamps. If True, the response will include words_timestamps but will increase the latency.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.MusicUploadResponse>> UploadAsResponseAsync(
            global::System.IO.Stream file,
            string filename,
            global::ElevenLabs.AnyOf<bool?, string>? extractCompositionPlan = default,
            bool? withTimestamps = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}