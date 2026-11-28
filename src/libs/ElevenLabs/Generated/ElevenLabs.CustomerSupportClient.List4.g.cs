
#nullable enable

namespace ElevenLabs
{
    public partial class CustomerSupportClient
    {


        private static readonly global::ElevenLabs.EndPointSecurityRequirement s_List4SecurityRequirement0 =
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
        private static readonly global::ElevenLabs.EndPointSecurityRequirement[] s_List4SecurityRequirements =
            new global::ElevenLabs.EndPointSecurityRequirement[]
            {                s_List4SecurityRequirement0,
            };
        partial void PrepareList4Arguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? pageSize,
            ref string? cursor,
            ref string? search,
            global::System.Collections.Generic.IList<global::ElevenLabs.TicketStatus>? status,
            global::System.Collections.Generic.IList<global::ElevenLabs.TicketPriority>? priority,
            global::System.Collections.Generic.IList<global::ElevenLabs.TicketSLAStatus>? slaStatus,
            global::System.Collections.Generic.IList<global::ElevenLabs.TicketDeadlineStatus>? deadlineStatus,
            global::System.Collections.Generic.IList<string>? requesterUserId,
            global::System.Collections.Generic.IList<string>? assigneeId,
            global::System.Collections.Generic.IList<string>? tagIds,
            ref bool? unassigned,
            ref global::ElevenLabs.TicketSortBy? sortBy,
            ref global::ElevenLabs.SortDirection? sortDirection);
        partial void PrepareList4Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? pageSize,
            string? cursor,
            string? search,
            global::System.Collections.Generic.IList<global::ElevenLabs.TicketStatus>? status,
            global::System.Collections.Generic.IList<global::ElevenLabs.TicketPriority>? priority,
            global::System.Collections.Generic.IList<global::ElevenLabs.TicketSLAStatus>? slaStatus,
            global::System.Collections.Generic.IList<global::ElevenLabs.TicketDeadlineStatus>? deadlineStatus,
            global::System.Collections.Generic.IList<string>? requesterUserId,
            global::System.Collections.Generic.IList<string>? assigneeId,
            global::System.Collections.Generic.IList<string>? tagIds,
            bool? unassigned,
            global::ElevenLabs.TicketSortBy? sortBy,
            global::ElevenLabs.SortDirection? sortDirection);
        partial void ProcessList4Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessList4ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Tickets<br/>
        /// List tickets
        /// </summary>
        /// <param name="pageSize">
        /// Default Value: 30
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="search"></param>
        /// <param name="status"></param>
        /// <param name="priority"></param>
        /// <param name="slaStatus"></param>
        /// <param name="deadlineStatus"></param>
        /// <param name="requesterUserId"></param>
        /// <param name="assigneeId"></param>
        /// <param name="tagIds">
        /// Only return tickets with any of these tag IDs.
        /// </param>
        /// <param name="unassigned">
        /// Default Value: false
        /// </param>
        /// <param name="sortBy">
        /// The field to sort the results by<br/>
        /// Default Value: updated_at
        /// </param>
        /// <param name="sortDirection">
        /// The direction to sort the results<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "ELEVENLABS_ALPHA_001")]
#endif
        public async global::System.Threading.Tasks.Task<global::ElevenLabs.PaginatedResultTicketListItemResponse> List4Async(
            int? pageSize = default,
            string? cursor = default,
            string? search = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.TicketStatus>? status = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.TicketPriority>? priority = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.TicketSLAStatus>? slaStatus = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.TicketDeadlineStatus>? deadlineStatus = default,
            global::System.Collections.Generic.IList<string>? requesterUserId = default,
            global::System.Collections.Generic.IList<string>? assigneeId = default,
            global::System.Collections.Generic.IList<string>? tagIds = default,
            bool? unassigned = default,
            global::ElevenLabs.TicketSortBy? sortBy = default,
            global::ElevenLabs.SortDirection? sortDirection = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await List4AsResponseAsync(
                pageSize: pageSize,
                cursor: cursor,
                search: search,
                status: status,
                priority: priority,
                slaStatus: slaStatus,
                deadlineStatus: deadlineStatus,
                requesterUserId: requesterUserId,
                assigneeId: assigneeId,
                tagIds: tagIds,
                unassigned: unassigned,
                sortBy: sortBy,
                sortDirection: sortDirection,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// List Tickets<br/>
        /// List tickets
        /// </summary>
        /// <param name="pageSize">
        /// Default Value: 30
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="search"></param>
        /// <param name="status"></param>
        /// <param name="priority"></param>
        /// <param name="slaStatus"></param>
        /// <param name="deadlineStatus"></param>
        /// <param name="requesterUserId"></param>
        /// <param name="assigneeId"></param>
        /// <param name="tagIds">
        /// Only return tickets with any of these tag IDs.
        /// </param>
        /// <param name="unassigned">
        /// Default Value: false
        /// </param>
        /// <param name="sortBy">
        /// The field to sort the results by<br/>
        /// Default Value: updated_at
        /// </param>
        /// <param name="sortDirection">
        /// The direction to sort the results<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "ELEVENLABS_ALPHA_001")]
#endif
        public async global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.PaginatedResultTicketListItemResponse>> List4AsResponseAsync(
            int? pageSize = default,
            string? cursor = default,
            string? search = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.TicketStatus>? status = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.TicketPriority>? priority = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.TicketSLAStatus>? slaStatus = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.TicketDeadlineStatus>? deadlineStatus = default,
            global::System.Collections.Generic.IList<string>? requesterUserId = default,
            global::System.Collections.Generic.IList<string>? assigneeId = default,
            global::System.Collections.Generic.IList<string>? tagIds = default,
            bool? unassigned = default,
            global::ElevenLabs.TicketSortBy? sortBy = default,
            global::ElevenLabs.SortDirection? sortDirection = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var JsonSerializerContext = JsonSerializerContextProvider?.Value ??
                global::ElevenLabs.SourceGenerationContextOperation_0C17A4836B021803.Default;
            PrepareArguments(
                client: HttpClient);
            PrepareList4Arguments(
                httpClient: HttpClient,
                pageSize: ref pageSize,
                cursor: ref cursor,
                search: ref search,
                status: status,
                priority: priority,
                slaStatus: slaStatus,
                deadlineStatus: deadlineStatus,
                requesterUserId: requesterUserId,
                assigneeId: assigneeId,
                tagIds: tagIds,
                unassigned: ref unassigned,
                sortBy: ref sortBy,
                sortDirection: ref sortDirection);


            var __authorizations = global::ElevenLabs.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_List4SecurityRequirements,
                operationName: "List4Async");

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
                                path: "/v1/support/tickets",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("page_size", pageSize?.ToString())
                                .AddOptionalParameter("cursor", cursor)
                                .AddOptionalParameter("search", search)
                                .AddOptionalParameter("status", status, selector: static x => x.ToValueString(), delimiter: ",", explode: true)
                                .AddOptionalParameter("priority", priority, selector: static x => x.ToValueString(), delimiter: ",", explode: true)
                                .AddOptionalParameter("sla_status", slaStatus, selector: static x => x.ToValueString(), delimiter: ",", explode: true)
                                .AddOptionalParameter("deadline_status", deadlineStatus, selector: static x => x.ToValueString(), delimiter: ",", explode: true)
                                .AddOptionalParameter("requester_user_id", requesterUserId, delimiter: ",", explode: true)
                                .AddOptionalParameter("assignee_id", assigneeId, delimiter: ",", explode: true)
                                .AddOptionalParameter("tag_ids", tagIds, delimiter: ",", explode: true)
                                .AddOptionalParameter("unassigned", unassigned?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("sort_by", sortBy?.ToValueString())
                                .AddOptionalParameter("sort_direction", sortDirection?.ToValueString())
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
                PrepareList4Request(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    pageSize: pageSize,
                    cursor: cursor,
                    search: search,
                    status: status,
                    priority: priority,
                    slaStatus: slaStatus,
                    deadlineStatus: deadlineStatus,
                    requesterUserId: requesterUserId,
                    assigneeId: assigneeId,
                    tagIds: tagIds,
                    unassigned: unassigned,
                    sortBy: sortBy,
                    sortDirection: sortDirection);

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
                                operationId: "List4",
                                methodName: "List4Async",
                                pathTemplate: "\"/v1/support/tickets\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                                operationId: "List4",
                                methodName: "List4Async",
                                pathTemplate: "\"/v1/support/tickets\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                                operationId: "List4",
                                methodName: "List4Async",
                                pathTemplate: "\"/v1/support/tickets\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                ProcessList4Response(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::ElevenLabs.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::ElevenLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "List4",
                                methodName: "List4Async",
                                pathTemplate: "\"/v1/support/tickets\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                                operationId: "List4",
                                methodName: "List4Async",
                                pathTemplate: "\"/v1/support/tickets\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                                        __value_422 = __content_422 is not { Length: > 0 } ? null : global::ElevenLabs.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_422 = __content_422 is not { Length: > 0 } ? null : global::ElevenLabs.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_422 = __ex;
                                }


                                throw global::ElevenLabs.ApiException<global::ElevenLabs.HTTPValidationError>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_422 is { Length: > 0 } ? __content_422 : __response.ReasonPhrase ?? string.Empty,
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
                                ProcessList4ResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::ElevenLabs.PaginatedResultTicketListItemResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.PaginatedResultTicketListItemResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::ElevenLabs.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::ElevenLabs.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content is { Length: > 0 } ? __content : __response.ReasonPhrase ?? string.Empty,
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

                                    var __value = await global::ElevenLabs.PaginatedResultTicketListItemResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.PaginatedResultTicketListItemResponse>(
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
                                        message: __content is { Length: > 0 } ? __content : __response.ReasonPhrase ?? string.Empty,
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
        /// Wraps List4Async as an IAsyncEnumerable&lt;global::ElevenLabs.TicketListItemResponse&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="pageSize">
        /// Default Value: 30
        /// </param>
        /// <param name="search"></param>
        /// <param name="status"></param>
        /// <param name="priority"></param>
        /// <param name="slaStatus"></param>
        /// <param name="deadlineStatus"></param>
        /// <param name="requesterUserId"></param>
        /// <param name="assigneeId"></param>
        /// <param name="tagIds">
        /// Only return tickets with any of these tag IDs.
        /// </param>
        /// <param name="unassigned">
        /// Default Value: false
        /// </param>
        /// <param name="sortBy">
        /// The field to sort the results by<br/>
        /// Default Value: updated_at
        /// </param>
        /// <param name="sortDirection">
        /// The direction to sort the results<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="cursor">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        public global::System.Collections.Generic.IAsyncEnumerable<global::ElevenLabs.TicketListItemResponse> List4AutoPagingAsync(
              int? pageSize = default,
            string? search = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.TicketStatus>? status = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.TicketPriority>? priority = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.TicketSLAStatus>? slaStatus = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.TicketDeadlineStatus>? deadlineStatus = default,
            global::System.Collections.Generic.IList<string>? requesterUserId = default,
            global::System.Collections.Generic.IList<string>? assigneeId = default,
            global::System.Collections.Generic.IList<string>? tagIds = default,
            bool? unassigned = default,
            global::ElevenLabs.TicketSortBy? sortBy = default,
            global::ElevenLabs.SortDirection? sortDirection = default,
            string? cursor = null,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            return global::ElevenLabs.AutoSDKPager.CursorAsync<global::ElevenLabs.PaginatedResultTicketListItemResponse, global::ElevenLabs.TicketListItemResponse>(
                fetchPage: (__cursor, __ct) => List4Async(
                    pageSize: pageSize,
                    cursor: __cursor,
                    search: search,
                    status: status,
                    priority: priority,
                    slaStatus: slaStatus,
                    deadlineStatus: deadlineStatus,
                    requesterUserId: requesterUserId,
                    assigneeId: assigneeId,
                    tagIds: tagIds,
                    unassigned: unassigned,
                    sortBy: sortBy,
                    sortDirection: sortDirection,
                    cancellationToken: __ct),
                extractItems: static __response => __response is null
                    ? null
                    : (global::System.Collections.Generic.IEnumerable<global::ElevenLabs.TicketListItemResponse>?)__response.Results,
                extractNextCursor: static __response => __response is null ? null : __response.NextCursor,
                initialCursor: cursor,
                cancellationToken: cancellationToken);
        }

    }
}