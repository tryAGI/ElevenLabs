#nullable enable

namespace ElevenLabs
{
    public partial interface ISpeechToTextClient
    {
        /// <summary>
        /// Delete Transcript By Id<br/>
        /// Delete a previously generated transcript by its ID.
        /// </summary>
        /// <param name="transcriptionId">
        /// The unique ID of the transcript to delete
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteAsync(
            string transcriptionId,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}