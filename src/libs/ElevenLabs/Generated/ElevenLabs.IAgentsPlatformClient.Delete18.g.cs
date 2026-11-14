#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Remove An Outbound Campaign Lead<br/>
        /// Remove a lead from an outbound campaign so it is never called again. Returns `202` when a call already placed may still go through.
        /// </summary>
        /// <param name="campaignId"></param>
        /// <param name="leadId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.SuppressLeadResponse> Delete18Async(
            string campaignId,
            string leadId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove An Outbound Campaign Lead<br/>
        /// Remove a lead from an outbound campaign so it is never called again. Returns `202` when a call already placed may still go through.
        /// </summary>
        /// <param name="campaignId"></param>
        /// <param name="leadId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.SuppressLeadResponse>> Delete18AsResponseAsync(
            string campaignId,
            string leadId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}