#nullable enable

namespace ElevenLabs
{
    public partial interface IMusicClient
    {
        /// <summary>
        /// Upload Music<br/>
        /// Upload a music file to be later used for inpainting. Only available to enterprise clients with access to the inpainting feature.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.MusicUploadResponse> UploadAsync(

            global::ElevenLabs.BodyUploadMusicV1MusicUploadPost request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Music<br/>
        /// Upload a music file to be later used for inpainting. Only available to enterprise clients with access to the inpainting feature.
        /// </summary>
        /// <param name="file">
        /// The audio file to upload.
        /// </param>
        /// <param name="filename">
        /// The audio file to upload.
        /// </param>
        /// <param name="extractCompositionPlan">
        /// Whether to generate and return the composition plan for the uploaded song. If True, the response will include the composition_plan but will increase the latency.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.MusicUploadResponse> UploadAsync(
            byte[] file,
            string filename,
            bool? extractCompositionPlan = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}