#nullable enable

namespace ElevenLabs
{
    public partial interface ISmbClient
    {
        /// <summary>
        /// Get All Products<br/>
        /// List the workspace's products, optionally filtered by group or active state.
        /// </summary>
        /// <param name="group">
        /// Only products filed under the group with this label.
        /// </param>
        /// <param name="isActive">
        /// Only active (`true`) or inactive (`false`) products.
        /// </param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionProduct>> List3Async(
            string xiWorkspaceId,
            string? group = default,
            bool? isActive = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get All Products<br/>
        /// List the workspace's products, optionally filtered by group or active state.
        /// </summary>
        /// <param name="group">
        /// Only products filed under the group with this label.
        /// </param>
        /// <param name="isActive">
        /// Only active (`true`) or inactive (`false`) products.
        /// </param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionProduct>>> List3AsResponseAsync(
            string xiWorkspaceId,
            string? group = default,
            bool? isActive = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}