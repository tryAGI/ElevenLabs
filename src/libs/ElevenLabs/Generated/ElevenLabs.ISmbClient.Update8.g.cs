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
        global::System.Threading.Tasks.Task<global::ElevenLabs.SMBTransferRule> Update8Async(
            string agentId,
            string ruleId,

            global::ElevenLabs.SMBUpdateTransferRuleRequest request,
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
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.SMBTransferRule>> Update8AsResponseAsync(
            string agentId,
            string ruleId,

            global::ElevenLabs.SMBUpdateTransferRuleRequest request,
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
        /// <param name="label">
        /// Name of the transfer destination, e.g. 'Alvin' or 'Billing team'.
        /// </param>
        /// <param name="phoneNumber">
        /// Number to transfer to. Without a country code it is dialed locally in the business's country, so include the country code for a number abroad.
        /// </param>
        /// <param name="condition">
        /// What the caller does that triggers the transfer, e.g. 'The caller asks to speak to a human or to Alvin'. Describe only the trigger; do not restate the phone number or the word 'transfer'.
        /// </param>
        /// <param name="postDialDigits">
        /// DTMF digits automatically played after the transfer destination picks up (e.g. '1' to answer a 'press 1 to accept' screen, or 'www1234' to key an extension after a pause). Valid characters are 0-9, *, #, w (0.5s pause) and W (1s pause). Twilio transfers only.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.SMBTransferRule> Update8Async(
            string agentId,
            string ruleId,
            string label,
            string phoneNumber,
            string condition,
            string? xiWorkspaceId = default,
            string? postDialDigits = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}