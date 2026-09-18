
#nullable enable

namespace ElevenLabs
{
    public partial class AgentsPlatformClient
    {


        private static readonly global::ElevenLabs.EndPointSecurityRequirement s_ListV2SecurityRequirement0 =
            new global::ElevenLabs.EndPointSecurityRequirement
            {
                Authorizations = new global::ElevenLabs.EndPointAuthorizationRequirement[]
                {                    new global::ElevenLabs.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        SchemeId = "ApikeyXiApiKey",
                        Location = "Header",
                        Name = "xi-api-key",
                        FriendlyName = "ApiKeyInHeader",
                    },
                },
            };
        private static readonly global::ElevenLabs.EndPointSecurityRequirement[] s_ListV2SecurityRequirements =
            new global::ElevenLabs.EndPointSecurityRequirement[]
            {                s_ListV2SecurityRequirement0,
            };
        partial void PrepareListV2Arguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? pageSize,
            ref string? search,
            ref string? label,
            ref string? phoneNumber,
            ref global::ElevenLabs.TelephonyProvider? provider,
            bool? supportsOutbound,
            ref string? agentId,
            ref string? branchId,
            ref global::ElevenLabs.PhoneNumberSortBy? sortBy,
            ref global::ElevenLabs.SortDirection? sortDirection,
            ref string? cursor);
        partial void PrepareListV2Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? pageSize,
            string? search,
            string? label,
            string? phoneNumber,
            global::ElevenLabs.TelephonyProvider? provider,
            bool? supportsOutbound,
            string? agentId,
            string? branchId,
            global::ElevenLabs.PhoneNumberSortBy? sortBy,
            global::ElevenLabs.SortDirection? sortDirection,
            string? cursor);
        partial void ProcessListV2Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListV2ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Phone Numbers Page<br/>
        /// Retrieve a page of Phone Numbers
        /// </summary>
        /// <param name="pageSize">
        /// Number of phone numbers per page<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="search">
        /// Filter by phone number ID, label, or phone number. A phone number ID must match exactly; label and phone number matching is a case-insensitive substring.
        /// </param>
        /// <param name="label">
        /// Filter by label. Matching is a case-insensitive substring.
        /// </param>
        /// <param name="phoneNumber">
        /// Filter by phone number
        /// </param>
        /// <param name="provider">
        /// Filter by telephony provider
        /// </param>
        /// <param name="supportsOutbound">
        /// Filter by whether the phone number can place outbound calls
        /// </param>
        /// <param name="agentId">
        /// Filter by assigned agent ID
        /// </param>
        /// <param name="branchId">
        /// Filter by assigned branch ID
        /// </param>
        /// <param name="sortBy">
        /// The field to sort the results by
        /// </param>
        /// <param name="sortDirection">
        /// The direction to sort the results<br/>
        /// Default Value: asc
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::ElevenLabs.GetPhoneNumbersPageResponseModel> ListV2Async(
            int? pageSize = default,
            string? search = default,
            string? label = default,
            string? phoneNumber = default,
            global::ElevenLabs.TelephonyProvider? provider = default,
            bool? supportsOutbound = default,
            string? agentId = default,
            string? branchId = default,
            global::ElevenLabs.PhoneNumberSortBy? sortBy = default,
            global::ElevenLabs.SortDirection? sortDirection = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await ListV2AsResponseAsync(
                pageSize: pageSize,
                search: search,
                label: label,
                phoneNumber: phoneNumber,
                provider: provider,
                supportsOutbound: supportsOutbound,
                agentId: agentId,
                branchId: branchId,
                sortBy: sortBy,
                sortDirection: sortDirection,
                cursor: cursor,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// List Phone Numbers Page<br/>
        /// Retrieve a page of Phone Numbers
        /// </summary>
        /// <param name="pageSize">
        /// Number of phone numbers per page<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="search">
        /// Filter by phone number ID, label, or phone number. A phone number ID must match exactly; label and phone number matching is a case-insensitive substring.
        /// </param>
        /// <param name="label">
        /// Filter by label. Matching is a case-insensitive substring.
        /// </param>
        /// <param name="phoneNumber">
        /// Filter by phone number
        /// </param>
        /// <param name="provider">
        /// Filter by telephony provider
        /// </param>
        /// <param name="supportsOutbound">
        /// Filter by whether the phone number can place outbound calls
        /// </param>
        /// <param name="agentId">
        /// Filter by assigned agent ID
        /// </param>
        /// <param name="branchId">
        /// Filter by assigned branch ID
        /// </param>
        /// <param name="sortBy">
        /// The field to sort the results by
        /// </param>
        /// <param name="sortDirection">
        /// The direction to sort the results<br/>
        /// Default Value: asc
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.GetPhoneNumbersPageResponseModel>> ListV2AsResponseAsync(
            int? pageSize = default,
            string? search = default,
            string? label = default,
            string? phoneNumber = default,
            global::ElevenLabs.TelephonyProvider? provider = default,
            bool? supportsOutbound = default,
            string? agentId = default,
            string? branchId = default,
            global::ElevenLabs.PhoneNumberSortBy? sortBy = default,
            global::ElevenLabs.SortDirection? sortDirection = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListV2Arguments(
                httpClient: HttpClient,
                pageSize: ref pageSize,
                search: ref search,
                label: ref label,
                phoneNumber: ref phoneNumber,
                provider: ref provider,
                supportsOutbound: supportsOutbound,
                agentId: ref agentId,
                branchId: ref branchId,
                sortBy: ref sortBy,
                sortDirection: ref sortDirection,
                cursor: ref cursor);


            var __authorizations = global::ElevenLabs.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ListV2SecurityRequirements,
                operationName: "ListV2Async");

            using var __timeoutCancellationTokenSource = global::ElevenLabs.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::ElevenLabs.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::ElevenLabs.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::ElevenLabs.PathBuilder(
                                path: "/v1/convai/v2/phone-numbers",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("page_size", pageSize?.ToString())
                                .AddOptionalParameter("search", search)
                                .AddOptionalParameter("label", label)
                                .AddOptionalParameter("phone_number", phoneNumber)
                                .AddOptionalParameter("provider", provider?.ToValueString())
                                .AddOptionalParameter("supports_outbound", supportsOutbound?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("agent_id", agentId)
                                .AddOptionalParameter("branch_id", branchId)
                                .AddOptionalParameter("sort_by", sortBy?.ToValueString())
                                .AddOptionalParameter("sort_direction", sortDirection?.ToValueString())
                                .AddOptionalParameter("cursor", cursor)
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::ElevenLabs.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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
                global::ElevenLabs.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareListV2Request(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    pageSize: pageSize,
                    search: search,
                    label: label,
                    phoneNumber: phoneNumber,
                    provider: provider,
                    supportsOutbound: supportsOutbound,
                    agentId: agentId,
                    branchId: branchId,
                    sortBy: sortBy,
                    sortDirection: sortDirection,
                    cursor: cursor);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::ElevenLabs.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::ElevenLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListV2",
                                methodName: "ListV2Async",
                                pathTemplate: "\"/v1/convai/v2/phone-numbers\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::ElevenLabs.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::ElevenLabs.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::ElevenLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListV2",
                                methodName: "ListV2Async",
                                pathTemplate: "\"/v1/convai/v2/phone-numbers\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::ElevenLabs.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::ElevenLabs.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::ElevenLabs.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::ElevenLabs.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::ElevenLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListV2",
                                methodName: "ListV2Async",
                                pathTemplate: "\"/v1/convai/v2/phone-numbers\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::ElevenLabs.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessListV2Response(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::ElevenLabs.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::ElevenLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListV2",
                                methodName: "ListV2Async",
                                pathTemplate: "\"/v1/convai/v2/phone-numbers\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::ElevenLabs.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::ElevenLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListV2",
                                methodName: "ListV2Async",
                                pathTemplate: "\"/v1/convai/v2/phone-numbers\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Validation Error
                            if ((int)__response.StatusCode == 422)
                            {
                                string? __content_422 = null;
                                global::System.Exception? __exception_422 = null;
                                global::ElevenLabs.HTTPValidationError? __value_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_422 = global::ElevenLabs.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_422 = global::ElevenLabs.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_422 = __ex;
                                }


                                throw global::ElevenLabs.ApiException<global::ElevenLabs.HTTPValidationError>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_422,
                                    responseBody: __content_422,
                                    responseObject: __value_422,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessListV2ResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::ElevenLabs.GetPhoneNumbersPageResponseModel.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.GetPhoneNumbersPageResponseModel>(
                                        statusCode: __response.StatusCode,
                                        headers: global::ElevenLabs.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::ElevenLabs.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::ElevenLabs.GetPhoneNumbersPageResponseModel.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.GetPhoneNumbersPageResponseModel>(
                                        statusCode: __response.StatusCode,
                                        headers: global::ElevenLabs.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw global::ElevenLabs.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }

        /// <summary>
        /// Wraps ListV2Async as an IAsyncEnumerable&lt;global::ElevenLabs.PhoneNumbersItem2&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="pageSize">
        /// Number of phone numbers per page<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="search">
        /// Filter by phone number ID, label, or phone number. A phone number ID must match exactly; label and phone number matching is a case-insensitive substring.
        /// </param>
        /// <param name="label">
        /// Filter by label. Matching is a case-insensitive substring.
        /// </param>
        /// <param name="phoneNumber">
        /// Filter by phone number
        /// </param>
        /// <param name="provider">
        /// Filter by telephony provider
        /// </param>
        /// <param name="supportsOutbound">
        /// Filter by whether the phone number can place outbound calls
        /// </param>
        /// <param name="agentId">
        /// Filter by assigned agent ID
        /// </param>
        /// <param name="branchId">
        /// Filter by assigned branch ID
        /// </param>
        /// <param name="sortBy">
        /// The field to sort the results by
        /// </param>
        /// <param name="sortDirection">
        /// The direction to sort the results<br/>
        /// Default Value: asc
        /// </param>
        /// <param name="cursor">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        public global::System.Collections.Generic.IAsyncEnumerable<global::ElevenLabs.PhoneNumbersItem2> ListV2AutoPagingAsync(
              int? pageSize = default,
            string? search = default,
            string? label = default,
            string? phoneNumber = default,
            global::ElevenLabs.TelephonyProvider? provider = default,
            bool? supportsOutbound = default,
            string? agentId = default,
            string? branchId = default,
            global::ElevenLabs.PhoneNumberSortBy? sortBy = default,
            global::ElevenLabs.SortDirection? sortDirection = default,
            string? cursor = null,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            return global::ElevenLabs.AutoSDKPager.CursorAsync<global::ElevenLabs.GetPhoneNumbersPageResponseModel, global::ElevenLabs.PhoneNumbersItem2>(
                fetchPage: (__cursor, __ct) => ListV2Async(
                    pageSize: pageSize,
                    search: search,
                    label: label,
                    phoneNumber: phoneNumber,
                    provider: provider,
                    supportsOutbound: supportsOutbound,
                    agentId: agentId,
                    branchId: branchId,
                    sortBy: sortBy,
                    sortDirection: sortDirection,
                    cursor: __cursor,
                    cancellationToken: __ct),
                extractItems: static __response => __response is null
                    ? null
                    : (global::System.Collections.Generic.IEnumerable<global::ElevenLabs.PhoneNumbersItem2>?)__response.PhoneNumbers,
                extractNextCursor: static __response => __response is null ? null : __response.NextCursor,
                initialCursor: cursor,
                cancellationToken: cancellationToken);
        }

    }
}