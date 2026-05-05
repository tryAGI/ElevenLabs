
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs
{
    public partial class AgentsPlatformClient
    {


        private static readonly global::ElevenLabs.EndPointSecurityRequirement s_List7SecurityRequirement0 =
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
        private static readonly global::ElevenLabs.EndPointSecurityRequirement[] s_List7SecurityRequirements =
            new global::ElevenLabs.EndPointSecurityRequirement[]
            {                s_List7SecurityRequirement0,
            };
        partial void PrepareList7Arguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? pageSize,
            ref string? search,
            ref bool? showOnlyOwnedDocuments,
            ref string? createdByUserId,
            global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseDocumentType>? types,
            ref string? parentFolderId,
            ref string? ancestorFolderId,
            ref bool? foldersFirst,
            ref global::ElevenLabs.SortDirection? sortDirection,
            global::ElevenLabs.KnowledgeBaseSortBy? sortBy,
            ref string? cursor);
        partial void PrepareList7Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? pageSize,
            string? search,
            bool? showOnlyOwnedDocuments,
            string? createdByUserId,
            global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseDocumentType>? types,
            string? parentFolderId,
            string? ancestorFolderId,
            bool? foldersFirst,
            global::ElevenLabs.SortDirection? sortDirection,
            global::ElevenLabs.KnowledgeBaseSortBy? sortBy,
            string? cursor);
        partial void ProcessList7Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessList7ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Knowledge Base List<br/>
        /// Get a list of available knowledge base documents
        /// </summary>
        /// <param name="pageSize">
        /// How many documents to return at maximum. Can not exceed 100, defaults to 30.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="search">
        /// If specified, the endpoint returns only such knowledge base documents whose names start with this string.
        /// </param>
        /// <param name="showOnlyOwnedDocuments">
        /// If set to true, the endpoint will return only documents owned by you (and not shared from somebody else). Deprecated: use created_by_user_id instead.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="createdByUserId">
        /// Filter documents by creator user ID. When set, only documents created by this user are returned. Takes precedence over show_only_owned_documents. Use '@me' to refer to the authenticated user.
        /// </param>
        /// <param name="types">
        /// If present, the endpoint will return only documents of the given types.
        /// </param>
        /// <param name="parentFolderId">
        /// If set, the endpoint will return only documents that are direct children of the given folder.
        /// </param>
        /// <param name="ancestorFolderId">
        /// If set, the endpoint will return only documents that are descendants of the given folder.
        /// </param>
        /// <param name="foldersFirst">
        /// Whether folders should be returned first in the list of documents.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="sortDirection">
        /// The direction to sort the results<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="sortBy">
        /// The field to sort the results by
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::ElevenLabs.GetKnowledgeBaseListResponseModel> List7Async(
            int? pageSize = default,
            string? search = default,
            bool? showOnlyOwnedDocuments = default,
            string? createdByUserId = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseDocumentType>? types = default,
            string? parentFolderId = default,
            string? ancestorFolderId = default,
            bool? foldersFirst = default,
            global::ElevenLabs.SortDirection? sortDirection = default,
            global::ElevenLabs.KnowledgeBaseSortBy? sortBy = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await List7AsResponseAsync(
                pageSize: pageSize,
                search: search,
                showOnlyOwnedDocuments: showOnlyOwnedDocuments,
                createdByUserId: createdByUserId,
                types: types,
                parentFolderId: parentFolderId,
                ancestorFolderId: ancestorFolderId,
                foldersFirst: foldersFirst,
                sortDirection: sortDirection,
                sortBy: sortBy,
                cursor: cursor,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Get Knowledge Base List<br/>
        /// Get a list of available knowledge base documents
        /// </summary>
        /// <param name="pageSize">
        /// How many documents to return at maximum. Can not exceed 100, defaults to 30.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="search">
        /// If specified, the endpoint returns only such knowledge base documents whose names start with this string.
        /// </param>
        /// <param name="showOnlyOwnedDocuments">
        /// If set to true, the endpoint will return only documents owned by you (and not shared from somebody else). Deprecated: use created_by_user_id instead.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="createdByUserId">
        /// Filter documents by creator user ID. When set, only documents created by this user are returned. Takes precedence over show_only_owned_documents. Use '@me' to refer to the authenticated user.
        /// </param>
        /// <param name="types">
        /// If present, the endpoint will return only documents of the given types.
        /// </param>
        /// <param name="parentFolderId">
        /// If set, the endpoint will return only documents that are direct children of the given folder.
        /// </param>
        /// <param name="ancestorFolderId">
        /// If set, the endpoint will return only documents that are descendants of the given folder.
        /// </param>
        /// <param name="foldersFirst">
        /// Whether folders should be returned first in the list of documents.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="sortDirection">
        /// The direction to sort the results<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="sortBy">
        /// The field to sort the results by
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.GetKnowledgeBaseListResponseModel>> List7AsResponseAsync(
            int? pageSize = default,
            string? search = default,
            bool? showOnlyOwnedDocuments = default,
            string? createdByUserId = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseDocumentType>? types = default,
            string? parentFolderId = default,
            string? ancestorFolderId = default,
            bool? foldersFirst = default,
            global::ElevenLabs.SortDirection? sortDirection = default,
            global::ElevenLabs.KnowledgeBaseSortBy? sortBy = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareList7Arguments(
                httpClient: HttpClient,
                pageSize: ref pageSize,
                search: ref search,
                showOnlyOwnedDocuments: ref showOnlyOwnedDocuments,
                createdByUserId: ref createdByUserId,
                types: types,
                parentFolderId: ref parentFolderId,
                ancestorFolderId: ref ancestorFolderId,
                foldersFirst: ref foldersFirst,
                sortDirection: ref sortDirection,
                sortBy: sortBy,
                cursor: ref cursor);


            var __authorizations = global::ElevenLabs.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_List7SecurityRequirements,
                operationName: "List7Async");

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
                                path: "/v1/convai/knowledge-base",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("page_size", pageSize?.ToString())
                                .AddOptionalParameter("search", search)
                                .AddOptionalParameter("show_only_owned_documents", showOnlyOwnedDocuments?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("created_by_user_id", createdByUserId)
                                .AddOptionalParameter("types", types?.ToString())
                                .AddOptionalParameter("parent_folder_id", parentFolderId)
                                .AddOptionalParameter("ancestor_folder_id", ancestorFolderId)
                                .AddOptionalParameter("folders_first", foldersFirst?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("sort_direction", sortDirection?.ToValueString())
                                .AddOptionalParameter("sort_by", sortBy?.ToString())
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
                PrepareList7Request(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    pageSize: pageSize,
                    search: search,
                    showOnlyOwnedDocuments: showOnlyOwnedDocuments,
                    createdByUserId: createdByUserId,
                    types: types,
                    parentFolderId: parentFolderId,
                    ancestorFolderId: ancestorFolderId,
                    foldersFirst: foldersFirst,
                    sortDirection: sortDirection,
                    sortBy: sortBy,
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
                                operationId: "List7",
                                methodName: "List7Async",
                                pathTemplate: "\"/v1/convai/knowledge-base\"",
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
                                operationId: "List7",
                                methodName: "List7Async",
                                pathTemplate: "\"/v1/convai/knowledge-base\"",
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
                                operationId: "List7",
                                methodName: "List7Async",
                                pathTemplate: "\"/v1/convai/knowledge-base\"",
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
                ProcessList7Response(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::ElevenLabs.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::ElevenLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "List7",
                                methodName: "List7Async",
                                pathTemplate: "\"/v1/convai/knowledge-base\"",
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
                                operationId: "List7",
                                methodName: "List7Async",
                                pathTemplate: "\"/v1/convai/knowledge-base\"",
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

                                throw new global::ElevenLabs.ApiException<global::ElevenLabs.HTTPValidationError>(
                                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_422,
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
                                ProcessList7ResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::ElevenLabs.GetKnowledgeBaseListResponseModel.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.GetKnowledgeBaseListResponseModel>(
                                        statusCode: __response.StatusCode,
                                        headers: global::ElevenLabs.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
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

                                    var __value = await global::ElevenLabs.GetKnowledgeBaseListResponseModel.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.GetKnowledgeBaseListResponseModel>(
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
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}