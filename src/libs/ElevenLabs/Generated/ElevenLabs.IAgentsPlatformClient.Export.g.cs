#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Export Batch Call Results<br/>
        /// Download all recipients and conversation results for a terminal batch call as CSV.
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="limit">
        /// Only export the first N recipients; used to preview the columns. Omit to export every recipient.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> ExportAsync(
            string batchId,
            int? limit = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Export Batch Call Results<br/>
        /// Download all recipients and conversation results for a terminal batch call as CSV.
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="limit">
        /// Only export the first N recipients; used to preview the columns. Omit to export every recipient.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> ExportAsStreamAsync(
            string batchId,
            int? limit = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Export Batch Call Results<br/>
        /// Download all recipients and conversation results for a terminal batch call as CSV.
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="limit">
        /// Only export the first N recipients; used to preview the columns. Omit to export every recipient.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<byte[]>> ExportAsResponseAsync(
            string batchId,
            int? limit = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}