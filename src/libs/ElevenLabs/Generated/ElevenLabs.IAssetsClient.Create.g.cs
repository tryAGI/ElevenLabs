#nullable enable

namespace ElevenLabs
{
    public partial interface IAssetsClient
    {
        /// <summary>
        /// Upload Asset<br/>
        /// Upload a new asset.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AssetResponse> CreateAsync(

            global::ElevenLabs.BodyUploadAssetV1AssetsPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Asset<br/>
        /// Upload a new asset.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.AssetResponse>> CreateAsResponseAsync(

            global::ElevenLabs.BodyUploadAssetV1AssetsPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Asset<br/>
        /// Upload a new asset.
        /// </summary>
        /// <param name="asset">
        /// The file to upload.
        /// </param>
        /// <param name="assetname">
        /// The file to upload.
        /// </param>
        /// <param name="name">
        /// Display name for the asset.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AssetResponse> CreateAsync(
            byte[] asset,
            string assetname,
            string name,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload Asset<br/>
        /// Upload a new asset.
        /// </summary>
        /// <param name="asset">
        /// The file to upload.
        /// </param>
        /// <param name="assetname">
        /// The file to upload.
        /// </param>
        /// <param name="name">
        /// Display name for the asset.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AssetResponse> CreateAsync(
            global::System.IO.Stream asset,
            string assetname,
            string name,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Asset<br/>
        /// Upload a new asset.
        /// </summary>
        /// <param name="asset">
        /// The file to upload.
        /// </param>
        /// <param name="assetname">
        /// The file to upload.
        /// </param>
        /// <param name="name">
        /// Display name for the asset.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.AssetResponse>> CreateAsResponseAsync(
            global::System.IO.Stream asset,
            string assetname,
            string name,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}