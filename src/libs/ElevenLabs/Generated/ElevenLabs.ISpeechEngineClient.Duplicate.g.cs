#nullable enable

namespace ElevenLabs
{
    public partial interface ISpeechEngineClient
    {
        /// <summary>
        /// Duplicate Speech Engine<br/>
        /// Create a new Speech Engine resource by duplicating an existing one
        /// </summary>
        /// <param name="speechEngineId">
        /// The speech engine ID (accepts seng_ or agent_ prefix)
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.SpeechEngineResponse> DuplicateAsync(
            string speechEngineId,

            global::ElevenLabs.DuplicateSpeechEngineRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Duplicate Speech Engine<br/>
        /// Create a new Speech Engine resource by duplicating an existing one
        /// </summary>
        /// <param name="speechEngineId">
        /// The speech engine ID (accepts seng_ or agent_ prefix)
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.SpeechEngineResponse>> DuplicateAsResponseAsync(
            string speechEngineId,

            global::ElevenLabs.DuplicateSpeechEngineRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Duplicate Speech Engine<br/>
        /// Create a new Speech Engine resource by duplicating an existing one
        /// </summary>
        /// <param name="speechEngineId">
        /// The speech engine ID (accepts seng_ or agent_ prefix)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.SpeechEngineResponse> DuplicateAsync(
            string speechEngineId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}