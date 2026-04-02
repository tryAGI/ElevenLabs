#nullable enable

namespace ElevenLabs
{
    public partial interface IPronunciationDictionaryClient
    {
        /// <summary>
        /// Set Rules On The Pronunciation Dictionary<br/>
        /// Replaces all existing rules on the pronunciation dictionary with the provided ones.
        /// </summary>
        /// <param name="pronunciationDictionaryId">
        /// The id of the pronunciation dictionary
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.PronunciationDictionaryRulesResponseModel> SetAsync(
            string pronunciationDictionaryId,

            global::ElevenLabs.BodySetRulesOnThePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdSetRulesPost request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set Rules On The Pronunciation Dictionary<br/>
        /// Replaces all existing rules on the pronunciation dictionary with the provided ones.
        /// </summary>
        /// <param name="pronunciationDictionaryId">
        /// The id of the pronunciation dictionary
        /// </param>
        /// <param name="rules">
        /// List of pronunciation rules. Rule can be either:<br/>
        ///     an alias rule: {'string_to_replace': 'a', 'type': 'alias', 'alias': 'b', }<br/>
        ///     or a phoneme rule: {'string_to_replace': 'a', 'type': 'phoneme', 'phoneme': 'b', 'alphabet': 'ipa' }
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.PronunciationDictionaryRulesResponseModel> SetAsync(
            string pronunciationDictionaryId,
            global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>> rules,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}