#nullable enable

namespace ElevenLabs
{
    public partial interface ISmbClient
    {
        /// <summary>
        /// Update Transfer Rule<br/>
        /// Replace an existing transfer rule on the named receptionist. Send every field: an omitted `post_dial_digits` clears it.
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
        global::System.Threading.Tasks.Task<global::ElevenLabs.SMBTransferRule> Update6Async(
            string agentId,
            string ruleId,

            global::ElevenLabs.BodySmbUpdateTransferRule request,
            string? xiWorkspaceId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Transfer Rule<br/>
        /// Replace an existing transfer rule on the named receptionist. Send every field: an omitted `post_dial_digits` clears it.
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
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.SMBTransferRule>> Update6AsResponseAsync(
            string agentId,
            string ruleId,

            global::ElevenLabs.BodySmbUpdateTransferRule request,
            string? xiWorkspaceId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Transfer Rule<br/>
        /// Replace an existing transfer rule on the named receptionist. Send every field: an omitted `post_dial_digits` clears it.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="ruleId"></param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="request">
        /// Request model for updating an existing transfer rule.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.SMBTransferRule> Update6Async(
            string agentId,
            string ruleId,
            global::ElevenLabs.SMBUpdateTransferRuleRequest request,
            string? xiWorkspaceId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}