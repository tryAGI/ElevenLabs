#nullable enable

namespace ElevenLabs
{
    public partial interface ISmbClient
    {
        /// <summary>
        /// Update Business Profile<br/>
        /// Update the business profile. Every receptionist is updated to match.
        /// </summary>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.SMBAgentInfoResponse> Update12Async(

            global::ElevenLabs.SMBUpdateAgentInfoRequest request,
            string? xiWorkspaceId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Business Profile<br/>
        /// Update the business profile. Every receptionist is updated to match.
        /// </summary>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.SMBAgentInfoResponse>> Update12AsResponseAsync(

            global::ElevenLabs.SMBUpdateAgentInfoRequest request,
            string? xiWorkspaceId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Business Profile<br/>
        /// Update the business profile. Every receptionist is updated to match.
        /// </summary>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="businessName">
        /// Name of the business.
        /// </param>
        /// <param name="businessCountry">
        /// ISO 3166-1 alpha-2 country code where the business is based (e.g. 'US', 'PL', 'DE').
        /// </param>
        /// <param name="businessDescription">
        /// What the business does, given to the receptionist.
        /// </param>
        /// <param name="timezone"></param>
        /// <param name="currency">
        /// Currency code for all prices (ISO 4217)<br/>
        /// Default Value: USD
        /// </param>
        /// <param name="operatingHours"></param>
        /// <param name="toolCallSound">
        /// Ambient sound played while any receptionist runs a tool (e.g. checking availability or looking up a client), filling the silence callers would otherwise hear. One sound for the whole workspace, because custom webhook and MCP tools are shared by every receptionist. Off when null.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.SMBAgentInfoResponse> Update12Async(
            string? xiWorkspaceId = default,
            string? businessName = default,
            string? businessCountry = default,
            string? businessDescription = default,
            string? timezone = default,
            global::ElevenLabs.SMBUpdateAgentInfoRequestCurrency? currency = default,
            global::ElevenLabs.WorkingHours? operatingHours = default,
            global::ElevenLabs.ToolCallSoundType? toolCallSound = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}