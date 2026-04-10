#nullable enable

namespace ElevenLabs
{
    public partial interface IDubbingClient
    {
        /// <summary>
        /// Render Audio Or Video For The Given Language<br/>
        /// Regenerate the output media for a language using the latest Studio state. Please ensure all segments have been dubbed before rendering, otherwise they will be omitted. Renders are generated asynchronously, and to check the status of all renders please use the 'Get Dubbing Resource' endpoint.
        /// </summary>
        /// <param name="dubbingId">
        /// ID of the dubbing project.
        /// </param>
        /// <param name="language">
        /// The target language code to render, eg. 'es'. To render the source track use 'original'.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.DubbingRenderResponseModel> RenderAsync(
            string dubbingId,
            string language,

            global::ElevenLabs.BodyRenderAudioOrVideoForTheGivenLanguageV1DubbingResourceDubbingIdRenderLanguagePost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Render Audio Or Video For The Given Language<br/>
        /// Regenerate the output media for a language using the latest Studio state. Please ensure all segments have been dubbed before rendering, otherwise they will be omitted. Renders are generated asynchronously, and to check the status of all renders please use the 'Get Dubbing Resource' endpoint.
        /// </summary>
        /// <param name="dubbingId">
        /// ID of the dubbing project.
        /// </param>
        /// <param name="language">
        /// The target language code to render, eg. 'es'. To render the source track use 'original'.
        /// </param>
        /// <param name="renderType">
        /// The type of the render. One of ['mp4', 'aac', 'mp3', 'wav', 'aaf', 'tracks_zip', 'clips_zip']
        /// </param>
        /// <param name="normalizeVolume">
        /// Whether to normalize the volume of the rendered audio.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.DubbingRenderResponseModel> RenderAsync(
            string dubbingId,
            string language,
            global::ElevenLabs.RenderType2 renderType,
            bool? normalizeVolume = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}