#nullable enable

namespace ElevenLabs
{
    public partial interface ISmbClient
    {
        /// <summary>
        /// Confirm Service Update<br/>
        /// Save a service update after user confirmed price impact. Optionally reprice future events.
        /// </summary>
        /// <param name="serviceId"></param>
        /// <param name="reprice">
        /// Default Value: false
        /// </param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ServiceUpdateResponse> ConfirmUpdateAsync(
            string serviceId,

            global::ElevenLabs.BodySmbConfirmServiceUpdate request,
            bool? reprice = default,
            string? xiWorkspaceId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Confirm Service Update<br/>
        /// Save a service update after user confirmed price impact. Optionally reprice future events.
        /// </summary>
        /// <param name="serviceId"></param>
        /// <param name="reprice">
        /// Default Value: false
        /// </param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.ServiceUpdateResponse>> ConfirmUpdateAsResponseAsync(
            string serviceId,

            global::ElevenLabs.BodySmbConfirmServiceUpdate request,
            bool? reprice = default,
            string? xiWorkspaceId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Confirm Service Update<br/>
        /// Save a service update after user confirmed price impact. Optionally reprice future events.
        /// </summary>
        /// <param name="serviceId"></param>
        /// <param name="reprice">
        /// Default Value: false
        /// </param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ServiceUpdateResponse> ConfirmUpdateAsync(
            string serviceId,
            global::ElevenLabs.SMBUpdateServiceRequestPatch request,
            bool? reprice = default,
            string? xiWorkspaceId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}