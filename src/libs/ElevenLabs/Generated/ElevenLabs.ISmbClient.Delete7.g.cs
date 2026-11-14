#nullable enable

namespace ElevenLabs
{
    public partial interface ISmbClient
    {
        /// <summary>
        /// Delete Transfer Rule<br/>
        /// Delete a transfer rule from the named receptionist.
        /// </summary>
        /// <param name="agentId">
        /// ID of the receptionist. List them with `GET /v1/reception/customer-facing-agents`.
        /// </param>
        /// <param name="ruleId">
        /// ID of the transfer rule. Returned when you add one, and listed in the receptionist's `config.transfer_rules`.
        /// </param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, string>> Delete7Async(
            string agentId,
            string ruleId,
            string xiWorkspaceId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Transfer Rule<br/>
        /// Delete a transfer rule from the named receptionist.
        /// </summary>
        /// <param name="agentId">
        /// ID of the receptionist. List them with `GET /v1/reception/customer-facing-agents`.
        /// </param>
        /// <param name="ruleId">
        /// ID of the transfer rule. Returned when you add one, and listed in the receptionist's `config.transfer_rules`.
        /// </param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::System.Collections.Generic.Dictionary<string, string>>> Delete7AsResponseAsync(
            string agentId,
            string ruleId,
            string xiWorkspaceId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}