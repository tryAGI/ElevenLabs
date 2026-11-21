#nullable enable

namespace ElevenLabs
{
    public partial interface ISmbClient
    {
        /// <summary>
        /// Get All Services<br/>
        /// Get all services for the current workspace with optional filters
        /// </summary>
        /// <param name="staffId">
        /// Only services this staff member performs.
        /// </param>
        /// <param name="assetId">
        /// Only services that book this asset.
        /// </param>
        /// <param name="isActive">
        /// Only active (`true`) or inactive (`false`) services.
        /// </param>
        /// <param name="kind">
        /// Only services of this kind.
        /// </param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionService>> ListAsync(
            string xiWorkspaceId,
            string? staffId = default,
            string? assetId = default,
            bool? isActive = default,
            global::ElevenLabs.ReceptionServiceKind? kind = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get All Services<br/>
        /// Get all services for the current workspace with optional filters
        /// </summary>
        /// <param name="staffId">
        /// Only services this staff member performs.
        /// </param>
        /// <param name="assetId">
        /// Only services that book this asset.
        /// </param>
        /// <param name="isActive">
        /// Only active (`true`) or inactive (`false`) services.
        /// </param>
        /// <param name="kind">
        /// Only services of this kind.
        /// </param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionService>>> ListAsResponseAsync(
            string xiWorkspaceId,
            string? staffId = default,
            string? assetId = default,
            bool? isActive = default,
            global::ElevenLabs.ReceptionServiceKind? kind = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}