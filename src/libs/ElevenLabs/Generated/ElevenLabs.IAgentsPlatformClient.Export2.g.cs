#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Export Outbound Campaign Calls<br/>
        /// Download every call of a campaign, with its lead and conversation results, as CSV.
        /// </summary>
        /// <param name="campaignId"></param>
        /// <param name="limit">
        /// Only export the first N calls; used to preview the columns. Omit to export every call.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> Export2Async(
            string campaignId,
            int? limit = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Export Outbound Campaign Calls<br/>
        /// Download every call of a campaign, with its lead and conversation results, as CSV.
        /// </summary>
        /// <param name="campaignId"></param>
        /// <param name="limit">
        /// Only export the first N calls; used to preview the columns. Omit to export every call.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> Export2AsStreamAsync(
            string campaignId,
            int? limit = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Export Outbound Campaign Calls<br/>
        /// Download every call of a campaign, with its lead and conversation results, as CSV.
        /// </summary>
        /// <param name="campaignId"></param>
        /// <param name="limit">
        /// Only export the first N calls; used to preview the columns. Omit to export every call.
        /// </param>
        /// <returns>The response metadata and an unbuffered body stream. The caller must dispose Body to release the HTTP response.</returns>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::System.IO.Stream>> Export2AsStreamAsResponseAsync(
            string campaignId,
            int? limit = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Export Outbound Campaign Calls<br/>
        /// Download every call of a campaign, with its lead and conversation results, as CSV.
        /// </summary>
        /// <param name="campaignId"></param>
        /// <param name="limit">
        /// Only export the first N calls; used to preview the columns. Omit to export every call.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<byte[]>> Export2AsResponseAsync(
            string campaignId,
            int? limit = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}