#nullable enable

namespace ElevenLabs
{
    public partial interface ISmbClient
    {
        /// <summary>
        /// Assign Reseller Tier<br/>
        /// Subscribe a reseller-attributed workspace to one of the reseller's tiers
        /// </summary>
        /// <param name="workspaceId"></param>
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
        /// <param name="workspaceId"></param>
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
        /// <param name="workspaceId"></param>
        /// <param name="tierId"></param>
        /// <param name="billingPeriod">
        /// Default Value: monthly_period
        /// </param>
        /// <param name="idempotencyKey">
        /// Client-generated key so a retried request cannot create or apply the same subscription change twice.
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