
#nullable enable

namespace ElevenLabs
{
    public partial class VoicesClient
    {


        private static readonly global::ElevenLabs.EndPointSecurityRequirement s_Update2SecurityRequirement0 =
            new global::ElevenLabs.EndPointSecurityRequirement
            {
                Authorizations = new global::ElevenLabs.EndPointAuthorizationRequirement[]
                {                    new global::ElevenLabs.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        Location = "Header",
                        Name = "xi-api-key",
                        FriendlyName = "ApiKeyInHeader",
                    },
                },
            };
        private static readonly global::ElevenLabs.EndPointSecurityRequirement[] s_Update2SecurityRequirements =
            new global::ElevenLabs.EndPointSecurityRequirement[]
            {                s_Update2SecurityRequirement0,
            };
        partial void PrepareUpdate2Arguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string voiceId,
            global::ElevenLabs.BodyEditVoiceV1VoicesVoiceIdEditPost request);
        partial void PrepareUpdate2Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string voiceId,
            global::ElevenLabs.BodyEditVoiceV1VoicesVoiceIdEditPost request);
        partial void ProcessUpdate2Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdate2ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Edit Voice<br/>
        /// Edit a voice created by you.
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::ElevenLabs.EditVoiceResponseModel> Update2Async(
            string voiceId,

            global::ElevenLabs.BodyEditVoiceV1VoicesVoiceIdEditPost request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUpdate2Arguments(
                httpClient: HttpClient,
                voiceId: ref voiceId,
                request: request);


            var __authorizations = global::ElevenLabs.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_Update2SecurityRequirements,
                operationName: "Update2Async");

            var __pathBuilder = new global::ElevenLabs.PathBuilder(
                path: $"/v1/voices/{voiceId}/edit",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
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
            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{voiceId}"),
                name: "\"voice_id\"");
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{request.Name}"),
                name: "\"name\"");
            if (request.Files != default)
            {

                for (var __iFiles = 0; __iFiles < request.Files.Count; __iFiles++)
                {
                    var __contentFiles = new global::System.Net.Http.ByteArrayContent(request.Files[__iFiles]);
                    __httpRequestContent.Add(
                        content: __contentFiles,
                        name: "\"files\"",
                        fileName: $"\"file{__iFiles}.bin\"");
                    if (__contentFiles.Headers.ContentDisposition != null)
                    {
                        __contentFiles.Headers.ContentDisposition.FileNameStar = null;
                    }
                }
            } 
            if (request.RemoveBackgroundNoise != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.RemoveBackgroundNoise}"),
                    name: "\"remove_background_noise\"");
            } 
            if (request.Description != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Description}"),
                    name: "\"description\"");
            } 
            if (request.Labels != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent(request.Labels?.ToString() ?? string.Empty),
                    name: "\"labels\"");
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareUpdate2Request(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                voiceId: voiceId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUpdate2Response(
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
                ProcessUpdate2ResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::ElevenLabs.EditVoiceResponseModel.FromJson(__content, JsonSerializerContext) ??
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
                        await global::ElevenLabs.EditVoiceResponseModel.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Edit Voice<br/>
        /// Edit a voice created by you.
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.
        /// </param>
        /// <param name="name">
        /// The name that identifies this voice. This will be displayed in the dropdown of the website.
        /// </param>
        /// <param name="files">
        /// Audio files to add to the voice
        /// </param>
        /// <param name="removeBackgroundNoise">
        /// If set will remove background noise for voice samples using our audio isolation model. If the samples do not include background noise, it can make the quality worse.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="description">
        /// A description of the voice.
        /// </param>
        /// <param name="labels">
        /// Labels for the voice. Keys can be language, accent, gender, or age.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::ElevenLabs.EditVoiceResponseModel> Update2Async(
            string voiceId,
            string name,
            global::System.Collections.Generic.IList<byte[]>? files = default,
            bool? removeBackgroundNoise = default,
            string? description = default,
            global::ElevenLabs.AnyOf<global::System.Collections.Generic.Dictionary<string, string>, string, object>? labels = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::ElevenLabs.BodyEditVoiceV1VoicesVoiceIdEditPost
            {
                Name = name,
                Files = files,
                RemoveBackgroundNoise = removeBackgroundNoise,
                Description = description,
                Labels = labels,
            };

            return await Update2Async(
                voiceId: voiceId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}