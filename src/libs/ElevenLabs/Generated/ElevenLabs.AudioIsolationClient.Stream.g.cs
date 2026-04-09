
#nullable enable

namespace ElevenLabs
{
    public partial class AudioIsolationClient
    {


        private static readonly global::ElevenLabs.EndPointSecurityRequirement s_StreamSecurityRequirement0 =
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
        private static readonly global::ElevenLabs.EndPointSecurityRequirement[] s_StreamSecurityRequirements =
            new global::ElevenLabs.EndPointSecurityRequirement[]
            {                s_StreamSecurityRequirement0,
            };
        partial void PrepareStreamArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::ElevenLabs.BodyAudioIsolationStreamV1AudioIsolationStreamPost request);
        partial void PrepareStreamRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::ElevenLabs.BodyAudioIsolationStreamV1AudioIsolationStreamPost request);
        partial void ProcessStreamResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Audio Isolation Stream<br/>
        /// Removes background noise from audio and streams the result
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.IO.Stream> StreamAsync(

            global::ElevenLabs.BodyAudioIsolationStreamV1AudioIsolationStreamPost request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareStreamArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::ElevenLabs.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_StreamSecurityRequirements,
                operationName: "StreamAsync");

            var __pathBuilder = new global::ElevenLabs.PathBuilder(
                path: "/v1/audio-isolation/stream",
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
            var __contentAudio = new global::System.Net.Http.ByteArrayContent(request.Audio ?? global::System.Array.Empty<byte>());
            __httpRequestContent.Add(
                content: __contentAudio,
                name: "\"audio\"",
                fileName: request.Audioname != null ? $"\"{request.Audioname}\"" : string.Empty);
            if (__contentAudio.Headers.ContentDisposition != null)
            {
                __contentAudio.Headers.ContentDisposition.FileNameStar = null;
            }
            if (request.FileFormat != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.FileFormat}"),
                    name: "\"file_format\"");
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareStreamRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            try
            {

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessStreamResponse(
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

            try
            {
                __response.EnsureSuccessStatusCode();

                var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                return new global::ElevenLabs.ResponseStream(__response, __content);
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
            catch
            {
                __response.Dispose();
                throw;
            }
        }
        /// <summary>
        /// Audio Isolation Stream<br/>
        /// Removes background noise from audio and streams the result
        /// </summary>
        /// <param name="audio">
        /// The audio file from which vocals/speech will be isolated from.
        /// </param>
        /// <param name="audioname">
        /// The audio file from which vocals/speech will be isolated from.
        /// </param>
        /// <param name="fileFormat">
        /// The format of input audio. Options are 'pcm_s16le_16' or 'other' For `pcm_s16le_16`, the input audio must be 16-bit PCM at a 16kHz sample rate, single channel (mono), and little-endian byte order. Latency will be lower than with passing an encoded waveform.<br/>
        /// Default Value: other
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.IO.Stream> StreamAsync(
            byte[] audio,
            string audioname,
            global::ElevenLabs.BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat2? fileFormat = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::ElevenLabs.BodyAudioIsolationStreamV1AudioIsolationStreamPost
            {
                Audio = audio,
                Audioname = audioname,
                FileFormat = fileFormat,
            };

            return await StreamAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}