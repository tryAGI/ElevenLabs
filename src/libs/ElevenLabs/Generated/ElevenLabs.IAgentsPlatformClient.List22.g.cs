#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// List Outbound Campaign Attention Items<br/>
        /// List problems in the workspace's outbound campaigns that need you to act, such as an agent or phone number that can no longer be used, newest first. A campaign with an open item holds back the calls it affects.
        /// </summary>
        /// <param name="campaignId">
        /// Only this campaign's items.
        /// </param>
        /// <param name="includeResolved">
        /// Include items that are already resolved.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="pageSize">
        /// How many items to return at most.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AttentionPageResponse> List22Async(
            string? campaignId = default,
            bool? includeResolved = default,
            int? pageSize = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Outbound Campaign Attention Items<br/>
        /// List problems in the workspace's outbound campaigns that need you to act, such as an agent or phone number that can no longer be used, newest first. A campaign with an open item holds back the calls it affects.
        /// </summary>
        /// <param name="campaignId">
        /// Only this campaign's items.
        /// </param>
        /// <param name="includeResolved">
        /// Include items that are already resolved.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="pageSize">
        /// How many items to return at most.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.AttentionPageResponse>> List22AsResponseAsync(
            string? campaignId = default,
            bool? includeResolved = default,
            int? pageSize = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps List22Async as an IAsyncEnumerable&lt;global::ElevenLabs.AttentionView&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="campaignId">
        /// Only this campaign's items.
        /// </param>
        /// <param name="includeResolved">
        /// Include items that are already resolved.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="pageSize">
        /// How many items to return at most.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="cursor">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::ElevenLabs.AttentionView> List22AutoPagingAsync(
              string? campaignId = default,
            bool? includeResolved = default,
            int? pageSize = default,
            string? cursor = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}