#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentPlatformClient
    {
        /// <summary>
        /// Get Integration Docs<br/>
        /// Get MDX documentation for all integrations that have it. Returns docs for publicly available integrations when unauthenticated, and includes feature-flagged integrations when authenticated.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ListResponseApiIntegrationDocResponse> GetConvaiApiIntegrationsDocsAsync(
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Integration Docs<br/>
        /// Get MDX documentation for all integrations that have it. Returns docs for publicly available integrations when unauthenticated, and includes feature-flagged integrations when authenticated.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.ListResponseApiIntegrationDocResponse>> GetConvaiApiIntegrationsDocsAsResponseAsync(
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}