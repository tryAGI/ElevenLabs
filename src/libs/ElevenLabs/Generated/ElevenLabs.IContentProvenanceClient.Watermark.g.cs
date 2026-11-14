#nullable enable

namespace ElevenLabs
{
    public partial interface IContentProvenanceClient
    {
        /// <summary>
        /// Check Watermark<br/>
        /// Check an audio file for an embedded ElevenLabs watermark. This endpoint is in beta and may change.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.WatermarkCheck> WatermarkAsync(

            global::ElevenLabs.BodyCheckWatermarkV1ContentProvenanceWatermarkPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check Watermark<br/>
        /// Check an audio file for an embedded ElevenLabs watermark. This endpoint is in beta and may change.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.WatermarkCheck>> WatermarkAsResponseAsync(

            global::ElevenLabs.BodyCheckWatermarkV1ContentProvenanceWatermarkPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check Watermark<br/>
        /// Check an audio file for an embedded ElevenLabs watermark. This endpoint is in beta and may change.
        /// </summary>
        /// <param name="file">
        /// Audio file to check for an embedded watermark.
        /// </param>
        /// <param name="filename">
        /// Audio file to check for an embedded watermark.
        /// </param>
        /// <param name="version">
        /// Watermark decoder version. Defaults to latest.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.WatermarkCheck> WatermarkAsync(
            byte[] file,
            string filename,
            string? version = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Check Watermark<br/>
        /// Check an audio file for an embedded ElevenLabs watermark. This endpoint is in beta and may change.
        /// </summary>
        /// <param name="file">
        /// Audio file to check for an embedded watermark.
        /// </param>
        /// <param name="filename">
        /// Audio file to check for an embedded watermark.
        /// </param>
        /// <param name="version">
        /// Watermark decoder version. Defaults to latest.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.WatermarkCheck> WatermarkAsync(
            global::System.IO.Stream file,
            string filename,
            string? version = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check Watermark<br/>
        /// Check an audio file for an embedded ElevenLabs watermark. This endpoint is in beta and may change.
        /// </summary>
        /// <param name="file">
        /// Audio file to check for an embedded watermark.
        /// </param>
        /// <param name="filename">
        /// Audio file to check for an embedded watermark.
        /// </param>
        /// <param name="version">
        /// Watermark decoder version. Defaults to latest.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.WatermarkCheck>> WatermarkAsResponseAsync(
            global::System.IO.Stream file,
            string filename,
            string? version = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}