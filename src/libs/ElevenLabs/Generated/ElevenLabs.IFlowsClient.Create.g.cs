#nullable enable

namespace ElevenLabs
{
    public partial interface IFlowsClient
    {
        /// <summary>
        /// Create Video Generation<br/>
        /// Start a video generation with the selected model.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.MediaGenerationCreateResponse> CreateAsync(

            global::ElevenLabs.VideoGenerationRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Video Generation<br/>
        /// Start a video generation with the selected model.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.MediaGenerationCreateResponse>> CreateAsResponseAsync(

            global::ElevenLabs.VideoGenerationRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}