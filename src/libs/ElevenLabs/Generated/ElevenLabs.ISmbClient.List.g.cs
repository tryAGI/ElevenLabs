#nullable enable

namespace ElevenLabs
{
    public partial interface ISmbClient
    {
        /// <summary>
        /// Get All Services<br/>
        /// Get all services for the current workspace with optional filters
        /// </summary>
        /// <param name="staffId"></param>
        /// <param name="assetId"></param>
        /// <param name="isActive"></param>
        /// <param name="kind"></param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::ElevenLabs.SMBServiceDBModel>> ListAsync(
            string? staffId = default,
            string? assetId = default,
            bool? isActive = default,
            global::ElevenLabs.SMBServiceKind? kind = default,
            string? xiWorkspaceId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get All Services<br/>
        /// Get all services for the current workspace with optional filters
        /// </summary>
        /// <param name="staffId"></param>
        /// <param name="assetId"></param>
        /// <param name="isActive"></param>
        /// <param name="kind"></param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::ElevenLabs.SMBServiceDBModel>>> ListAsResponseAsync(
            string? staffId = default,
            string? assetId = default,
            bool? isActive = default,
            global::ElevenLabs.SMBServiceKind? kind = default,
            string? xiWorkspaceId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}