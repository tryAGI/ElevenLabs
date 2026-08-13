#nullable enable

namespace ElevenLabs
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Get Voice Accents<br/>
        /// Gets the list of available accents in the shared voice library.
        /// </summary>
        /// <param name="language">
        /// If provided, only accents for this language code are returned.
        /// </param>
        /// <param name="modelId">
        /// If provided, returns the accents available for this model. Defaults to the most complete accent list when omitted.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetVoiceAccentsResponseModel> Get2Async(
            string? language = default,
            string? modelId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Voice Accents<br/>
        /// Gets the list of available accents in the shared voice library.
        /// </summary>
        /// <param name="language">
        /// If provided, only accents for this language code are returned.
        /// </param>
        /// <param name="modelId">
        /// If provided, returns the accents available for this model. Defaults to the most complete accent list when omitted.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.GetVoiceAccentsResponseModel>> Get2AsResponseAsync(
            string? language = default,
            string? modelId = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}