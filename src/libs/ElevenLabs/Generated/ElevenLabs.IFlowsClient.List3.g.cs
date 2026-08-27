#nullable enable

namespace ElevenLabs
{
    public partial interface IFlowsClient
    {
        /// <summary>
        /// List Speech Generations<br/>
        /// List the speech generations created through this API, newest first.
        /// </summary>
        /// <param name="cursor">
        /// Pagination cursor: the `next_cursor` value of the previous page's response. Omit it for the first page.
        /// </param>
        /// <param name="pageSize">
        /// How many generations to return per page.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="status">
        /// Only return generations with this lifecycle status.
        /// </param>
        /// <param name="modelId">
        /// Only return generations of this model.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.MediaGenerationListResponse> List3Async(
            string? cursor = default,
            int? pageSize = default,
            global::ElevenLabs.ListTextToSpeechGenerationsStatus2? status = default,
            string? modelId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Speech Generations<br/>
        /// List the speech generations created through this API, newest first.
        /// </summary>
        /// <param name="cursor">
        /// Pagination cursor: the `next_cursor` value of the previous page's response. Omit it for the first page.
        /// </param>
        /// <param name="pageSize">
        /// How many generations to return per page.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="status">
        /// Only return generations with this lifecycle status.
        /// </param>
        /// <param name="modelId">
        /// Only return generations of this model.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.MediaGenerationListResponse>> List3AsResponseAsync(
            string? cursor = default,
            int? pageSize = default,
            global::ElevenLabs.ListTextToSpeechGenerationsStatus2? status = default,
            string? modelId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps List3Async as an IAsyncEnumerable&lt;global::ElevenLabs.MediaGenerationResponse&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="pageSize">
        /// How many generations to return per page.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="status">
        /// Only return generations with this lifecycle status.
        /// </param>
        /// <param name="modelId">
        /// Only return generations of this model.
        /// </param>
        /// <param name="cursor">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::ElevenLabs.MediaGenerationResponse> List3AutoPagingAsync(
              int? pageSize = default,
            global::ElevenLabs.ListTextToSpeechGenerationsStatus2? status = default,
            string? modelId = default,
            string? cursor = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}