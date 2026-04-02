#nullable enable

namespace ElevenLabs
{
    public partial interface IPronunciationDictionariesClient
    {
        /// <summary>
        /// Get A Pls File With A Pronunciation Dictionary Version Rules<br/>
        /// Get a PLS file with a pronunciation dictionary version rules
        /// </summary>
        /// <param name="dictionaryId">
        /// The id of the pronunciation dictionary
        /// </param>
        /// <param name="versionId">
        /// The id of the pronunciation dictionary version
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> DownloadAsync(
            string dictionaryId,
            string versionId,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get A Pls File With A Pronunciation Dictionary Version Rules<br/>
        /// Get a PLS file with a pronunciation dictionary version rules
        /// </summary>
        /// <param name="dictionaryId">
        /// The id of the pronunciation dictionary
        /// </param>
        /// <param name="versionId">
        /// The id of the pronunciation dictionary version
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<byte[]>> DownloadAsResponseAsync(
            string dictionaryId,
            string versionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}