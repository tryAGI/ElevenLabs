#nullable enable

namespace ElevenLabs
{
    public partial interface IProductionsClient
    {
        /// <summary>
        /// Register Media<br/>
        /// Registers a media file with an order, either by uploading it directly or by providing a URL to fetch it from. Exactly one of `media` or `media_url` must be provided. The registered media can then be referenced when adding order items.
        /// </summary>
        /// <param name="orderId">
        /// The ID of the order to which this media will be attached.
        /// </param>
        /// <param name="workspaceId">
        /// The ID of the workspace.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.RegisterMediaResponse> RegisterAsync(
            string orderId,
            string workspaceId,

            global::ElevenLabs.BodyRegisterMediaV1ProductionsWorkspaceWorkspaceIdOrdersOrderIdMediaPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Register Media<br/>
        /// Registers a media file with an order, either by uploading it directly or by providing a URL to fetch it from. Exactly one of `media` or `media_url` must be provided. The registered media can then be referenced when adding order items.
        /// </summary>
        /// <param name="orderId">
        /// The ID of the order to which this media will be attached.
        /// </param>
        /// <param name="workspaceId">
        /// The ID of the workspace.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.RegisterMediaResponse>> RegisterAsResponseAsync(
            string orderId,
            string workspaceId,

            global::ElevenLabs.BodyRegisterMediaV1ProductionsWorkspaceWorkspaceIdOrdersOrderIdMediaPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Register Media<br/>
        /// Registers a media file with an order, either by uploading it directly or by providing a URL to fetch it from. Exactly one of `media` or `media_url` must be provided. The registered media can then be referenced when adding order items.
        /// </summary>
        /// <param name="orderId">
        /// The ID of the order to which this media will be attached.
        /// </param>
        /// <param name="workspaceId">
        /// The ID of the workspace.
        /// </param>
        /// <param name="declaredLanguage">
        /// The language code of the media content (e.g. 'en', 'es').
        /// </param>
        /// <param name="media">
        /// The media file to upload. Mutually exclusive with media_url.
        /// </param>
        /// <param name="medianame">
        /// The media file to upload. Mutually exclusive with media_url.
        /// </param>
        /// <param name="mediaUrl">
        /// A URL to fetch the media file from. Mutually exclusive with media.
        /// </param>
        /// <param name="mediaUrlFilename">
        /// The filename for URL-sourced media (e.g. 'example.mp4'). Required when using media_url.
        /// </param>
        /// <param name="mediaUrlContentType">
        /// The MIME type for URL-sourced media (e.g. 'video/mp4'). Required when using media_url.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.RegisterMediaResponse> RegisterAsync(
            string orderId,
            string workspaceId,
            string declaredLanguage,
            byte[]? media = default,
            string? medianame = default,
            string? mediaUrl = default,
            string? mediaUrlFilename = default,
            string? mediaUrlContentType = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}