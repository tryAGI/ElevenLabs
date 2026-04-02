#nullable enable

namespace ElevenLabs
{
    public partial interface IDubbingClient
    {
        /// <summary>
        /// Search The Elevenlabs Library For Voices Similar To A Speaker.<br/>
        /// Fetch the top 10 similar voices to a speaker, including the voice IDs, names, descriptions, and, where possible, a sample audio recording.
        /// </summary>
        /// <param name="dubbingId">
        /// ID of the dubbing project.
        /// </param>
        /// <param name="speakerId">
        /// ID of the speaker.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.SimilarVoicesForSpeakerResponse> FindSimilarVoicesAsync(
            string dubbingId,
            string speakerId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}