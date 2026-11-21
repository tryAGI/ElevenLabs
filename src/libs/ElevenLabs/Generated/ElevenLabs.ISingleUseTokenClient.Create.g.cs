#nullable enable

namespace ElevenLabs
{
    public partial interface ISingleUseTokenClient
    {
        /// <summary>
        /// Create Single Use Token<br/>
        /// Generate a time limited single-use token with embedded authentication for frontend clients.
        /// </summary>
        /// <param name="tokenType"></param>
        /// <param name="maxSessionDurationSeconds">
        /// Closes the realtime transcription session opened with this token after this many seconds. Only for realtime_scribe tokens.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.SingleUseTokenResponseModel> CreateAsync(
            global::ElevenLabs.SingleUseTokenType tokenType,
            int? maxSessionDurationSeconds = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Single Use Token<br/>
        /// Generate a time limited single-use token with embedded authentication for frontend clients.
        /// </summary>
        /// <param name="tokenType"></param>
        /// <param name="maxSessionDurationSeconds">
        /// Closes the realtime transcription session opened with this token after this many seconds. Only for realtime_scribe tokens.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.SingleUseTokenResponseModel>> CreateAsResponseAsync(
            global::ElevenLabs.SingleUseTokenType tokenType,
            int? maxSessionDurationSeconds = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}