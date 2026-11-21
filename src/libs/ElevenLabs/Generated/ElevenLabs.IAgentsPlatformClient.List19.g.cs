#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// List Outbound Campaigns<br/>
        /// List the workspace's outbound campaigns, newest first.
        /// </summary>
        /// <param name="pageSize">
        /// How many items to return at most.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="status">
        /// Only campaigns in one of these statuses.
        /// </param>
        /// <param name="agentId">
        /// Only campaigns run by this agent.
        /// </param>
        /// <param name="channel">
        /// Only campaigns on this channel.
        /// </param>
        /// <param name="mode">
        /// Only voice or only message campaigns.
        /// </param>
        /// <param name="search">
        /// Only campaigns whose name contains this text.
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.CampaignPageResponse> List19Async(
            int? pageSize = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.CampaignStatus>? status = default,
            string? agentId = default,
            global::ElevenLabs.OutboundChannel? channel = default,
            global::ElevenLabs.ListCampaignsMode? mode = default,
            string? search = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Outbound Campaigns<br/>
        /// List the workspace's outbound campaigns, newest first.
        /// </summary>
        /// <param name="pageSize">
        /// How many items to return at most.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="status">
        /// Only campaigns in one of these statuses.
        /// </param>
        /// <param name="agentId">
        /// Only campaigns run by this agent.
        /// </param>
        /// <param name="channel">
        /// Only campaigns on this channel.
        /// </param>
        /// <param name="mode">
        /// Only voice or only message campaigns.
        /// </param>
        /// <param name="search">
        /// Only campaigns whose name contains this text.
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.CampaignPageResponse>> List19AsResponseAsync(
            int? pageSize = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.CampaignStatus>? status = default,
            string? agentId = default,
            global::ElevenLabs.OutboundChannel? channel = default,
            global::ElevenLabs.ListCampaignsMode? mode = default,
            string? search = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps List19Async as an IAsyncEnumerable&lt;global::ElevenLabs.CampaignResponse&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="pageSize">
        /// How many items to return at most.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="status">
        /// Only campaigns in one of these statuses.
        /// </param>
        /// <param name="agentId">
        /// Only campaigns run by this agent.
        /// </param>
        /// <param name="channel">
        /// Only campaigns on this channel.
        /// </param>
        /// <param name="mode">
        /// Only voice or only message campaigns.
        /// </param>
        /// <param name="search">
        /// Only campaigns whose name contains this text.
        /// </param>
        /// <param name="cursor">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::ElevenLabs.CampaignResponse> List19AutoPagingAsync(
              int? pageSize = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.CampaignStatus>? status = default,
            string? agentId = default,
            global::ElevenLabs.OutboundChannel? channel = default,
            global::ElevenLabs.ListCampaignsMode? mode = default,
            string? search = default,
            string? cursor = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}