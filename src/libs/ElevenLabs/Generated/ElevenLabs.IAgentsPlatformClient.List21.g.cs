#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// List Outbound Campaign Calls<br/>
        /// List the calls of an outbound campaign, newest first: first contacts, retries, callbacks and redirects, whether queued, under way or done.
        /// </summary>
        /// <param name="campaignId"></param>
        /// <param name="pageSize">
        /// How many items to return at most.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="leadId">
        /// Only this lead's calls.
        /// </param>
        /// <param name="status">
        /// Only calls in this status.
        /// </param>
        /// <param name="callResult">
        /// Only calls that ended in one of these results.
        /// </param>
        /// <param name="stage">
        /// Only messages at this delivery stage. Message campaigns only.
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.CampaignCallsResponse> List21Async(
            string campaignId,
            int? pageSize = default,
            string? leadId = default,
            global::ElevenLabs.CallStatus? status = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.CallResult>? callResult = default,
            global::ElevenLabs.ListCampaignCallsStage? stage = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Outbound Campaign Calls<br/>
        /// List the calls of an outbound campaign, newest first: first contacts, retries, callbacks and redirects, whether queued, under way or done.
        /// </summary>
        /// <param name="campaignId"></param>
        /// <param name="pageSize">
        /// How many items to return at most.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="leadId">
        /// Only this lead's calls.
        /// </param>
        /// <param name="status">
        /// Only calls in this status.
        /// </param>
        /// <param name="callResult">
        /// Only calls that ended in one of these results.
        /// </param>
        /// <param name="stage">
        /// Only messages at this delivery stage. Message campaigns only.
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.CampaignCallsResponse>> List21AsResponseAsync(
            string campaignId,
            int? pageSize = default,
            string? leadId = default,
            global::ElevenLabs.CallStatus? status = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.CallResult>? callResult = default,
            global::ElevenLabs.ListCampaignCallsStage? stage = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps List21Async as an IAsyncEnumerable&lt;global::ElevenLabs.CallView&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="campaignId"></param>
        /// <param name="pageSize">
        /// How many items to return at most.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="leadId">
        /// Only this lead's calls.
        /// </param>
        /// <param name="status">
        /// Only calls in this status.
        /// </param>
        /// <param name="callResult">
        /// Only calls that ended in one of these results.
        /// </param>
        /// <param name="stage">
        /// Only messages at this delivery stage. Message campaigns only.
        /// </param>
        /// <param name="cursor">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::ElevenLabs.CallView> List21AutoPagingAsync(
            string campaignId,             int? pageSize = default,
            string? leadId = default,
            global::ElevenLabs.CallStatus? status = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.CallResult>? callResult = default,
            global::ElevenLabs.ListCampaignCallsStage? stage = default,
            string? cursor = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}