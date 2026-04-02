
#nullable enable

namespace ElevenLabs
{
    public partial class AgentsPlatformClient
    {
        partial void PrepareList3Arguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? agentId,
            ref string? branchId,
            int? callStartBeforeUnix,
            int? callStartAfterUnix,
            ref string? search,
            ref int? pageSize,
            ref global::ElevenLabs.UsersSortBy? sortBy,
            ref string? cursor);
        partial void PrepareList3Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? agentId,
            string? branchId,
            int? callStartBeforeUnix,
            int? callStartAfterUnix,
            string? search,
            int? pageSize,
            global::ElevenLabs.UsersSortBy? sortBy,
            string? cursor);
        partial void ProcessList3Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessList3ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Conversation Users<br/>
        /// Get distinct users from conversations with pagination.
        /// </summary>
        /// <param name="agentId">
        /// The id of the agent you're taking the action on.
        /// </param>
        /// <param name="branchId">
        /// Filter conversations by branch ID.
        /// </param>
        /// <param name="callStartBeforeUnix">
        /// Unix timestamp (in seconds) to filter conversations up to this start date.
        /// </param>
        /// <param name="callStartAfterUnix">
        /// Unix timestamp (in seconds) to filter conversations after to this start date.
        /// </param>
        /// <param name="search">
        /// Search/filter by user ID (exact match).
        /// </param>
        /// <param name="pageSize">
        /// How many users to return at maximum. Defaults to 30.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="sortBy">
        /// The field to sort the results by. Defaults to last_contact_unix_secs.<br/>
        /// Default Value: last_contact_unix_secs
        /// </param>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::ElevenLabs.GetConversationUsersPageResponseModel> List3Async(
            string? agentId = default,
            string? branchId = default,
            int? callStartBeforeUnix = default,
            int? callStartAfterUnix = default,
            string? search = default,
            int? pageSize = default,
            global::ElevenLabs.UsersSortBy? sortBy = default,
            string? cursor = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareList3Arguments(
                httpClient: HttpClient,
                agentId: ref agentId,
                branchId: ref branchId,
                callStartBeforeUnix: callStartBeforeUnix,
                callStartAfterUnix: callStartAfterUnix,
                search: ref search,
                pageSize: ref pageSize,
                sortBy: ref sortBy,
                cursor: ref cursor);

            var __pathBuilder = new global::ElevenLabs.PathBuilder(
                path: "/v1/convai/users",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("agent_id", agentId)
                .AddOptionalParameter("branch_id", branchId)
                .AddOptionalParameter("call_start_before_unix", callStartBeforeUnix?.ToString())
                .AddOptionalParameter("call_start_after_unix", callStartAfterUnix?.ToString())
                .AddOptionalParameter("search", search)
                .AddOptionalParameter("page_size", pageSize?.ToString())
                .AddOptionalParameter("sort_by", sortBy?.ToValueString())
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
            PrepareList3Request(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                agentId: agentId,
                branchId: branchId,
                callStartBeforeUnix: callStartBeforeUnix,
                callStartAfterUnix: callStartAfterUnix,
                search: search,
                pageSize: pageSize,
                sortBy: sortBy,
                cursor: cursor);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessList3Response(
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
                ProcessList3ResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::ElevenLabs.GetConversationUsersPageResponseModel.FromJson(__content, JsonSerializerContext) ??
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
                        await global::ElevenLabs.GetConversationUsersPageResponseModel.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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