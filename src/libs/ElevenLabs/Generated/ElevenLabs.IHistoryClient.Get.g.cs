#nullable enable

namespace ElevenLabs
{
    public partial interface IHistoryClient
    {
        /// <summary>
        /// Get History Item<br/>
        /// Retrieves a history item.
        /// </summary>
        /// <param name="historyItemId">
        /// History item ID to be used, you can use GET https://api.elevenlabs.io/v1/history to receive a list of history items and their IDs.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.SpeechHistoryItemResponseModel> GetAsync(
            string historyItemId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}