#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Add Leads To An Outbound Campaign<br/>
        /// Add recipients to an outbound campaign that isn't stopping, stopped or failed. Recipients whose `id` the campaign already has are skipped, and a `completed` campaign becomes `active` again.
        /// </summary>
        /// <param name="campaignId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AddLeadsResponse> Create22Async(
            string campaignId,

            global::ElevenLabs.AddLeadsRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Leads To An Outbound Campaign<br/>
        /// Add recipients to an outbound campaign that isn't stopping, stopped or failed. Recipients whose `id` the campaign already has are skipped, and a `completed` campaign becomes `active` again.
        /// </summary>
        /// <param name="campaignId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.AddLeadsResponse>> Create22AsResponseAsync(
            string campaignId,

            global::ElevenLabs.AddLeadsRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Leads To An Outbound Campaign<br/>
        /// Add recipients to an outbound campaign that isn't stopping, stopped or failed. Recipients whose `id` the campaign already has are skipped, and a `completed` campaign becomes `active` again.
        /// </summary>
        /// <param name="campaignId"></param>
        /// <param name="recipients">
        /// Who to add. A recipient whose `id` the campaign already has is skipped, so retrying a request with ids is safe. Recipients without an `id` are always added.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AddLeadsResponse> Create22Async(
            string campaignId,
            global::System.Collections.Generic.IList<global::ElevenLabs.SubmitCampaignRecipient> recipients,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}