#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Create An Outbound Campaign<br/>
        /// Create an outbound campaign that calls or messages each recipient with the agent, within the policy's calling windows, retrying and following up as it allows. Returns `201` for a new campaign. A repeated request, matched by `idempotency_key` or else by its body, returns the existing campaign with `created` false.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.SubmitCampaignResponse> Create21Async(

            global::ElevenLabs.SubmitCampaignRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create An Outbound Campaign<br/>
        /// Create an outbound campaign that calls or messages each recipient with the agent, within the policy's calling windows, retrying and following up as it allows. Returns `201` for a new campaign. A repeated request, matched by `idempotency_key` or else by its body, returns the existing campaign with `created` false.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.SubmitCampaignResponse>> Create21AsResponseAsync(

            global::ElevenLabs.SubmitCampaignRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create An Outbound Campaign<br/>
        /// Create an outbound campaign that calls or messages each recipient with the agent, within the policy's calling windows, retrying and following up as it allows. Returns `201` for a new campaign. A repeated request, matched by `idempotency_key` or else by its body, returns the existing campaign with `created` false.
        /// </summary>
        /// <param name="callName">
        /// The campaign's name.
        /// </param>
        /// <param name="agentId">
        /// The agent that places the calls.
        /// </param>
        /// <param name="recipients">
        /// Who to call. Each recipient becomes a lead of the campaign.
        /// </param>
        /// <param name="scheduledTimeUnix">
        /// When to start calling; omit to start now. Calls still wait for the next calling window.
        /// </param>
        /// <param name="timezone">
        /// IANA timezone to read the calling windows in, overriding the policy's.
        /// </param>
        /// <param name="branchId">
        /// The agent branch to call with.
        /// </param>
        /// <param name="environment">
        /// The environment to resolve the agent's environment variables in.
        /// </param>
        /// <param name="targetConcurrencyLimit">
        /// The most calls to place at once.
        /// </param>
        /// <param name="idempotencyKey">
        /// Makes the request safe to retry: a repeat with the same key returns the campaign it created.
        /// </param>
        /// <param name="policy">
        /// Policy to snapshot onto the campaign. When set, it wins over the workspace default and any per-agent override; when omitted, the workspace configuration must exist and supplies the policy.
        /// </param>
        /// <param name="variant">
        /// `simple` runs one attempt per recipient with always-on calling windows and nothing collected, and cannot be combined with `policy`. `advanced` uses `policy` or the workspace configuration, and is the default for phone campaigns.
        /// </param>
        /// <param name="channelConfig"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.SubmitCampaignResponse> Create21Async(
            string callName,
            string agentId,
            global::System.Collections.Generic.IList<global::ElevenLabs.SubmitCampaignRecipient> recipients,
            global::ElevenLabs.ChannelConfig2 channelConfig,
            int? scheduledTimeUnix = default,
            string? timezone = default,
            string? branchId = default,
            string? environment = default,
            int? targetConcurrencyLimit = default,
            string? idempotencyKey = default,
            global::ElevenLabs.PolicyConfigInput? policy = default,
            global::ElevenLabs.CampaignVariant? variant = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}