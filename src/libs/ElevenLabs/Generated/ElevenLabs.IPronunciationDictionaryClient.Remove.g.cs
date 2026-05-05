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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.PronunciationDictionaryRulesResponseModel> RemoveAsync(
            string pronunciationDictionaryId,

            global::ElevenLabs.BodyRemoveRulesFromThePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdRemoveRulesPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove Rules From The Pronunciation Dictionary<br/>
        /// Remove rules from the pronunciation dictionary
        /// </summary>
        /// <param name="pronunciationDictionaryId">
        /// The id of the pronunciation dictionary
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.PronunciationDictionaryRulesResponseModel>> RemoveAsResponseAsync(
            string pronunciationDictionaryId,

            global::ElevenLabs.BodyRemoveRulesFromThePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdRemoveRulesPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.PronunciationDictionaryRulesResponseModel> RemoveAsync(
            string pronunciationDictionaryId,
            global::System.Collections.Generic.IList<string> ruleStrings,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}