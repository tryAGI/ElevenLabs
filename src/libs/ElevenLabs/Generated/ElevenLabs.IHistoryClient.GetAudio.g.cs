#nullable enable

namespace ElevenLabs
{
    public partial interface IHistoryClient
    {
        /// <summary>
        /// Get Audio From History Item<br/>
        /// Returns the audio of an history item.
        /// </summary>
        /// <param name="historyItemId">
        /// History item ID to be used, you can use GET https://api.elevenlabs.io/v1/history to receive a list of history items and their IDs.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> GetAudioAsync(
            string historyItemId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Audio From History Item<br/>
        /// Returns the audio of an history item.
        /// </summary>
        /// <param name="historyItemId">
        /// History item ID to be used, you can use GET https://api.elevenlabs.io/v1/history to receive a list of history items and their IDs.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> GetAudioAsStreamAsync(
            string historyItemId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Audio From History Item<br/>
        /// Returns the audio of an history item.
        /// </summary>
        /// <param name="historyItemId">
        /// History item ID to be used, you can use GET https://api.elevenlabs.io/v1/history to receive a list of history items and their IDs.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<byte[]>> GetAudioAsResponseAsync(
            string historyItemId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}