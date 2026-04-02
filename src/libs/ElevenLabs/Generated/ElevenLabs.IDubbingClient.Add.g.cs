#nullable enable

namespace ElevenLabs
{
    public partial interface IDubbingClient
    {
        /// <summary>
        /// Add A Language To The Resource<br/>
        /// Adds the given ElevenLab Turbo V2/V2.5 language code to the resource. Does not automatically generate transcripts/translations/audio.
        /// </summary>
        /// <param name="dubbingId">
        /// ID of the dubbing project.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.LanguageAddedResponse> AddAsync(
            string dubbingId,

            global::ElevenLabs.BodyAddALanguageToTheResourceV1DubbingResourceDubbingIdLanguagePost request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add A Language To The Resource<br/>
        /// Adds the given ElevenLab Turbo V2/V2.5 language code to the resource. Does not automatically generate transcripts/translations/audio.
        /// </summary>
        /// <param name="dubbingId">
        /// ID of the dubbing project.
        /// </param>
        /// <param name="language">
        /// The Target language.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.LanguageAddedResponse> AddAsync(
            string dubbingId,
            string? language = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}