#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// List Outbound Campaign Leads<br/>
        /// List the leads of an outbound campaign, one per recipient.
        /// </summary>
        /// <param name="campaignId"></param>
        /// <param name="pageSize">
        /// How many items to return at most.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="search">
        /// Only leads whose ID, user ID or phone number contains this text.
        /// </param>
        /// <param name="status">
        /// `in_progress` for leads still being called, `finished` for leads that won't be called again.
        /// </param>
        /// <param name="disposition">
        /// Only leads that finished in one of these ways.
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.CampaignLeadsResponse> List20Async(
            string campaignId,
            int? pageSize = default,
            string? search = default,
            global::ElevenLabs.ListCampaignLeadsStatus? status = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.TerminalDisposition>? disposition = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Outbound Campaign Leads<br/>
        /// List the leads of an outbound campaign, one per recipient.
        /// </summary>
        /// <param name="campaignId"></param>
        /// <param name="pageSize">
        /// How many items to return at most.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="search">
        /// Only leads whose ID, user ID or phone number contains this text.
        /// </param>
        /// <param name="status">
        /// `in_progress` for leads still being called, `finished` for leads that won't be called again.
        /// </param>
        /// <param name="disposition">
        /// Only leads that finished in one of these ways.
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.CampaignLeadsResponse>> List20AsResponseAsync(
            string campaignId,
            int? pageSize = default,
            string? search = default,
            global::ElevenLabs.ListCampaignLeadsStatus? status = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.TerminalDisposition>? disposition = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps List20Async as an IAsyncEnumerable&lt;global::ElevenLabs.LeadView&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="campaignId"></param>
        /// <param name="pageSize">
        /// How many items to return at most.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="search">
        /// Only leads whose ID, user ID or phone number contains this text.
        /// </param>
        /// <param name="status">
        /// `in_progress` for leads still being called, `finished` for leads that won't be called again.
        /// </param>
        /// <param name="disposition">
        /// Only leads that finished in one of these ways.
        /// </param>
        /// <param name="cursor">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::ElevenLabs.LeadView> List20AutoPagingAsync(
            string campaignId,             int? pageSize = default,
            string? search = default,
            global::ElevenLabs.ListCampaignLeadsStatus? status = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.TerminalDisposition>? disposition = default,
            string? cursor = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}