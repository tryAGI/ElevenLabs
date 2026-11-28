#nullable enable

namespace ElevenLabs
{
    public partial interface ISmbClient
    {
        /// <summary>
        /// Create Reseller Workspace<br/>
        /// Create a workspace for one of your customers, optionally with a tier, a phone number and team invites.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ProvisionResellerWorkspaceResponse> Create11Async(

            global::ElevenLabs.ReceptionProvisionResellerWorkspaceRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Reseller Workspace<br/>
        /// Create a workspace for one of your customers, optionally with a tier, a phone number and team invites.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.ProvisionResellerWorkspaceResponse>> Create11AsResponseAsync(

            global::ElevenLabs.ReceptionProvisionResellerWorkspaceRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Reseller Workspace<br/>
        /// Create a workspace for one of your customers, optionally with a tier, a phone number and team invites.
        /// </summary>
        /// <param name="businessName"></param>
        /// <param name="vertical">
        /// The business's vertical, used with `complete_onboarding`. Without it, onboarding picks the vertical as usual.
        /// </param>
        /// <param name="chargeCustomer">
        /// Bill the workspace's own customer instead of the reseller: it checks out and sees its billing itself, and the reseller earns a commission. Only for a reseller on standard billing.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="subscription">
        /// Paid tier to subscribe to. Omitted leaves the workspace with no subscription.
        /// </param>
        /// <param name="phoneNumber">
        /// A free number from the reseller's phone pool, reserved for the workspace until onboarding binds it to the receptionist.
        /// </param>
        /// <param name="members">
        /// People to invite once the workspace exists, capped by the tier's team size. Best-effort: each outcome is in `member_results`.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="completeOnboarding">
        /// Finish setup right away, as `POST /v1/reception/reseller/workspaces/{workspace_id}/complete-onboarding` does. Best-effort: `onboarding_completed_at_unix` stays null on failure, and that call can be retried.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="metadata">
        /// Your own key-value pairs for the workspace, such as your customer or contract id. Up to 20 keys of up to 40 characters, without `.` or `$`, and values of up to 500 characters. Not shown to the workspace's members.<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="idempotencyKey">
        /// Client-generated key that makes a retry safe. The same key and body within 24 hours returns the first result without running again. While that first request is still running, a retry gets 409 `idempotency_key_in_progress`; a different body with the same key gets 400 `idempotency_key_reused`. A request that fails is not saved, so it can be retried with the same key.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ProvisionResellerWorkspaceResponse> Create11Async(
            string businessName,
            global::ElevenLabs.ReceptionVertical? vertical = default,
            bool? chargeCustomer = default,
            global::ElevenLabs.ProvisionResellerWorkspaceSubscription? subscription = default,
            string? phoneNumber = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.TeamInviteRequest>? members = default,
            bool? completeOnboarding = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            string? idempotencyKey = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}