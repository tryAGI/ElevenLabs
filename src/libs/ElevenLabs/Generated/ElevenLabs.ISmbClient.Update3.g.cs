#nullable enable

namespace ElevenLabs
{
    public partial interface ISmbClient
    {
        /// <summary>
        /// Update Customer Facing Agent<br/>
        /// Update a receptionist's display name, config and/or widget appearance.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.SMBCustomerFacingAgentResponse> Update3Async(
            string agentId,

            global::ElevenLabs.SMBUpdateCustomerFacingAgentRequest request,
            string? xiWorkspaceId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Customer Facing Agent<br/>
        /// Update a receptionist's display name, config and/or widget appearance.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.SMBCustomerFacingAgentResponse>> Update3AsResponseAsync(
            string agentId,

            global::ElevenLabs.SMBUpdateCustomerFacingAgentRequest request,
            string? xiWorkspaceId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Customer Facing Agent<br/>
        /// Update a receptionist's display name, config and/or widget appearance.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="config"></param>
        /// <param name="name"></param>
        /// <param name="widget"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.SMBCustomerFacingAgentResponse> Update3Async(
            string agentId,
            string? xiWorkspaceId = default,
            global::ElevenLabs.CustomerFacingConfigPatch? config = default,
            string? name = default,
            global::ElevenLabs.SMBWidgetAppearance? widget = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}