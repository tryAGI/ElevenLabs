#nullable enable

namespace ElevenLabs
{
    public partial interface IPronunciationDictionaryClient
    {
        /// <summary>
        /// Add Rules To The Pronunciation Dictionary<br/>
        /// Add rules to the pronunciation dictionary. If a rule with the same string_to_replace already exists, it will be replaced.
        /// </summary>
        /// <param name="pronunciationDictionaryId">
        /// The id of the pronunciation dictionary
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.PronunciationDictionaryRulesResponseModel> AddAsync(
            string pronunciationDictionaryId,

            global::ElevenLabs.BodyAddRulesToThePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdAddRulesPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Rules To The Pronunciation Dictionary<br/>
        /// Add rules to the pronunciation dictionary. If a rule with the same string_to_replace already exists, it will be replaced.
        /// </summary>
        /// <param name="pronunciationDictionaryId">
        /// The id of the pronunciation dictionary
        /// </param>
        /// <param name="rules">
        /// List of pronunciation rules. Rule can be either:<br/>
        ///     an alias rule: {'string_to_replace': 'a', 'type': 'alias', 'alias': 'b', }<br/>
        ///     or a phoneme rule: {'string_to_replace': 'a', 'type': 'phoneme', 'phoneme': 'b', 'alphabet': 'ipa' }
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.PronunciationDictionaryRulesResponseModel> AddAsync(
            string pronunciationDictionaryId,
            global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>> rules,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}