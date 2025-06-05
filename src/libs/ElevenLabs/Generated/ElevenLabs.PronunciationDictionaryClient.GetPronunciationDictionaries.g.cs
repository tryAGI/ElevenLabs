
#nullable enable

namespace ElevenLabs
{
    public partial class PronunciationDictionaryClient
    {
        partial void PrepareGetPronunciationDictionariesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? cursor,
            ref int? pageSize,
            ref global::ElevenLabs.GetPronunciationDictionariesV1PronunciationDictionariesGetSort? sort,
            ref string? sortDirection,
            ref string? xiApiKey);
        partial void PrepareGetPronunciationDictionariesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? cursor,
            int? pageSize,
            global::ElevenLabs.GetPronunciationDictionariesV1PronunciationDictionariesGetSort? sort,
            string? sortDirection,
            string? xiApiKey);
        partial void ProcessGetPronunciationDictionariesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetPronunciationDictionariesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Pronunciation Dictionaries<br/>
        /// Get a list of the pronunciation dictionaries you have access to and their metadata
        /// </summary>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="pageSize">
        /// How many pronunciation dictionaries to return at maximum. Can not exceed 100, defaults to 30.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="sort">
        /// Which field to sort by, one of 'created_at_unix' or 'name'.<br/>
        /// Default Value: creation_time_unix<br/>
        /// Example: creation_time_unix
        /// </param>
        /// <param name="sortDirection">
        /// Which direction to sort the voices in. 'ascending' or 'descending'.<br/>
        /// Default Value: DESCENDING<br/>
        /// Example: descending
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::ElevenLabs.GetPronunciationDictionariesMetadataResponseModel> GetPronunciationDictionariesAsync(
            string? cursor = default,
            int? pageSize = default,
            global::ElevenLabs.GetPronunciationDictionariesV1PronunciationDictionariesGetSort? sort = default,
            string? sortDirection = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetPronunciationDictionariesArguments(
                httpClient: HttpClient,
                cursor: ref cursor,
                pageSize: ref pageSize,
                sort: ref sort,
                sortDirection: ref sortDirection,
                xiApiKey: ref xiApiKey);

            var __pathBuilder = new global::ElevenLabs.PathBuilder(
                path: "/v1/pronunciation-dictionaries/",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("cursor", cursor) 
                .AddOptionalParameter("page_size", pageSize?.ToString()) 
                .AddOptionalParameter("sort", sort?.ToValueString()) 
                .AddOptionalParameter("sort_direction", sortDirection) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

            if (xiApiKey != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("xi-api-key", xiApiKey.ToString());
            }


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareGetPronunciationDictionariesRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                cursor: cursor,
                pageSize: pageSize,
                sort: sort,
                sortDirection: sortDirection,
                xiApiKey: xiApiKey);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetPronunciationDictionariesResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Validation Error
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::ElevenLabs.HTTPValidationError? __value_422 = null;
                if (ReadResponseAsString)
                {
                    __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_422 = global::ElevenLabs.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                }
                else
                {
                    var __contentStream_422 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_422 = await global::ElevenLabs.HTTPValidationError.FromJsonStreamAsync(__contentStream_422, JsonSerializerContext).ConfigureAwait(false);
                }

                throw new global::ElevenLabs.ApiException<global::ElevenLabs.HTTPValidationError>(
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseObject = __value_422,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessGetPronunciationDictionariesResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::ElevenLabs.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                return
                    global::ElevenLabs.GetPronunciationDictionariesMetadataResponseModel.FromJson(__content, JsonSerializerContext) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::ElevenLabs.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                return
                    await global::ElevenLabs.GetPronunciationDictionariesMetadataResponseModel.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }
    }
}