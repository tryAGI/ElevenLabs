#nullable enable

namespace ElevenLabs
{
    public partial interface ISmbClient
    {
        /// <summary>
        /// Assign Reseller Tier<br/>
        /// Subscribe a reseller-attributed workspace to one of the reseller's tiers
        /// </summary>
        /// <param name="workspaceId">
        /// ID of the customer workspace. Returned when you provision one; list them with `GET /v1/reception/reseller/workspaces`.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, string>> AssignAsync(
            string workspaceId,

            global::ElevenLabs.AssignResellerTierRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Assign Reseller Tier<br/>
        /// Subscribe a reseller-attributed workspace to one of the reseller's tiers
        /// </summary>
        /// <param name="workspaceId">
        /// ID of the customer workspace. Returned when you provision one; list them with `GET /v1/reception/reseller/workspaces`.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::System.Collections.Generic.Dictionary<string, string>>> AssignAsResponseAsync(
            string workspaceId,

            global::ElevenLabs.AssignResellerTierRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Assign Reseller Tier<br/>
        /// Subscribe a reseller-attributed workspace to one of the reseller's tiers
        /// </summary>
        /// <param name="workspaceId">
        /// ID of the customer workspace. Returned when you provision one; list them with `GET /v1/reception/reseller/workspaces`.
        /// </param>
        /// <param name="tierId"></param>
        /// <param name="billingPeriod">
        /// Default Value: monthly_period
        /// </param>
        /// <param name="idempotencyKey">
        /// Client-generated key that makes a retry safe. The same key and body within 24 hours returns the first result without running again. While that first request is still running, a retry gets 409 `idempotency_key_in_progress`; a different body with the same key gets 400 `idempotency_key_reused`. A request that fails is not saved, so it can be retried with the same key.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, string>> AssignAsync(
            string workspaceId,
            string tierId,
            global::ElevenLabs.AssignResellerTierRequestBillingPeriod? billingPeriod = default,
            string? idempotencyKey = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}