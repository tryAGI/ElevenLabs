#nullable enable

namespace ElevenLabs
{
    public partial interface IDubbingClient
    {
        /// <summary>
        /// Get Dubbed Transcript<br/>
        /// Returns transcript for the dub as an SRT or WEBVTT file.
        /// </summary>
        /// <param name="dubbingId">
        /// ID of the dubbing project.
        /// </param>
        /// <param name="languageCode">
        /// ID of the language.
        /// </param>
        /// <param name="formatType">
        /// Format to use for the subtitle file, either 'srt' or 'webvtt'<br/>
        /// Default Value: srt
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetDubbingByDubbingIdTranscriptByLanguageCodeAsync(
            string dubbingId,
            string languageCode,
            global::ElevenLabs.GetDubbedTranscriptV1DubbingDubbingIdTranscriptLanguageCodeGetFormatType? formatType = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}