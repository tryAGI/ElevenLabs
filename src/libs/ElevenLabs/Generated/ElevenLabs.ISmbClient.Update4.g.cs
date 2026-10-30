#nullable enable

namespace ElevenLabs
{
    public partial interface ISmbClient
    {
        /// <summary>
        /// Update Agent Rule<br/>
        /// Replace an existing rule on the named receptionist. Send every field: an omitted `priority` resets to `strict`.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="ruleId"></param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AgentRule> Update4Async(
            string agentId,
            string ruleId,

            global::ElevenLabs.BodySmbUpdateAgentRule request,
            string? xiWorkspaceId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Agent Rule<br/>
        /// Replace an existing rule on the named receptionist. Send every field: an omitted `priority` resets to `strict`.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="ruleId"></param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.AgentRule>> Update4AsResponseAsync(
            string agentId,
            string ruleId,

            global::ElevenLabs.BodySmbUpdateAgentRule request,
            string? xiWorkspaceId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Agent Rule<br/>
        /// Replace an existing rule on the named receptionist. Send every field: an omitted `priority` resets to `strict`.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="ruleId"></param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="request">
        /// Request model for updating an existing agent rule.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AgentRule> Update4Async(
            string agentId,
            string ruleId,
            global::ElevenLabs.SMBUpdateAgentRuleRequest request,
            string? xiWorkspaceId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}