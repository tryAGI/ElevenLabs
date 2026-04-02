
#nullable enable

namespace ElevenLabs
{
    public partial class AgentsPlatformClient
    {
        partial void PrepareCreate12Arguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string agentId,
            global::ElevenLabs.BodyCreateANewBranchV1ConvaiAgentsAgentIdBranchesPost request);
        partial void PrepareCreate12Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string agentId,
            global::ElevenLabs.BodyCreateANewBranchV1ConvaiAgentsAgentIdBranchesPost request);
        partial void ProcessCreate12Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreate12ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create A New Branch<br/>
        /// Create a new branch from a given version of main branch
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::ElevenLabs.CreateAgentBranchResponseModel> Create12Async(
            string agentId,

            global::ElevenLabs.BodyCreateANewBranchV1ConvaiAgentsAgentIdBranchesPost request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreate12Arguments(
                httpClient: HttpClient,
                agentId: ref agentId,
                request: request);

            var __pathBuilder = new global::ElevenLabs.PathBuilder(
                path: $"/v1/convai/agents/{agentId}/branches",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreate12Request(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                agentId: agentId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreate12Response(
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
                ProcessCreate12ResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::ElevenLabs.CreateAgentBranchResponseModel.FromJson(__content, JsonSerializerContext) ??
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
                        await global::ElevenLabs.CreateAgentBranchResponseModel.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// <summary>
        /// Create A New Branch<br/>
        /// Create a new branch from a given version of main branch
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="parentVersionId">
        /// ID of the version to branch from
        /// </param>
        /// <param name="name">
        /// Name of the branch. It is unique within the agent.
        /// </param>
        /// <param name="description">
        /// Description for the branch
        /// </param>
        /// <param name="conversationConfig">
        /// Changes to apply to conversation config
        /// </param>
        /// <param name="platformSettings">
        /// Changes to apply to platform settings
        /// </param>
        /// <param name="workflow">
        /// Updated workflow definition
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::ElevenLabs.CreateAgentBranchResponseModel> Create12Async(
            string agentId,
            string parentVersionId,
            string name,
            string description,
            object? conversationConfig = default,
            object? platformSettings = default,
            global::ElevenLabs.AgentWorkflowRequestModel? workflow = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::ElevenLabs.BodyCreateANewBranchV1ConvaiAgentsAgentIdBranchesPost
            {
                ParentVersionId = parentVersionId,
                Name = name,
                Description = description,
                ConversationConfig = conversationConfig,
                PlatformSettings = platformSettings,
                Workflow = workflow,
            };

            return await Create12Async(
                agentId: agentId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}