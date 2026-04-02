#nullable enable

namespace ElevenLabs
{
    public partial interface IPronunciationDictionariesClient
    {
        /// <summary>
        /// Update Pronunciation Dictionary<br/>
        /// Partially update the pronunciation dictionary without changing the version
        /// </summary>
        /// <param name="pronunciationDictionaryId">
        /// The id of the pronunciation dictionary
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetPronunciationDictionaryMetadataResponseModel> UpdateAsync(
            string pronunciationDictionaryId,

            global::ElevenLabs.BodyUpdatePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdPatch request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Pronunciation Dictionary<br/>
        /// Partially update the pronunciation dictionary without changing the version
        /// </summary>
        /// <param name="pronunciationDictionaryId">
        /// The id of the pronunciation dictionary
        /// </param>
        /// <param name="archived">
        /// Whether to archive the pronunciation dictionary.
        /// </param>
        /// <param name="name">
        /// The name of the pronunciation dictionary, used for identification only.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetPronunciationDictionaryMetadataResponseModel> UpdateAsync(
            string pronunciationDictionaryId,
            bool? archived = default,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}