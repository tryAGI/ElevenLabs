#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Resolve An Outbound Campaign Attention Item<br/>
        /// Close an attention item that can't be retried, recording how it was handled.
        /// </summary>
        /// <param name="attentionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AttentionView> Resolve2Async(
            string attentionId,

            global::ElevenLabs.AttentionResolutionRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Resolve An Outbound Campaign Attention Item<br/>
        /// Close an attention item that can't be retried, recording how it was handled.
        /// </summary>
        /// <param name="attentionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.AttentionView>> Resolve2AsResponseAsync(
            string attentionId,

            global::ElevenLabs.AttentionResolutionRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Resolve An Outbound Campaign Attention Item<br/>
        /// Close an attention item that can't be retried, recording how it was handled.
        /// </summary>
        /// <param name="attentionId"></param>
        /// <param name="resolution">
        /// How the item was handled.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AttentionView> Resolve2Async(
            string attentionId,
            string resolution,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}