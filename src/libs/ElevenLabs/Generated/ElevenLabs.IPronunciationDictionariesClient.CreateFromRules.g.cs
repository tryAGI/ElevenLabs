#nullable enable

namespace ElevenLabs
{
    public partial interface IPronunciationDictionariesClient
    {
        /// <summary>
        /// Add A Pronunciation Dictionary<br/>
        /// Creates a new pronunciation dictionary from provided rules.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AddPronunciationDictionaryResponseModel> CreateFromRulesAsync(

            global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add A Pronunciation Dictionary<br/>
        /// Creates a new pronunciation dictionary from provided rules.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.AddPronunciationDictionaryResponseModel>> CreateFromRulesAsResponseAsync(

            global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add A Pronunciation Dictionary<br/>
        /// Creates a new pronunciation dictionary from provided rules.
        /// </summary>
        /// <param name="rules">
        /// List of pronunciation rules. Rule can be either:<br/>
        ///     an alias rule: {'string_to_replace': 'a', 'type': 'alias', 'alias': 'b', }<br/>
        ///     or a phoneme rule: {'string_to_replace': 'a', 'type': 'phoneme', 'phoneme': 'b', 'alphabet': 'ipa' }
        /// </param>
        /// <param name="name">
        /// The name of the pronunciation dictionary, used for identification only.
        /// </param>
        /// <param name="description">
        /// A description of the pronunciation dictionary, used for identification only.
        /// </param>
        /// <param name="workspaceAccess">
        /// Should be one of 'admin', 'editor' or 'viewer'. If not provided, defaults to no access.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AddPronunciationDictionaryResponseModel> CreateFromRulesAsync(
            global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>> rules,
            string name,
            string? description = default,
            global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccess2? workspaceAccess = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}