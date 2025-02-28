
#nullable enable

namespace ElevenLabs
{
    public partial class VoicesClient
    {
        partial void PrepareGetSharedVoicesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? pageSize,
            ref string? category,
            ref string? gender,
            ref string? age,
            ref string? accent,
            ref string? language,
            ref string? search,
            global::System.Collections.Generic.IList<string>? useCases,
            global::System.Collections.Generic.IList<string>? descriptives,
            ref bool? featured,
            ref int? minNoticePeriodDays,
            ref bool? readerAppEnabled,
            ref string? ownerId,
            ref string? sort,
            ref int? page,
            ref string? xiApiKey);
        partial void PrepareGetSharedVoicesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? pageSize,
            string? category,
            string? gender,
            string? age,
            string? accent,
            string? language,
            string? search,
            global::System.Collections.Generic.IList<string>? useCases,
            global::System.Collections.Generic.IList<string>? descriptives,
            bool? featured,
            int? minNoticePeriodDays,
            bool? readerAppEnabled,
            string? ownerId,
            string? sort,
            int? page,
            string? xiApiKey);
        partial void ProcessGetSharedVoicesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetSharedVoicesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Voices<br/>
        /// Gets a list of shared voices.
        /// </summary>
        /// <param name="pageSize">
        /// How many shared voices to return at maximum. Can not exceed 100, defaults to 30.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="category">
        /// voice category used for filtering<br/>
        /// Example: professional
        /// </param>
        /// <param name="gender">
        /// gender used for filtering<br/>
        /// Example: male
        /// </param>
        /// <param name="age">
        /// age used for filtering<br/>
        /// Example: young
        /// </param>
        /// <param name="accent">
        /// accent used for filtering<br/>
        /// Example: american
        /// </param>
        /// <param name="language">
        /// language used for filtering<br/>
        /// Example: en
        /// </param>
        /// <param name="search">
        /// search term used for filtering<br/>
        /// Example: tiktok
        /// </param>
        /// <param name="useCases">
        /// use-case used for filtering<br/>
        /// Example: audiobook
        /// </param>
        /// <param name="descriptives">
        /// search term used for filtering<br/>
        /// Example: tiktok
        /// </param>
        /// <param name="featured">
        /// Filter featured voices<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="minNoticePeriodDays">
        /// Filter voices with a minimum notice period of the given number of days.<br/>
        /// Example: 30
        /// </param>
        /// <param name="readerAppEnabled">
        /// Filter voices that are enabled for the reader app<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="ownerId">
        /// Filter voices by public owner ID<br/>
        /// Example: 7c9fab611d9a0e1fb2e7448a0c294a8804efc2bcc324b0a366a5d5232b7d1532
        /// </param>
        /// <param name="sort">
        /// sort criteria<br/>
        /// Example: created_date
        /// </param>
        /// <param name="page">
        /// Default Value: 0
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::ElevenLabs.GetLibraryVoicesResponseModel> GetSharedVoicesAsync(
            int? pageSize = default,
            string? category = default,
            string? gender = default,
            string? age = default,
            string? accent = default,
            string? language = default,
            string? search = default,
            global::System.Collections.Generic.IList<string>? useCases = default,
            global::System.Collections.Generic.IList<string>? descriptives = default,
            bool? featured = default,
            int? minNoticePeriodDays = default,
            bool? readerAppEnabled = default,
            string? ownerId = default,
            string? sort = default,
            int? page = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetSharedVoicesArguments(
                httpClient: HttpClient,
                pageSize: ref pageSize,
                category: ref category,
                gender: ref gender,
                age: ref age,
                accent: ref accent,
                language: ref language,
                search: ref search,
                useCases: useCases,
                descriptives: descriptives,
                featured: ref featured,
                minNoticePeriodDays: ref minNoticePeriodDays,
                readerAppEnabled: ref readerAppEnabled,
                ownerId: ref ownerId,
                sort: ref sort,
                page: ref page,
                xiApiKey: ref xiApiKey);

            var __pathBuilder = new PathBuilder(
                path: "/v1/shared-voices",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("page_size", pageSize?.ToString()) 
                .AddOptionalParameter("category", category) 
                .AddOptionalParameter("gender", gender) 
                .AddOptionalParameter("age", age) 
                .AddOptionalParameter("accent", accent) 
                .AddOptionalParameter("language", language) 
                .AddOptionalParameter("search", search) 
                .AddOptionalParameter("use_cases", useCases, delimiter: ",", explode: true) 
                .AddOptionalParameter("descriptives", descriptives, delimiter: ",", explode: true) 
                .AddOptionalParameter("featured", featured?.ToString()) 
                .AddOptionalParameter("min_notice_period_days", minNoticePeriodDays?.ToString()) 
                .AddOptionalParameter("reader_app_enabled", readerAppEnabled?.ToString()) 
                .AddOptionalParameter("owner_id", ownerId) 
                .AddOptionalParameter("sort", sort) 
                .AddOptionalParameter("page", page?.ToString()) 
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
            PrepareGetSharedVoicesRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                pageSize: pageSize,
                category: category,
                gender: gender,
                age: age,
                accent: accent,
                language: language,
                search: search,
                useCases: useCases,
                descriptives: descriptives,
                featured: featured,
                minNoticePeriodDays: minNoticePeriodDays,
                readerAppEnabled: readerAppEnabled,
                ownerId: ownerId,
                sort: sort,
                page: page,
                xiApiKey: xiApiKey);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetSharedVoicesResponse(
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
                ProcessGetSharedVoicesResponseContent(
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
                    global::ElevenLabs.GetLibraryVoicesResponseModel.FromJson(__content, JsonSerializerContext) ??
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
                    await global::ElevenLabs.GetLibraryVoicesResponseModel.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }
    }
}