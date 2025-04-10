#nullable enable

namespace ElevenLabs
{
    public partial interface IDubbingClient
    {
        /// <summary>
        /// Get Dubbed File<br/>
        /// Returns dubbed file as a streamed file. Videos will be returned in MP4 format and audio only dubs will be returned in MP3.
        /// </summary>
        /// <param name="dubbingId">
        /// ID of the dubbing project.
        /// </param>
        /// <param name="languageCode">
        /// ID of the language.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> GetDubbingByDubbingIdAudioByLanguageCodeAsync(
            string dubbingId,
            string languageCode,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}