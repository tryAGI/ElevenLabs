
#nullable enable

namespace ElevenLabs
{
    public partial class SpeechToTextEvaluationClient
    {
        partial void PrepareGetSpeechToTextEvaluationEvaluationsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? agentId,
            ref string? evalCriterionId,
            ref string? status,
            ref string? createdAfter,
            ref string? createdBefore,
            ref string? search,
            ref string? sortBy,
            ref string? sortDir,
            ref int? pageSize,
            ref string? cursor);
        partial void PrepareGetSpeechToTextEvaluationEvaluationsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? agentId,
            string? evalCriterionId,
            string? status,
            string? createdAfter,
            string? createdBefore,
            string? search,
            string? sortBy,
            string? sortDir,
            int? pageSize,
            string? cursor);
        partial void ProcessGetSpeechToTextEvaluationEvaluationsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetSpeechToTextEvaluationEvaluationsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Evaluations
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="evalCriterionId"></param>
        /// <param name="status"></param>
        /// <param name="createdAfter"></param>
        /// <param name="createdBefore"></param>
        /// <param name="search"></param>
        /// <param name="sortBy"></param>
        /// <param name="sortDir"></param>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::ElevenLabs.PaginatedEvaluationResponse> GetSpeechToTextEvaluationEvaluationsAsync(
            string? agentId = default,
            string? evalCriterionId = default,
            string? status = default,
            string? createdAfter = default,
            string? createdBefore = default,
            string? search = default,
            string? sortBy = default,
            string? sortDir = default,
            int? pageSize = default,
            string? cursor = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetSpeechToTextEvaluationEvaluationsArguments(
                httpClient: HttpClient,
                agentId: ref agentId,
                evalCriterionId: ref evalCriterionId,
                status: ref status,
                createdAfter: ref createdAfter,
                createdBefore: ref createdBefore,
                search: ref search,
                sortBy: ref sortBy,
                sortDir: ref sortDir,
                pageSize: ref pageSize,
                cursor: ref cursor);

            var __pathBuilder = new global::ElevenLabs.PathBuilder(
                path: "/v1/speech-to-text/evaluation/evaluations",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("agent_id", agentId)
                .AddOptionalParameter("eval_criterion_id", evalCriterionId)
                .AddOptionalParameter("status", status)
                .AddOptionalParameter("created_after", createdAfter)
                .AddOptionalParameter("created_before", createdBefore)
                .AddOptionalParameter("search", search)
                .AddOptionalParameter("sort_by", sortBy)
                .AddOptionalParameter("sort_dir", sortDir)
                .AddOptionalParameter("page_size", pageSize?.ToString())
                .AddOptionalParameter("cursor", cursor) 
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareGetSpeechToTextEvaluationEvaluationsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                agentId: agentId,
                evalCriterionId: evalCriterionId,
                status: status,
                createdAfter: createdAfter,
                createdBefore: createdBefore,
                search: search,
                sortBy: sortBy,
                sortDir: sortDir,
                pageSize: pageSize,
                cursor: cursor);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetSpeechToTextEvaluationEvaluationsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Validation Error
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::ElevenLabs.HTTPValidationError? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::ElevenLabs.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

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
                ProcessGetSpeechToTextEvaluationEvaluationsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::ElevenLabs.PaginatedEvaluationResponse.FromJson(__content, JsonSerializerContext) ??
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
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::ElevenLabs.PaginatedEvaluationResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
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
}