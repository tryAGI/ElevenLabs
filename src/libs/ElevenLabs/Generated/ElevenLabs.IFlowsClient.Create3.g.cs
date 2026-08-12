#nullable enable

namespace ElevenLabs
{
    public partial interface IFlowsClient
    {
        /// <summary>
        /// Create Speech Generation<br/>
        /// Start a speech generation with the selected model. Charged per character via text-to-speech billing. Use this over `/v1/text-to-speech` for the asynchronous generation lifecycle or for models not offered there; for direct, synchronous speech synthesis, prefer `/v1/text-to-speech`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.MediaGenerationCreateResponse> Create3Async(

            global::ElevenLabs.TextToSpeechGenerationRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Speech Generation<br/>
        /// Start a speech generation with the selected model. Charged per character via text-to-speech billing. Use this over `/v1/text-to-speech` for the asynchronous generation lifecycle or for models not offered there; for direct, synchronous speech synthesis, prefer `/v1/text-to-speech`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.MediaGenerationCreateResponse>> Create3AsResponseAsync(

            global::ElevenLabs.TextToSpeechGenerationRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}