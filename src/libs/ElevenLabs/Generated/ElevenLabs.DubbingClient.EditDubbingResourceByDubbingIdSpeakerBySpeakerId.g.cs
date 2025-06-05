
#nullable enable

namespace ElevenLabs
{
    public partial class DubbingClient
    {
        partial void PrepareEditDubbingResourceByDubbingIdSpeakerBySpeakerIdArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string dubbingId,
            ref string speakerId,
            ref string? xiApiKey,
            global::ElevenLabs.BodyUpdateMetadataForASpeakerV1DubbingResourceDubbingIdSpeakerSpeakerIdPatch request);
        partial void PrepareEditDubbingResourceByDubbingIdSpeakerBySpeakerIdRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string dubbingId,
            string speakerId,
            string? xiApiKey,
            global::ElevenLabs.BodyUpdateMetadataForASpeakerV1DubbingResourceDubbingIdSpeakerSpeakerIdPatch request);
        partial void ProcessEditDubbingResourceByDubbingIdSpeakerBySpeakerIdResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessEditDubbingResourceByDubbingIdSpeakerBySpeakerIdResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Metadata For A Speaker<br/>
        /// Amend the metadata associated with a speaker, such as their voice. Both voice cloning and using voices from the ElevenLabs library are supported.
        /// </summary>
        /// <param name="dubbingId">
        /// ID of the dubbing project.
        /// </param>
        /// <param name="speakerId">
        /// ID of the speaker.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::ElevenLabs.SpeakerUpdatedResponse> EditDubbingResourceByDubbingIdSpeakerBySpeakerIdAsync(
            string dubbingId,
            string speakerId,
            global::ElevenLabs.BodyUpdateMetadataForASpeakerV1DubbingResourceDubbingIdSpeakerSpeakerIdPatch request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareEditDubbingResourceByDubbingIdSpeakerBySpeakerIdArguments(
                httpClient: HttpClient,
                dubbingId: ref dubbingId,
                speakerId: ref speakerId,
                xiApiKey: ref xiApiKey,
                request: request);

            var __pathBuilder = new global::ElevenLabs.PathBuilder(
                path: $"/v1/dubbing/resource/{dubbingId}/speaker/{speakerId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
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
            PrepareEditDubbingResourceByDubbingIdSpeakerBySpeakerIdRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                dubbingId: dubbingId,
                speakerId: speakerId,
                xiApiKey: xiApiKey,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessEditDubbingResourceByDubbingIdSpeakerBySpeakerIdResponse(
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
                ProcessEditDubbingResourceByDubbingIdSpeakerBySpeakerIdResponseContent(
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
                    global::ElevenLabs.SpeakerUpdatedResponse.FromJson(__content, JsonSerializerContext) ??
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
                    await global::ElevenLabs.SpeakerUpdatedResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

        /// <summary>
        /// Update Metadata For A Speaker<br/>
        /// Amend the metadata associated with a speaker, such as their voice. Both voice cloning and using voices from the ElevenLabs library are supported.
        /// </summary>
        /// <param name="dubbingId">
        /// ID of the dubbing project.
        /// </param>
        /// <param name="speakerId">
        /// ID of the speaker.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="voiceId">
        /// Either the identifier of a voice from the ElevenLabs voice library, or one of ['track-clone', 'clip-clone'].
        /// </param>
        /// <param name="languages">
        /// Languages to apply these changes to. If empty, will apply to all languages.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::ElevenLabs.SpeakerUpdatedResponse> EditDubbingResourceByDubbingIdSpeakerBySpeakerIdAsync(
            string dubbingId,
            string speakerId,
            string? xiApiKey = default,
            string? voiceId = default,
            global::System.Collections.Generic.IList<string>? languages = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::ElevenLabs.BodyUpdateMetadataForASpeakerV1DubbingResourceDubbingIdSpeakerSpeakerIdPatch
            {
                VoiceId = voiceId,
                Languages = languages,
            };

            return await EditDubbingResourceByDubbingIdSpeakerBySpeakerIdAsync(
                dubbingId: dubbingId,
                speakerId: speakerId,
                xiApiKey: xiApiKey,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}