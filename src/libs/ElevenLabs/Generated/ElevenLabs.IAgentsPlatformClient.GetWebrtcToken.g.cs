#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Get Webrtc Token<br/>
        /// Get a WebRTC session token for real-time communication.
        /// </summary>
        /// <param name="agentId">
        /// Agent id (agent_…) or speech engine external id (seng_), resolved to the same underlying resource.
        /// </param>
        /// <param name="participantName">
        /// Optional custom participant name. If not provided, user ID will be used
        /// </param>
        /// <param name="branchId">
        /// The ID of the branch to use
        /// </param>
        /// <param name="environment">
        /// The environment to use for resolving environment variables (e.g. 'production', 'staging'). Defaults to 'production'.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.TokenResponseModel> GetWebrtcTokenAsync(
            string agentId,
            string? participantName = default,
            string? branchId = default,
            string? environment = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Webrtc Token<br/>
        /// Get a WebRTC session token for real-time communication.
        /// </summary>
        /// <param name="agentId">
        /// Agent id (agent_…) or speech engine external id (seng_), resolved to the same underlying resource.
        /// </param>
        /// <param name="participantName">
        /// Optional custom participant name. If not provided, user ID will be used
        /// </param>
        /// <param name="branchId">
        /// The ID of the branch to use
        /// </param>
        /// <param name="environment">
        /// The environment to use for resolving environment variables (e.g. 'production', 'staging'). Defaults to 'production'.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.TokenResponseModel>> GetWebrtcTokenAsResponseAsync(
            string agentId,
            string? participantName = default,
            string? branchId = default,
            string? environment = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}