#nullable enable

namespace ElevenLabs
{
    public partial interface IAudioIsolationClient
    {
        /// <summary>
        /// Get Audio Isolation History<br/>
        /// Returns a list of all your audio isolation generations.
        /// </summary>
        /// <param name="pageSize">
        /// How many history items to return at maximum. Defaults to 100.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="page">
        /// Page number for search pagination (1-based). Only used when search is provided.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="search">
        /// Optional search term used for filtering audio isolation history (title/text).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetAudioIsolationHistoryResponseModel> ListAsync(
            int? pageSize = default,
            int? page = default,
            string? search = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}