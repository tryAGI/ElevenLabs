
#nullable enable

namespace ElevenLabs
{
    public partial class PronunciationDictionaryClient
    {
        partial void PrepareCreatePronunciationDictionariesPronunciationDictionaryIdAddRulesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string pronunciationDictionaryId,
            ref string? xiApiKey,
            global::ElevenLabs.BodyAddRulesToThePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdAddRulesPost request);
        partial void PrepareCreatePronunciationDictionariesPronunciationDictionaryIdAddRulesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string pronunciationDictionaryId,
            string? xiApiKey,
            global::ElevenLabs.BodyAddRulesToThePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdAddRulesPost request);
        partial void ProcessCreatePronunciationDictionariesPronunciationDictionaryIdAddRulesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreatePronunciationDictionariesPronunciationDictionaryIdAddRulesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Add Rules To The Pronunciation Dictionary<br/>
        /// Add rules to the pronunciation dictionary
        /// </summary>
        /// <param name="pronunciationDictionaryId">
        /// The id of the pronunciation dictionary
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::ElevenLabs.AddPronunciationDictionaryRulesResponseModel> CreatePronunciationDictionariesPronunciationDictionaryIdAddRulesAsync(
            string pronunciationDictionaryId,
            global::ElevenLabs.BodyAddRulesToThePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdAddRulesPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreatePronunciationDictionariesPronunciationDictionaryIdAddRulesArguments(
                httpClient: _httpClient,
                pronunciationDictionaryId: ref pronunciationDictionaryId,
                xiApiKey: ref xiApiKey,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/v1/pronunciation-dictionaries/{pronunciationDictionaryId}/add-rules",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }

            if (xiApiKey != default)
            {
                httpRequest.Headers.TryAddWithoutValidation("xi-api-key", xiApiKey.ToString());
            }

            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreatePronunciationDictionariesPronunciationDictionaryIdAddRulesRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                pronunciationDictionaryId: pronunciationDictionaryId,
                xiApiKey: xiApiKey,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCreatePronunciationDictionariesPronunciationDictionaryIdAddRulesResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreatePronunciationDictionariesPronunciationDictionaryIdAddRulesResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::ElevenLabs.AddPronunciationDictionaryRulesResponseModel.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Add Rules To The Pronunciation Dictionary<br/>
        /// Add rules to the pronunciation dictionary
        /// </summary>
        /// <param name="pronunciationDictionaryId">
        /// The id of the pronunciation dictionary
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="rules">
        /// List of pronunciation rules. Rule can be either:<br/>
        ///     an alias rule: {'string_to_replace': 'a', 'type': 'alias', 'alias': 'b', }<br/>
        ///     or a phoneme rule: {'string_to_replace': 'a', 'type': 'phoneme', 'phoneme': 'b', 'alphabet': 'ipa' }
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::ElevenLabs.AddPronunciationDictionaryRulesResponseModel> CreatePronunciationDictionariesPronunciationDictionaryIdAddRulesAsync(
            string pronunciationDictionaryId,
            global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>> rules,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::ElevenLabs.BodyAddRulesToThePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdAddRulesPost
            {
                Rules = rules,
            };

            return await CreatePronunciationDictionariesPronunciationDictionaryIdAddRulesAsync(
                pronunciationDictionaryId: pronunciationDictionaryId,
                xiApiKey: xiApiKey,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}