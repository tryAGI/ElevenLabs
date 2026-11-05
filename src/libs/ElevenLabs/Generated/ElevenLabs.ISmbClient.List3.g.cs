#nullable enable

namespace ElevenLabs
{
    public partial interface ISmbClient
    {
        /// <summary>
        /// Get All Products<br/>
        /// List the workspace's products, optionally filtered by group or active state.
        /// </summary>
        /// <param name="group"></param>
        /// <param name="isActive"></param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::ElevenLabs.SMBProductDBModel>> List3Async(
            string? group = default,
            bool? isActive = default,
            string? xiWorkspaceId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get All Products<br/>
        /// List the workspace's products, optionally filtered by group or active state.
        /// </summary>
        /// <param name="group"></param>
        /// <param name="isActive"></param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::ElevenLabs.SMBProductDBModel>>> List3AsResponseAsync(
            string? group = default,
            bool? isActive = default,
            string? xiWorkspaceId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}