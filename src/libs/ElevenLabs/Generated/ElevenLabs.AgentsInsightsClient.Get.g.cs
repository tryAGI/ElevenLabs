
#nullable enable

namespace ElevenLabs
{
    public partial class AgentsInsightsClient
    {


        private static readonly global::ElevenLabs.EndPointSecurityRequirement s_GetSecurityRequirement0 =
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
        private static readonly global::ElevenLabs.EndPointSecurityRequirement[] s_GetSecurityRequirements =
            new global::ElevenLabs.EndPointSecurityRequirement[]
            {                s_GetSecurityRequirement0,
            };
        partial void PrepareGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string agentId,
            int? pageSize,
            ref global::ElevenLabs.TopicSortBy? sortBy,
            ref global::ElevenLabs.SortDirection? sortDirection,
            int? fromUnixSecs,
            int? toUnixSecs,
            ref bool? includeEvaluationCriteria,
            ref string? cursor);
        partial void PrepareGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string agentId,
            int? pageSize,
            global::ElevenLabs.TopicSortBy? sortBy,
            global::ElevenLabs.SortDirection? sortDirection,
            int? fromUnixSecs,
            int? toUnixSecs,
            bool? includeEvaluationCriteria,
            string? cursor);
        partial void ProcessGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Agent Conversation Topics<br/>
        /// Returns the latest topic discovery run results for a given agent.
        /// </summary>
        /// <param name="agentId">
        /// ID of the agent
        /// </param>
        /// <param name="pageSize">
        /// Number of top-level topic groups to return.
        /// </param>
        /// <param name="sortBy">
        /// Column to rank topics by. Use conversations for volume, sentiment with sort_direction=asc for the most negative topics, and frustration with sort_direction=desc for the most frustrated ones. Topics with no score are always ranked last.<br/>
        /// Default Value: conversations
        /// </param>
        /// <param name="sortDirection">
        /// Direction to sort topics.<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="fromUnixSecs">
        /// Start of the window to view topics for. When set with to_unix_secs, the completed daily topic-discovery runs in the range are aggregated together, so the window scopes the metrics as well as the topic set. Floored to the start of its UTC day because runs cover whole UTC days; aggregated_run_count reports how many runs were summed. Omit both bounds to get the single latest run.
        /// </param>
        /// <param name="toUnixSecs">
        /// End of the window to view topics for.
        /// </param>
        /// <param name="includeEvaluationCriteria">
        /// Include the per-criteria evaluation breakdown on each topic's metrics. Pass false to drop it: it dominates the payload and the weighted success_rate is returned either way.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::ElevenLabs.GetAgentTopicsResponseModel> GetAsync(
            string agentId,
            int? pageSize = default,
            global::ElevenLabs.TopicSortBy? sortBy = default,
            global::ElevenLabs.SortDirection? sortDirection = default,
            int? fromUnixSecs = default,
            int? toUnixSecs = default,
            bool? includeEvaluationCriteria = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await GetAsResponseAsync(
                agentId: agentId,
                pageSize: pageSize,
                sortBy: sortBy,
                sortDirection: sortDirection,
                fromUnixSecs: fromUnixSecs,
                toUnixSecs: toUnixSecs,
                includeEvaluationCriteria: includeEvaluationCriteria,
                cursor: cursor,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Get Agent Conversation Topics<br/>
        /// Returns the latest topic discovery run results for a given agent.
        /// </summary>
        /// <param name="agentId">
        /// ID of the agent
        /// </param>
        /// <param name="pageSize">
        /// Number of top-level topic groups to return.
        /// </param>
        /// <param name="sortBy">
        /// Column to rank topics by. Use conversations for volume, sentiment with sort_direction=asc for the most negative topics, and frustration with sort_direction=desc for the most frustrated ones. Topics with no score are always ranked last.<br/>
        /// Default Value: conversations
        /// </param>
        /// <param name="sortDirection">
        /// Direction to sort topics.<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="fromUnixSecs">
        /// Start of the window to view topics for. When set with to_unix_secs, the completed daily topic-discovery runs in the range are aggregated together, so the window scopes the metrics as well as the topic set. Floored to the start of its UTC day because runs cover whole UTC days; aggregated_run_count reports how many runs were summed. Omit both bounds to get the single latest run.
        /// </param>
        /// <param name="toUnixSecs">
        /// End of the window to view topics for.
        /// </param>
        /// <param name="includeEvaluationCriteria">
        /// Include the per-criteria evaluation breakdown on each topic's metrics. Pass false to drop it: it dominates the payload and the weighted success_rate is returned either way.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.GetAgentTopicsResponseModel>> GetAsResponseAsync(
            string agentId,
            int? pageSize = default,
            global::ElevenLabs.TopicSortBy? sortBy = default,
            global::ElevenLabs.SortDirection? sortDirection = default,
            int? fromUnixSecs = default,
            int? toUnixSecs = default,
            bool? includeEvaluationCriteria = default,
            string? cursor = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetArguments(
                httpClient: HttpClient,
                agentId: ref agentId,
                pageSize: pageSize,
                sortBy: ref sortBy,
                sortDirection: ref sortDirection,
                fromUnixSecs: fromUnixSecs,
                toUnixSecs: toUnixSecs,
                includeEvaluationCriteria: ref includeEvaluationCriteria,
                cursor: ref cursor);


            var __authorizations = global::ElevenLabs.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetSecurityRequirements,
                operationName: "GetAsync");

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
                                path: $"/v1/convai/agents/{agentId}/topics",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("page_size", pageSize?.ToString())
                                .AddOptionalParameter("sort_by", sortBy?.ToValueString())
                                .AddOptionalParameter("sort_direction", sortDirection?.ToValueString())
                                .AddOptionalParameter("from_unix_secs", fromUnixSecs?.ToString())
                                .AddOptionalParameter("to_unix_secs", toUnixSecs?.ToString())
                                .AddOptionalParameter("include_evaluation_criteria", includeEvaluationCriteria?.ToString().ToLowerInvariant())
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
                PrepareGetRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    agentId: agentId!,
                    pageSize: pageSize,
                    sortBy: sortBy,
                    sortDirection: sortDirection,
                    fromUnixSecs: fromUnixSecs,
                    toUnixSecs: toUnixSecs,
                    includeEvaluationCriteria: includeEvaluationCriteria,
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
                                operationId: "Get",
                                methodName: "GetAsync",
                                pathTemplate: "$\"/v1/convai/agents/{agentId}/topics\"",
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
                                operationId: "Get",
                                methodName: "GetAsync",
                                pathTemplate: "$\"/v1/convai/agents/{agentId}/topics\"",
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
                                operationId: "Get",
                                methodName: "GetAsync",
                                pathTemplate: "$\"/v1/convai/agents/{agentId}/topics\"",
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
                ProcessGetResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::ElevenLabs.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::ElevenLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Get",
                                methodName: "GetAsync",
                                pathTemplate: "$\"/v1/convai/agents/{agentId}/topics\"",
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
                                operationId: "Get",
                                methodName: "GetAsync",
                                pathTemplate: "$\"/v1/convai/agents/{agentId}/topics\"",
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
                                ProcessGetResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::ElevenLabs.GetAgentTopicsResponseModel.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.GetAgentTopicsResponseModel>(
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

                                    var __value = await global::ElevenLabs.GetAgentTopicsResponseModel.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.GetAgentTopicsResponseModel>(
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
        /// Wraps GetAsync as an IAsyncEnumerable&lt;global::ElevenLabs.AgentTopicResponseModel&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="agentId">
        /// ID of the agent
        /// </param>
        /// <param name="pageSize">
        /// Number of top-level topic groups to return.
        /// </param>
        /// <param name="sortBy">
        /// Column to rank topics by. Use conversations for volume, sentiment with sort_direction=asc for the most negative topics, and frustration with sort_direction=desc for the most frustrated ones. Topics with no score are always ranked last.<br/>
        /// Default Value: conversations
        /// </param>
        /// <param name="sortDirection">
        /// Direction to sort topics.<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="fromUnixSecs">
        /// Start of the window to view topics for. When set with to_unix_secs, the completed daily topic-discovery runs in the range are aggregated together, so the window scopes the metrics as well as the topic set. Floored to the start of its UTC day because runs cover whole UTC days; aggregated_run_count reports how many runs were summed. Omit both bounds to get the single latest run.
        /// </param>
        /// <param name="toUnixSecs">
        /// End of the window to view topics for.
        /// </param>
        /// <param name="includeEvaluationCriteria">
        /// Include the per-criteria evaluation breakdown on each topic's metrics. Pass false to drop it: it dominates the payload and the weighted success_rate is returned either way.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="cursor">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        public global::System.Collections.Generic.IAsyncEnumerable<global::ElevenLabs.AgentTopicResponseModel> GetAutoPagingAsync(
            string agentId,             int? pageSize = default,
            global::ElevenLabs.TopicSortBy? sortBy = default,
            global::ElevenLabs.SortDirection? sortDirection = default,
            int? fromUnixSecs = default,
            int? toUnixSecs = default,
            bool? includeEvaluationCriteria = default,
            string? cursor = null,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            return global::ElevenLabs.AutoSDKPager.CursorAsync<global::ElevenLabs.GetAgentTopicsResponseModel, global::ElevenLabs.AgentTopicResponseModel>(
                fetchPage: (__cursor, __ct) => GetAsync(
                    agentId: agentId,
                    pageSize: pageSize,
                    sortBy: sortBy,
                    sortDirection: sortDirection,
                    fromUnixSecs: fromUnixSecs,
                    toUnixSecs: toUnixSecs,
                    includeEvaluationCriteria: includeEvaluationCriteria,
                    cursor: __cursor,
                    cancellationToken: __ct),
                extractItems: static __response => __response is null
                    ? null
                    : (global::System.Collections.Generic.IEnumerable<global::ElevenLabs.AgentTopicResponseModel>?)__response.Topics,
                extractNextCursor: static __response => __response is null ? null : __response.NextCursor,
                initialCursor: cursor,
                cancellationToken: cancellationToken);
        }

    }
}