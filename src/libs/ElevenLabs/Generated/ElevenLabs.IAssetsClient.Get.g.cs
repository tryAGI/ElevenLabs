#nullable enable

namespace ElevenLabs
{
    public partial interface IAssetsClient
    {
        /// <summary>
        /// Get Asset<br/>
        /// Retrieve a single asset by ID.
        /// </summary>
        /// <param name="assetId">
        /// ID of the asset.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AssetResponse> GetAsync(
            string assetId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Asset<br/>
        /// Retrieve a single asset by ID.
        /// </summary>
        /// <param name="assetId">
        /// ID of the asset.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.AssetResponse>> GetAsResponseAsync(
            string assetId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}