#nullable enable

namespace ElevenLabs
{
    public partial interface ISmbClient
    {
        /// <summary>
        /// Update Receptionist<br/>
        /// Update a receptionist's display name, config and/or widget appearance.
        /// </summary>
        /// <param name="agentId">
        /// ID of the receptionist. List them with `GET /v1/reception/customer-facing-agents`.
        /// </param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ReceptionCustomerFacingAgentResponse> Update5Async(
            string agentId,
            string xiWorkspaceId,

            global::ElevenLabs.ReceptionUpdateCustomerFacingAgentRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Receptionist<br/>
        /// Update a receptionist's display name, config and/or widget appearance.
        /// </summary>
        /// <param name="agentId">
        /// ID of the receptionist. List them with `GET /v1/reception/customer-facing-agents`.
        /// </param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.ReceptionCustomerFacingAgentResponse>> Update5AsResponseAsync(
            string agentId,
            string xiWorkspaceId,

            global::ElevenLabs.ReceptionUpdateCustomerFacingAgentRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Receptionist<br/>
        /// Update a receptionist's display name, config and/or widget appearance.
        /// </summary>
        /// <param name="agentId">
        /// ID of the receptionist. List them with `GET /v1/reception/customer-facing-agents`.
        /// </param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="config">
        /// Receptionist settings to change; omitted settings keep their value.
        /// </param>
        /// <param name="name">
        /// New display name for the receptionist.
        /// </param>
        /// <param name="widget">
        /// New website widget appearance.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ReceptionCustomerFacingAgentResponse> Update5Async(
            string agentId,
            string xiWorkspaceId,
            global::ElevenLabs.ReceptionCustomerFacingConfigPatch? config = default,
            string? name = default,
            global::ElevenLabs.ReceptionWidgetAppearance? widget = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}