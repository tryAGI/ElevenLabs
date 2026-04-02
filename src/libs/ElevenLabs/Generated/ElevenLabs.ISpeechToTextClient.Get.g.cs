#nullable enable

namespace ElevenLabs
{
    public partial interface ISpeechToTextClient
    {
        /// <summary>
        /// Get Transcript By Id<br/>
        /// Retrieve a previously generated transcript by its ID.
        /// </summary>
        /// <param name="transcriptionId">
        /// The unique ID of the transcript to retrieve
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AnyOf<global::ElevenLabs.SpeechToTextChunkResponseModel, global::ElevenLabs.MultichannelSpeechToTextResponseModel>> GetAsync(
            string transcriptionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}