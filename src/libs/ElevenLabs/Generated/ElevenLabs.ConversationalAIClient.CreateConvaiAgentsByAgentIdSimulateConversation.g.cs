
#nullable enable

namespace ElevenLabs
{
    public partial class ConversationalAIClient
    {
        partial void PrepareCreateConvaiAgentsByAgentIdSimulateConversationArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string agentId,
            ref string? xiApiKey,
            global::ElevenLabs.BodySimulatesAConversationV1ConvaiAgentsAgentIdSimulateConversationPost request);
        partial void PrepareCreateConvaiAgentsByAgentIdSimulateConversationRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string agentId,
            string? xiApiKey,
            global::ElevenLabs.BodySimulatesAConversationV1ConvaiAgentsAgentIdSimulateConversationPost request);
        partial void ProcessCreateConvaiAgentsByAgentIdSimulateConversationResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateConvaiAgentsByAgentIdSimulateConversationResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Simulates A Conversation<br/>
        /// Run a conversation between the agent and a simulated user.
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::ElevenLabs.AgentSimulatedChatTestResponseModel> CreateConvaiAgentsByAgentIdSimulateConversationAsync(
            string agentId,
            global::ElevenLabs.BodySimulatesAConversationV1ConvaiAgentsAgentIdSimulateConversationPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateConvaiAgentsByAgentIdSimulateConversationArguments(
                httpClient: HttpClient,
                agentId: ref agentId,
                xiApiKey: ref xiApiKey,
                request: request);

            var __pathBuilder = new global::ElevenLabs.PathBuilder(
                path: $"/v1/convai/agents/{agentId}/simulate-conversation",
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

            if (xiApiKey != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("xi-api-key", xiApiKey.ToString());
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
            PrepareCreateConvaiAgentsByAgentIdSimulateConversationRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                agentId: agentId,
                xiApiKey: xiApiKey,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateConvaiAgentsByAgentIdSimulateConversationResponse(
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
                ProcessCreateConvaiAgentsByAgentIdSimulateConversationResponseContent(
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
                    global::ElevenLabs.AgentSimulatedChatTestResponseModel.FromJson(__content, JsonSerializerContext) ??
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
                    await global::ElevenLabs.AgentSimulatedChatTestResponseModel.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

        /// <summary>
        /// Simulates A Conversation<br/>
        /// Run a conversation between the agent and a simulated user.
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="simulationSpecification">
        /// A specification that will be used to simulate a conversation between an agent and an AI user.
        /// </param>
        /// <param name="extraEvaluationCriteria">
        /// A list of evaluation criteria to test
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::ElevenLabs.AgentSimulatedChatTestResponseModel> CreateConvaiAgentsByAgentIdSimulateConversationAsync(
            string agentId,
            global::ElevenLabs.ConversationSimulationSpecification simulationSpecification,
            string? xiApiKey = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.PromptEvaluationCriteria>? extraEvaluationCriteria = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::ElevenLabs.BodySimulatesAConversationV1ConvaiAgentsAgentIdSimulateConversationPost
            {
                SimulationSpecification = simulationSpecification,
                ExtraEvaluationCriteria = extraEvaluationCriteria,
            };

            return await CreateConvaiAgentsByAgentIdSimulateConversationAsync(
                agentId: agentId,
                xiApiKey: xiApiKey,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}