
#nullable enable

namespace ElevenLabs
{
    public partial class WorkspaceClient
    {
        partial void PrepareCreateWorkspaceResourcesByResourceIdShareArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string resourceId,
            ref string? xiApiKey,
            global::ElevenLabs.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePost request);
        partial void PrepareCreateWorkspaceResourcesByResourceIdShareRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string resourceId,
            string? xiApiKey,
            global::ElevenLabs.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePost request);
        partial void ProcessCreateWorkspaceResourcesByResourceIdShareResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateWorkspaceResourcesByResourceIdShareResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Share Workspace Resource<br/>
        /// Grants a role on a workspace resource to a user or a group. It overrides any existing role this user/service account/group/workspace api key has on the resource. To target a user or service account, pass only the user email. The user must be in your workspace. To target a group, pass only the group id. To target a workspace api key, pass the api key id. The resource will be shared with the service account associated with the api key. You must have admin access to the resource to share it.
        /// </summary>
        /// <param name="resourceId">
        /// The ID of the target resource.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<string> CreateWorkspaceResourcesByResourceIdShareAsync(
            string resourceId,
            global::ElevenLabs.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateWorkspaceResourcesByResourceIdShareArguments(
                httpClient: HttpClient,
                resourceId: ref resourceId,
                xiApiKey: ref xiApiKey,
                request: request);

            var __pathBuilder = new global::ElevenLabs.PathBuilder(
                path: $"/v1/workspace/resources/{resourceId}/share",
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
            PrepareCreateWorkspaceResourcesByResourceIdShareRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                resourceId: resourceId,
                xiApiKey: xiApiKey,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateWorkspaceResourcesByResourceIdShareResponse(
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
                ProcessCreateWorkspaceResourcesByResourceIdShareResponseContent(
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

                return __content;
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

                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                return __content;
            }
        }

        /// <summary>
        /// Share Workspace Resource<br/>
        /// Grants a role on a workspace resource to a user or a group. It overrides any existing role this user/service account/group/workspace api key has on the resource. To target a user or service account, pass only the user email. The user must be in your workspace. To target a group, pass only the group id. To target a workspace api key, pass the api key id. The resource will be shared with the service account associated with the api key. You must have admin access to the resource to share it.
        /// </summary>
        /// <param name="resourceId">
        /// The ID of the target resource.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="role">
        /// Role to update the target principal with.
        /// </param>
        /// <param name="resourceType">
        /// Resource types that can be shared in the workspace. The name always need to match the collection names
        /// </param>
        /// <param name="userEmail">
        /// The email of the user or service account.
        /// </param>
        /// <param name="groupId">
        /// The ID of the target group. To target the permissions principals have by default on this resource, use the value 'default'.
        /// </param>
        /// <param name="workspaceApiKeyId">
        /// The ID of the target workspace API key. This isn't the same as the key itself that would you pass in the header for authentication. Workspace admins can find this in the workspace settings UI.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> CreateWorkspaceResourcesByResourceIdShareAsync(
            string resourceId,
            global::ElevenLabs.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole role,
            global::ElevenLabs.WorkspaceResourceType resourceType,
            string? xiApiKey = default,
            string? userEmail = default,
            string? groupId = default,
            string? workspaceApiKeyId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::ElevenLabs.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePost
            {
                Role = role,
                ResourceType = resourceType,
                UserEmail = userEmail,
                GroupId = groupId,
                WorkspaceApiKeyId = workspaceApiKeyId,
            };

            return await CreateWorkspaceResourcesByResourceIdShareAsync(
                resourceId: resourceId,
                xiApiKey: xiApiKey,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}