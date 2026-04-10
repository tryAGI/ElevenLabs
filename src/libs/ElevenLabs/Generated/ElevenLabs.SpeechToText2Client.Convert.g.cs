
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs
{
    public partial class SpeechToText2Client
    {


        private static readonly global::ElevenLabs.EndPointSecurityRequirement s_ConvertSecurityRequirement0 =
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
        private static readonly global::ElevenLabs.EndPointSecurityRequirement[] s_ConvertSecurityRequirements =
            new global::ElevenLabs.EndPointSecurityRequirement[]
            {                s_ConvertSecurityRequirement0,
            };
        partial void PrepareConvertArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref bool? enableLogging,
            global::ElevenLabs.BodySpeechToTextV1SpeechToTextPost request);
        partial void PrepareConvertRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            bool? enableLogging,
            global::ElevenLabs.BodySpeechToTextV1SpeechToTextPost request);
        partial void ProcessConvertResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessConvertResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Speech To Text<br/>
        /// Transcribe an audio or video file. If webhook is set to true, the request will be processed asynchronously and results sent to configured webhooks. When use_multi_channel is true and the provided audio has multiple channels, a 'transcripts' object with separate transcripts for each channel is returned. Otherwise, returns a single transcript. The optional webhook_metadata parameter allows you to attach custom data that will be included in webhook responses for request correlation and tracking.
        /// </summary>
        /// <param name="enableLogging">
        /// When enable_logging is set to false zero retention mode will be used for the request. This will mean log and transcript storage features are unavailable for this request. Zero retention mode may only be used by enterprise customers.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::ElevenLabs.AnyOf<global::ElevenLabs.SpeechToTextChunkResponseModel, global::ElevenLabs.MultichannelSpeechToTextResponseModel, global::ElevenLabs.SpeechToTextWebhookResponseModel>> ConvertAsync(

            global::ElevenLabs.BodySpeechToTextV1SpeechToTextPost request,
            bool? enableLogging = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareConvertArguments(
                httpClient: HttpClient,
                enableLogging: ref enableLogging,
                request: request);


            var __authorizations = global::ElevenLabs.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ConvertSecurityRequirements,
                operationName: "ConvertAsync");

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
                                path: "/v1/speech-to-text",
                                baseUri: HttpClient.BaseAddress); 
                            __pathBuilder
                                .AddOptionalParameter("enable_logging", enableLogging?.ToString().ToLowerInvariant()) 
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::ElevenLabs.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
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
                            var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
                            if (enableLogging != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{enableLogging}"),
                                    name: "\"enable_logging\"");
                            }
                            __httpRequestContent.Add(
                                content: new global::System.Net.Http.StringContent($"{request.ModelId.ToValueString()}"),
                                name: "\"model_id\"");
                            if (request.File != default)
                            {

                                var __contentFile = new global::System.Net.Http.ByteArrayContent(request.File ?? global::System.Array.Empty<byte>());
                                __httpRequestContent.Add(
                                    content: __contentFile,
                                    name: "\"file\"",
                                    fileName: request.Filename != null ? $"\"{request.Filename}\"" : string.Empty);
                                if (__contentFile.Headers.ContentDisposition != null)
                                {
                                    __contentFile.Headers.ContentDisposition.FileNameStar = null;
                                }
                            } 
                            if (request.LanguageCode != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.LanguageCode}"),
                                    name: "\"language_code\"");
                            } 
                            if (request.TagAudioEvents != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.TagAudioEvents}"),
                                    name: "\"tag_audio_events\"");
                            } 
                            if (request.NumSpeakers != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.NumSpeakers}"),
                                    name: "\"num_speakers\"");
                            } 
                            if (request.TimestampsGranularity != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.TimestampsGranularity?.ToValueString()}"),
                                    name: "\"timestamps_granularity\"");
                            } 
                            if (request.Diarize != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.Diarize}"),
                                    name: "\"diarize\"");
                            } 
                            if (request.DiarizationThreshold != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.DiarizationThreshold}"),
                                    name: "\"diarization_threshold\"");
                            } 
                            if (request.AdditionalFormats != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(request.AdditionalFormats, x => x))}]"),
                                    name: "\"additional_formats\"");
                            } 
                            if (request.FileFormat != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.FileFormat?.ToValueString()}"),
                                    name: "\"file_format\"");
                            } 
                            if (request.CloudStorageUrl != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.CloudStorageUrl}"),
                                    name: "\"cloud_storage_url\"");
                            } 
                            if (request.SourceUrl != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.SourceUrl}"),
                                    name: "\"source_url\"");
                            } 
                            if (request.Webhook != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.Webhook}"),
                                    name: "\"webhook\"");
                            } 
                            if (request.WebhookId != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.WebhookId}"),
                                    name: "\"webhook_id\"");
                            } 
                            if (request.Temperature != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.Temperature}"),
                                    name: "\"temperature\"");
                            } 
                            if (request.Seed != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.Seed}"),
                                    name: "\"seed\"");
                            } 
                            if (request.UseMultiChannel != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.UseMultiChannel}"),
                                    name: "\"use_multi_channel\"");
                            } 
                            if (request.WebhookMetadata != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.WebhookMetadata?.ToString() ?? string.Empty),
                                    name: "\"webhook_metadata\"");
                            } 
                            if (request.EntityDetection != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.EntityDetection?.ToString() ?? string.Empty),
                                    name: "\"entity_detection\"");
                            } 
                            if (request.NoVerbatim != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.NoVerbatim}"),
                                    name: "\"no_verbatim\"");
                            } 
                            if (request.EntityRedaction != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.EntityRedaction?.ToString() ?? string.Empty),
                                    name: "\"entity_redaction\"");
                            } 
                            if (request.EntityRedactionMode != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"{request.EntityRedactionMode}"),
                                    name: "\"entity_redaction_mode\"");
                            } 
                            if (request.Keyterms != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(request.Keyterms, x => x))}]"),
                                    name: "\"keyterms\"");
                            }
                            __httpRequest.Content = __httpRequestContent;
                global::ElevenLabs.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareConvertRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    enableLogging: enableLogging,
                    request: request);

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
                                operationId: "Convert",
                                methodName: "ConvertAsync",
                                pathTemplate: "\"/v1/speech-to-text\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
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
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::ElevenLabs.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::ElevenLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Convert",
                                methodName: "ConvertAsync",
                                pathTemplate: "\"/v1/speech-to-text\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::ElevenLabs.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::ElevenLabs.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::ElevenLabs.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::ElevenLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Convert",
                                methodName: "ConvertAsync",
                                pathTemplate: "\"/v1/speech-to-text\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::ElevenLabs.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
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
                ProcessConvertResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::ElevenLabs.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::ElevenLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Convert",
                                methodName: "ConvertAsync",
                                pathTemplate: "\"/v1/speech-to-text\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::ElevenLabs.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::ElevenLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Convert",
                                methodName: "ConvertAsync",
                                pathTemplate: "\"/v1/speech-to-text\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
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
                                ProcessConvertResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::ElevenLabs.AnyOf<global::ElevenLabs.SpeechToTextChunkResponseModel, global::ElevenLabs.MultichannelSpeechToTextResponseModel, global::ElevenLabs.SpeechToTextWebhookResponseModel>.FromJson(__content, JsonSerializerContext) ??
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
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    return
                                        await global::ElevenLabs.AnyOf<global::ElevenLabs.SpeechToTextChunkResponseModel, global::ElevenLabs.MultichannelSpeechToTextResponseModel, global::ElevenLabs.SpeechToTextWebhookResponseModel>.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
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
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Speech To Text<br/>
        /// Transcribe an audio or video file. If webhook is set to true, the request will be processed asynchronously and results sent to configured webhooks. When use_multi_channel is true and the provided audio has multiple channels, a 'transcripts' object with separate transcripts for each channel is returned. Otherwise, returns a single transcript. The optional webhook_metadata parameter allows you to attach custom data that will be included in webhook responses for request correlation and tracking.
        /// </summary>
        /// <param name="enableLogging">
        /// When enable_logging is set to false zero retention mode will be used for the request. This will mean log and transcript storage features are unavailable for this request. Zero retention mode may only be used by enterprise customers.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="modelId">
        /// The ID of the model to use for transcription.
        /// </param>
        /// <param name="file">
        /// The file to transcribe (100ms minimum audio length). All major audio and video formats are supported. Exactly one of the file or cloud_storage_url parameters must be provided. The file size must be less than 3.0GB.
        /// </param>
        /// <param name="filename">
        /// The file to transcribe (100ms minimum audio length). All major audio and video formats are supported. Exactly one of the file or cloud_storage_url parameters must be provided. The file size must be less than 3.0GB.
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
        /// <param name="diarizationThreshold">
        /// Diarization threshold to apply during speaker diarization. A higher value means there will be a lower chance of one speaker being diarized as two different speakers but also a higher chance of two different speakers being diarized as one speaker (less total speakers predicted). A low value means there will be a higher chance of one speaker being diarized as two different speakers but also a lower chance of two different speakers being diarized as one speaker (more total speakers predicted). Can only be set when diarize=True and num_speakers=None. Defaults to None, in which case we will choose a threshold based on the model_id (0.22 usually).
        /// </param>
        /// <param name="additionalFormats">
        /// A list of additional formats to export the transcript to.
        /// </param>
        /// <param name="fileFormat">
        /// The format of input audio. Options are 'pcm_s16le_16' or 'other' For `pcm_s16le_16`, the input audio must be 16-bit PCM at a 16kHz sample rate, single channel (mono), and little-endian byte order. Latency will be lower than with passing an encoded waveform.<br/>
        /// Default Value: other
        /// </param>
        /// <param name="sourceUrl">
        /// The URL of an audio or video file to transcribe. Supports hosted video or audio files, YouTube video URLs, TikTok video URLs, and other video hosting services.
        /// </param>
        /// <param name="webhook">
        /// Whether to send the transcription result to configured speech-to-text webhooks.  If set the request will return early without the transcription, which will be delivered later via webhook.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="webhookId">
        /// Optional specific webhook ID to send the transcription result to. Only valid when webhook is set to true. If not provided, transcription will be sent to all configured speech-to-text webhooks.
        /// </param>
        /// <param name="temperature">
        /// Controls the randomness of the transcription output. Accepts values between 0.0 and 2.0, where higher values result in more diverse and less deterministic results. If omitted, we will use a temperature based on the model you selected which is usually 0.
        /// </param>
        /// <param name="seed">
        /// If specified, our system will make a best effort to sample deterministically, such that repeated requests with the same seed and parameters should return the same result. Determinism is not guaranteed. Must be an integer between 0 and 2147483647.
        /// </param>
        /// <param name="useMultiChannel">
        /// Whether the audio file contains multiple channels where each channel contains a single speaker. When enabled, each channel will be transcribed independently and the results will be combined. Each word in the response will include a 'channel_index' field indicating which channel it was spoken on. A maximum of 5 channels is supported. Each channel is billed independently at the full audio duration, so cost scales linearly with the number of channels.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="webhookMetadata">
        /// Optional metadata to be included in the webhook response. This should be a JSON string representing an object with a maximum depth of 2 levels and maximum size of 16KB. Useful for tracking internal IDs, job references, or other contextual information.
        /// </param>
        /// <param name="entityDetection">
        /// Detect entities in the transcript. Can be 'all' to detect all entities, a single entity type or category string, or a list of entity types/categories. Categories include 'pii', 'phi', 'pci', 'other', 'offensive_language'. When enabled, detected entities will be returned in the 'entities' field with their text, type, and character positions. Usage of this parameter will incur an additional 30% surcharge on the base transcription cost.
        /// </param>
        /// <param name="noVerbatim">
        /// If true, the transcription will not have any filler words, false starts and non-speech sounds. Only supported with scribe_v2 model.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="entityRedaction">
        /// Redact entities from the transcript text. Accepts the same format as entity_detection: 'all', a category ('pii', 'phi'), or specific entity types. Must be a subset of entity_detection. When redaction is enabled, the entities field will not be returned. Usage of this parameter will incur an additional 30% surcharge on the base transcription cost.
        /// </param>
        /// <param name="entityRedactionMode">
        /// How to format redacted entities. 'redacted' replaces with {REDACTED}, 'entity_type' replaces with {ENTITY_TYPE}, 'enumerated_entity_type' replaces with {ENTITY_TYPE_N} where N enumerates each occurrence. Only used when entity_redaction is set.<br/>
        /// Default Value: enumerated_entity_type
        /// </param>
        /// <param name="keyterms">
        /// A list of keyterms to bias the transcription towards.           The keyterms are words or phrases you want the model to recognise more accurately.           The number of keyterms cannot exceed 1000.           The length of each keyterm must be less than 50 characters.           Keyterms can contain at most 5 words (after normalisation).           For example ["hello", "world", "technical term"].           Usage of this parameter will incur an additional 20% surcharge on the base transcription cost.           When more than 100 keyterms are provided, a minimum billable duration of 20 seconds applies per request.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::ElevenLabs.AnyOf<global::ElevenLabs.SpeechToTextChunkResponseModel, global::ElevenLabs.MultichannelSpeechToTextResponseModel, global::ElevenLabs.SpeechToTextWebhookResponseModel>> ConvertAsync(
            global::ElevenLabs.BodySpeechToTextV1SpeechToTextPostModelId modelId,
            bool? enableLogging = default,
            byte[]? file = default,
            string? filename = default,
            string? languageCode = default,
            bool? tagAudioEvents = default,
            int? numSpeakers = default,
            global::ElevenLabs.BodySpeechToTextV1SpeechToTextPostTimestampsGranularity? timestampsGranularity = default,
            bool? diarize = default,
            double? diarizationThreshold = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.ExportOptions>? additionalFormats = default,
            global::ElevenLabs.BodySpeechToTextV1SpeechToTextPostFileFormat? fileFormat = default,
            string? sourceUrl = default,
            bool? webhook = default,
            string? webhookId = default,
            double? temperature = default,
            int? seed = default,
            bool? useMultiChannel = default,
            global::ElevenLabs.AnyOf<string, object, object>? webhookMetadata = default,
            global::ElevenLabs.AnyOf<string, global::System.Collections.Generic.IList<string>, object>? entityDetection = default,
            bool? noVerbatim = default,
            global::ElevenLabs.AnyOf<string, global::System.Collections.Generic.IList<string>, object>? entityRedaction = default,
            string? entityRedactionMode = default,
            global::System.Collections.Generic.IList<string>? keyterms = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
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
                DiarizationThreshold = diarizationThreshold,
                AdditionalFormats = additionalFormats,
                FileFormat = fileFormat,
                SourceUrl = sourceUrl,
                Webhook = webhook,
                WebhookId = webhookId,
                Temperature = temperature,
                Seed = seed,
                UseMultiChannel = useMultiChannel,
                WebhookMetadata = webhookMetadata,
                EntityDetection = entityDetection,
                NoVerbatim = noVerbatim,
                EntityRedaction = entityRedaction,
                EntityRedactionMode = entityRedactionMode,
                Keyterms = keyterms,
            };

            return await ConvertAsync(
                enableLogging: enableLogging,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}