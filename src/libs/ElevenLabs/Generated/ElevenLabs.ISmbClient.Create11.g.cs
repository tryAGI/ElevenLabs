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

            global::ElevenLabs.ProvisionResellerWorkspaceRequest request,
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

            global::ElevenLabs.ProvisionResellerWorkspaceRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Reseller Workspace<br/>
        /// Create a workspace for one of your customers, optionally with a tier, a phone number and team invites.
        /// </summary>
        /// <param name="businessName"></param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ProvisionResellerWorkspaceResponse> Create11Async(
            string businessName,
            global::ElevenLabs.ProvisionResellerWorkspaceSubscription? subscription = default,
            string? phoneNumber = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.TeamInviteRequest>? members = default,
            bool? completeOnboarding = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}