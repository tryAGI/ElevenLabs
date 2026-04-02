#nullable enable

namespace ElevenLabs
{
    public partial interface IPronunciationDictionaryClient
    {
        /// <summary>
        /// Remove Rules From The Pronunciation Dictionary<br/>
        /// Remove rules from the pronunciation dictionary
        /// </summary>
        /// <param name="pronunciationDictionaryId">
        /// The id of the pronunciation dictionary
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.PronunciationDictionaryRulesResponseModel> RemoveAsync(
            string pronunciationDictionaryId,

            global::ElevenLabs.BodyRemoveRulesFromThePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdRemoveRulesPost request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove Rules From The Pronunciation Dictionary<br/>
        /// Remove rules from the pronunciation dictionary
        /// </summary>
        /// <param name="pronunciationDictionaryId">
        /// The id of the pronunciation dictionary
        /// </param>
        /// <param name="ruleStrings">
        /// List of strings to remove from the pronunciation dictionary.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.PronunciationDictionaryRulesResponseModel> RemoveAsync(
            string pronunciationDictionaryId,
            global::System.Collections.Generic.IList<string> ruleStrings,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}