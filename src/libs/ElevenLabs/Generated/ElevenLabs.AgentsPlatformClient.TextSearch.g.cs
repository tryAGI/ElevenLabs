
#nullable enable

namespace ElevenLabs
{
    public partial class AgentsPlatformClient
    {


        private static readonly global::ElevenLabs.EndPointSecurityRequirement s_TextSearchSecurityRequirement0 =
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
        private static readonly global::ElevenLabs.EndPointSecurityRequirement[] s_TextSearchSecurityRequirements =
            new global::ElevenLabs.EndPointSecurityRequirement[]
            {                s_TextSearchSecurityRequirement0,
            };
        partial void PrepareTextSearchArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string textQuery,
            ref string? agentId,
            global::ElevenLabs.EvaluationSuccessResult? callSuccessful,
            int? callStartBeforeUnix,
            int? callStartAfterUnix,
            int? callDurationMinSecs,
            int? callDurationMaxSecs,
            int? ratingMax,
            int? ratingMin,
            bool? hasFeedbackComment,
            ref string? userId,
            global::System.Collections.Generic.IList<string>? evaluationParams,
            global::System.Collections.Generic.IList<string>? dataCollectionParams,
            global::System.Collections.Generic.IList<string>? toolNames,
            global::System.Collections.Generic.IList<string>? toolNamesSuccessful,
            global::System.Collections.Generic.IList<string>? toolNamesErrored,
            global::System.Collections.Generic.IList<string>? mainLanguages,
            ref int? pageSize,
            ref global::ElevenLabs.TextSearchConversationMessagesRouteSummaryMode? summaryMode,
            global::ElevenLabs.ConversationInitiationSource? conversationInitiationSource,
            ref string? branchId,
            ref global::ElevenLabs.MessageSearchSortBy? sortBy,
            ref string? cursor);
        partial void PrepareTextSearchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string textQuery,
            string? agentId,
            global::ElevenLabs.EvaluationSuccessResult? callSuccessful,
            int? callStartBeforeUnix,
            int? callStartAfterUnix,
            int? callDurationMinSecs,
            int? callDurationMaxSecs,
            int? ratingMax,
            int? ratingMin,
            bool? hasFeedbackComment,
            string? userId,
            global::System.Collections.Generic.IList<string>? evaluationParams,
            global::System.Collections.Generic.IList<string>? dataCollectionParams,
            global::System.Collections.Generic.IList<string>? toolNames,
            global::System.Collections.Generic.IList<string>? toolNamesSuccessful,
            global::System.Collections.Generic.IList<string>? toolNamesErrored,
            global::System.Collections.Generic.IList<string>? mainLanguages,
            int? pageSize,
            global::ElevenLabs.TextSearchConversationMessagesRouteSummaryMode? summaryMode,
            global::ElevenLabs.ConversationInitiationSource? conversationInitiationSource,
            string? branchId,
            global::ElevenLabs.MessageSearchSortBy? sortBy,
            string? cursor);
        partial void ProcessTextSearchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTextSearchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Text Search Conversation Messages<br/>
        /// Search through conversation transcript messages by full-text and fuzzy search
        /// </summary>
        /// <param name="textQuery">
        /// The search query text for full-text and fuzzy matching
        /// </param>
        /// <param name="agentId">
        /// The id of the agent you're taking the action on.
        /// </param>
        /// <param name="callSuccessful">
        /// The result of the success evaluation
        /// </param>
        /// <param name="callStartBeforeUnix">
        /// Unix timestamp (in seconds) to filter conversations up to this start date.
        /// </param>
        /// <param name="callStartAfterUnix">
        /// Unix timestamp (in seconds) to filter conversations after to this start date.
        /// </param>
        /// <param name="callDurationMinSecs">
        /// Minimum call duration in seconds.
        /// </param>
        /// <param name="callDurationMaxSecs">
        /// Maximum call duration in seconds.
        /// </param>
        /// <param name="ratingMax">
        /// Maximum overall rating (1-5).
        /// </param>
        /// <param name="ratingMin">
        /// Minimum overall rating (1-5).
        /// </param>
        /// <param name="hasFeedbackComment">
        /// Filter conversations with user feedback comments.
        /// </param>
        /// <param name="userId">
        /// Filter conversations by the user ID who initiated them.
        /// </param>
        /// <param name="evaluationParams">
        /// Evaluation filters. Repeat param. Format: criteria_id:result. Example: eval=value_framing:success
        /// </param>
        /// <param name="dataCollectionParams">
        /// Data collection filters. Repeat param. Format: id:op:value where op is one of eq|neq|gt|gte|lt|lte|in|exists|missing. For in, pipe-delimit values.
        /// </param>
        /// <param name="toolNames">
        /// Filter conversations by tool names used during the call.
        /// </param>
        /// <param name="toolNamesSuccessful">
        /// Filter conversations by tool names that had successful calls.
        /// </param>
        /// <param name="toolNamesErrored">
        /// Filter conversations by tool names that had errored calls.
        /// </param>
        /// <param name="mainLanguages">
        /// Filter conversations by detected main language (language code).
        /// </param>
        /// <param name="pageSize">
        /// Number of results per page. Max 50.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="summaryMode">
        /// Whether to include transcript summaries in the response.<br/>
        /// Default Value: exclude
        /// </param>
        /// <param name="conversationInitiationSource"></param>
        /// <param name="branchId">
        /// Filter conversations by branch ID.
        /// </param>
        /// <param name="sortBy">
        /// Sort order for search results. 'search_score' sorts by search score, 'created_at' sorts by conversation start time.<br/>
        /// Default Value: search_score
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::ElevenLabs.MessagesSearchResponse> TextSearchAsync(
            string textQuery,
            string? agentId = default,
            global::ElevenLabs.EvaluationSuccessResult? callSuccessful = default,
            int? callStartBeforeUnix = default,
            int? callStartAfterUnix = default,
            int? callDurationMinSecs = default,
            int? callDurationMaxSecs = default,
            int? ratingMax = default,
            int? ratingMin = default,
            bool? hasFeedbackComment = default,
            string? userId = default,
            global::System.Collections.Generic.IList<string>? evaluationParams = default,
            global::System.Collections.Generic.IList<string>? dataCollectionParams = default,
            global::System.Collections.Generic.IList<string>? toolNames = default,
            global::System.Collections.Generic.IList<string>? toolNamesSuccessful = default,
            global::System.Collections.Generic.IList<string>? toolNamesErrored = default,
            global::System.Collections.Generic.IList<string>? mainLanguages = default,
            int? pageSize = default,
            global::ElevenLabs.TextSearchConversationMessagesRouteSummaryMode? summaryMode = default,
            global::ElevenLabs.ConversationInitiationSource? conversationInitiationSource = default,
            string? branchId = default,
            global::ElevenLabs.MessageSearchSortBy? sortBy = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareTextSearchArguments(
                httpClient: HttpClient,
                textQuery: ref textQuery,
                agentId: ref agentId,
                callSuccessful: callSuccessful,
                callStartBeforeUnix: callStartBeforeUnix,
                callStartAfterUnix: callStartAfterUnix,
                callDurationMinSecs: callDurationMinSecs,
                callDurationMaxSecs: callDurationMaxSecs,
                ratingMax: ratingMax,
                ratingMin: ratingMin,
                hasFeedbackComment: hasFeedbackComment,
                userId: ref userId,
                evaluationParams: evaluationParams,
                dataCollectionParams: dataCollectionParams,
                toolNames: toolNames,
                toolNamesSuccessful: toolNamesSuccessful,
                toolNamesErrored: toolNamesErrored,
                mainLanguages: mainLanguages,
                pageSize: ref pageSize,
                summaryMode: ref summaryMode,
                conversationInitiationSource: conversationInitiationSource,
                branchId: ref branchId,
                sortBy: ref sortBy,
                cursor: ref cursor);


            var __authorizations = global::ElevenLabs.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_TextSearchSecurityRequirements,
                operationName: "TextSearchAsync");

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
                                path: "/v1/convai/conversations/messages/text-search",
                                baseUri: HttpClient.BaseAddress); 
                            __pathBuilder
                                .AddRequiredParameter("text_query", textQuery)
                                .AddOptionalParameter("agent_id", agentId)
                                .AddOptionalParameter("call_successful", callSuccessful?.ToString())
                                .AddOptionalParameter("call_start_before_unix", callStartBeforeUnix?.ToString())
                                .AddOptionalParameter("call_start_after_unix", callStartAfterUnix?.ToString())
                                .AddOptionalParameter("call_duration_min_secs", callDurationMinSecs?.ToString())
                                .AddOptionalParameter("call_duration_max_secs", callDurationMaxSecs?.ToString())
                                .AddOptionalParameter("rating_max", ratingMax?.ToString())
                                .AddOptionalParameter("rating_min", ratingMin?.ToString())
                                .AddOptionalParameter("has_feedback_comment", hasFeedbackComment?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("user_id", userId)
                                .AddOptionalParameter("evaluation_params", evaluationParams?.ToString())
                                .AddOptionalParameter("data_collection_params", dataCollectionParams?.ToString())
                                .AddOptionalParameter("tool_names", toolNames?.ToString())
                                .AddOptionalParameter("tool_names_successful", toolNamesSuccessful?.ToString())
                                .AddOptionalParameter("tool_names_errored", toolNamesErrored?.ToString())
                                .AddOptionalParameter("main_languages", mainLanguages?.ToString())
                                .AddOptionalParameter("page_size", pageSize?.ToString())
                                .AddOptionalParameter("summary_mode", summaryMode?.ToValueString())
                                .AddOptionalParameter("conversation_initiation_source", conversationInitiationSource?.ToString())
                                .AddOptionalParameter("branch_id", branchId)
                                .AddOptionalParameter("sort_by", sortBy?.ToValueString())
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
                PrepareTextSearchRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    textQuery: textQuery!,
                    agentId: agentId,
                    callSuccessful: callSuccessful,
                    callStartBeforeUnix: callStartBeforeUnix,
                    callStartAfterUnix: callStartAfterUnix,
                    callDurationMinSecs: callDurationMinSecs,
                    callDurationMaxSecs: callDurationMaxSecs,
                    ratingMax: ratingMax,
                    ratingMin: ratingMin,
                    hasFeedbackComment: hasFeedbackComment,
                    userId: userId,
                    evaluationParams: evaluationParams,
                    dataCollectionParams: dataCollectionParams,
                    toolNames: toolNames,
                    toolNamesSuccessful: toolNamesSuccessful,
                    toolNamesErrored: toolNamesErrored,
                    mainLanguages: mainLanguages,
                    pageSize: pageSize,
                    summaryMode: summaryMode,
                    conversationInitiationSource: conversationInitiationSource,
                    branchId: branchId,
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
                                operationId: "TextSearch",
                                methodName: "TextSearchAsync",
                                pathTemplate: "\"/v1/convai/conversations/messages/text-search\"",
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
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::ElevenLabs.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::ElevenLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "TextSearch",
                                methodName: "TextSearchAsync",
                                pathTemplate: "\"/v1/convai/conversations/messages/text-search\"",
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
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::ElevenLabs.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::ElevenLabs.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::ElevenLabs.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::ElevenLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "TextSearch",
                                methodName: "TextSearchAsync",
                                pathTemplate: "\"/v1/convai/conversations/messages/text-search\"",
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
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::ElevenLabs.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
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
                ProcessTextSearchResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::ElevenLabs.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::ElevenLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "TextSearch",
                                methodName: "TextSearchAsync",
                                pathTemplate: "\"/v1/convai/conversations/messages/text-search\"",
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
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::ElevenLabs.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::ElevenLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "TextSearch",
                                methodName: "TextSearchAsync",
                                pathTemplate: "\"/v1/convai/conversations/messages/text-search\"",
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
                                ProcessTextSearchResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::ElevenLabs.MessagesSearchResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
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

                                    return
                                        await global::ElevenLabs.MessagesSearchResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
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