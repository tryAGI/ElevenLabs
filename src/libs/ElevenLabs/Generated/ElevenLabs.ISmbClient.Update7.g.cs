#nullable enable

namespace ElevenLabs
{
    public partial interface ISmbClient
    {
        /// <summary>
        /// Reassign Phone To Agent<br/>
        /// Move a phone number to a different receptionist in the same workspace, which answers its calls from then on. Returns 409 `phone_number_not_attached` for a number no receptionist answers yet (attach it with `POST /v1/smb/phone-numbers/assignments`), and 403 `telephony_managed_by_reseller` when the reseller supplies the workspace's numbers from its own Twilio account.
        /// </summary>
        /// <param name="phoneAssignmentId"></param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.SMBPhoneAssignmentDBModel> Update7Async(
            string phoneAssignmentId,

            global::ElevenLabs.ReassignPhoneRequest request,
            string? xiWorkspaceId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reassign Phone To Agent<br/>
        /// Move a phone number to a different receptionist in the same workspace, which answers its calls from then on. Returns 409 `phone_number_not_attached` for a number no receptionist answers yet (attach it with `POST /v1/smb/phone-numbers/assignments`), and 403 `telephony_managed_by_reseller` when the reseller supplies the workspace's numbers from its own Twilio account.
        /// </summary>
        /// <param name="phoneAssignmentId"></param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.SMBPhoneAssignmentDBModel>> Update7AsResponseAsync(
            string phoneAssignmentId,

            global::ElevenLabs.ReassignPhoneRequest request,
            string? xiWorkspaceId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reassign Phone To Agent<br/>
        /// Move a phone number to a different receptionist in the same workspace, which answers its calls from then on. Returns 409 `phone_number_not_attached` for a number no receptionist answers yet (attach it with `POST /v1/smb/phone-numbers/assignments`), and 403 `telephony_managed_by_reseller` when the reseller supplies the workspace's numbers from its own Twilio account.
        /// </summary>
        /// <param name="phoneAssignmentId"></param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="customerFacingAgentId">
        /// The receptionist that answers calls to the number from now on.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.SMBPhoneAssignmentDBModel> Update7Async(
            string phoneAssignmentId,
            string customerFacingAgentId,
            string? xiWorkspaceId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}