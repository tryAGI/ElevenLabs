
#nullable enable

namespace ElevenLabs
{
    public partial class SpeechToTextClient
    {
        partial void PrepareCreateSpeechToTextArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref bool? enableLogging,
            ref string? xiApiKey,
            global::ElevenLabs.BodySpeechToTextV1SpeechToTextPost request);
        partial void PrepareCreateSpeechToTextRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            bool? enableLogging,
            string? xiApiKey,
            global::ElevenLabs.BodySpeechToTextV1SpeechToTextPost request);
        partial void ProcessCreateSpeechToTextResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateSpeechToTextResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Speech To Text<br/>
        /// Transcribe an audio or video file.
        /// </summary>
        /// <param name="enableLogging">
        /// When enable_logging is set to false zero retention mode will be used for the request. This will mean history features are unavailable for this request, including request stitching. Zero retention mode may only be used by enterprise customers.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::ElevenLabs.SpeechToTextChunkResponseModel> CreateSpeechToTextAsync(
            global::ElevenLabs.BodySpeechToTextV1SpeechToTextPost request,
            bool? enableLogging = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateSpeechToTextArguments(
                httpClient: HttpClient,
                enableLogging: ref enableLogging,
                xiApiKey: ref xiApiKey,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/v1/speech-to-text",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("enable_logging", enableLogging?.ToString()) 
                ; 
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

            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            if (enableLogging != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{enableLogging}"),
                    name: "enable_logging");
            } 
            if (xiApiKey != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{xiApiKey}"),
                    name: "xi-api-key");
            } 
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{request.ModelId}"),
                name: "model_id");
            __httpRequestContent.Add(
                content: new global::System.Net.Http.ByteArrayContent(request.File ?? global::System.Array.Empty<byte>()),
                name: "file",
                fileName: request.Filename ?? string.Empty);
            if (request.LanguageCode != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.LanguageCode}"),
                    name: "language_code");
            } 
            if (request.TagAudioEvents != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.TagAudioEvents}"),
                    name: "tag_audio_events");
            } 
            if (request.NumSpeakers != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.NumSpeakers}"),
                    name: "num_speakers");
            } 
            if (request.TimestampsGranularity != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.TimestampsGranularity?.ToValueString()}"),
                    name: "timestamps_granularity");
            } 
            if (request.Diarize != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Diarize}"),
                    name: "diarize");
            } 
            if (request.AdditionalFormats != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(request.AdditionalFormats, x => x))}]"),
                    name: "additional_formats");
            } 
            if (request.FileFormat != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.FileFormat?.ToValueString()}"),
                    name: "file_format");
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateSpeechToTextRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                enableLogging: enableLogging,
                xiApiKey: xiApiKey,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateSpeechToTextResponse(
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
                ProcessCreateSpeechToTextResponseContent(
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
                    global::ElevenLabs.SpeechToTextChunkResponseModel.FromJson(__content, JsonSerializerContext) ??
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
                    await global::ElevenLabs.SpeechToTextChunkResponseModel.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

        /// <summary>
        /// Speech To Text<br/>
        /// Transcribe an audio or video file.
        /// </summary>
        /// <param name="enableLogging">
        /// When enable_logging is set to false zero retention mode will be used for the request. This will mean history features are unavailable for this request, including request stitching. Zero retention mode may only be used by enterprise customers.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="modelId">
        /// The ID of the model to use for transcription, currently only 'scribe_v1' and 'scribe_v1_experimental' are available.
        /// </param>
        /// <param name="file">
        /// The file to transcribe. All major audio and video formats are supported. The file size must be less than 1GB.
        /// </param>
        /// <param name="filename">
        /// The file to transcribe. All major audio and video formats are supported. The file size must be less than 1GB.
        /// </param>
        /// <param name="languageCode">
        /// An ISO-639-1 or ISO-639-3 language_code corresponding to the language of the audio file. Can sometimes improve transcription performance if known beforehand. Defaults to null, in this case the language is predicted automatically.
        /// </param>
        /// <param name="tagAudioEvents">
        /// Whether to tag audio events like (laughter), (footsteps), etc. in the transcription.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="numSpeakers">
        /// The maximum amount of speakers talking in the uploaded file. Can help with predicting who speaks when. The maximum amount of speakers that can be predicted is 32. Defaults to null, in this case the amount of speakers is set to the maximum value the model supports.
        /// </param>
        /// <param name="timestampsGranularity">
        /// The granularity of the timestamps in the transcription. 'word' provides word-level timestamps and 'character' provides character-level timestamps per word.<br/>
        /// Default Value: word
        /// </param>
        /// <param name="diarize">
        /// Whether to annotate which speaker is currently talking in the uploaded file.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="additionalFormats"></param>
        /// <param name="fileFormat">
        /// The format of input audio. Options are 'pcm_s16le_16' or 'other' For `pcm_s16le_16`, the input audio must be 16-bit PCM at a 16kHz sample rate, single channel (mono), and little-endian byte order. Latency will be lower than with passing an encoded waveform.<br/>
        /// Default Value: other<br/>
        /// Example: pcm_s16le_16
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::ElevenLabs.SpeechToTextChunkResponseModel> CreateSpeechToTextAsync(
            string modelId,
            byte[] file,
            string filename,
            bool? enableLogging = default,
            string? xiApiKey = default,
            string? languageCode = default,
            bool? tagAudioEvents = default,
            int? numSpeakers = default,
            global::ElevenLabs.BodySpeechToTextV1SpeechToTextPostTimestampsGranularity? timestampsGranularity = default,
            bool? diarize = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.ExportOptions>? additionalFormats = default,
            global::ElevenLabs.BodySpeechToTextV1SpeechToTextPostFileFormat? fileFormat = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::ElevenLabs.BodySpeechToTextV1SpeechToTextPost
            {
                ModelId = modelId,
                File = file,
                Filename = filename,
                LanguageCode = languageCode,
                TagAudioEvents = tagAudioEvents,
                NumSpeakers = numSpeakers,
                TimestampsGranularity = timestampsGranularity,
                Diarize = diarize,
                AdditionalFormats = additionalFormats,
                FileFormat = fileFormat,
            };

            return await CreateSpeechToTextAsync(
                enableLogging: enableLogging,
                xiApiKey: xiApiKey,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}