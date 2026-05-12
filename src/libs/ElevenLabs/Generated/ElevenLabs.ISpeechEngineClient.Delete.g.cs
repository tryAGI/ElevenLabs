#nullable enable

namespace ElevenLabs
{
    public partial interface ISpeechEngineClient
    {
        /// <summary>
        /// Delete Speech Engine<br/>
        /// Delete a Speech Engine resource
        /// </summary>
        /// <param name="speechEngineId">
        /// The speech engine ID (accepts seng_ or agent_ prefix)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAsync(
            string speechEngineId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Speech Engine<br/>
        /// Delete a Speech Engine resource
        /// </summary>
        /// <param name="speechEngineId">
        /// The speech engine ID (accepts seng_ or agent_ prefix)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse> DeleteAsResponseAsync(
            string speechEngineId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}