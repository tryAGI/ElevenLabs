
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs
{
    public partial class TextToSpeechClient
    {
        partial void PrepareCreateTextToSpeechByVoiceIdStreamWithTimestampsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string voiceId,
            ref bool? enableLogging,
            ref int? optimizeStreamingLatency,
            ref global::ElevenLabs.TextToSpeechStreamingWithTimestampsV1TextToSpeechVoiceIdStreamWithTimestampsPostOutputFormat? outputFormat,
            ref string? xiApiKey,
            global::ElevenLabs.BodyTextToSpeechStreamingWithTimestampsV1TextToSpeechVoiceIdStreamWithTimestampsPost request);
        partial void PrepareCreateTextToSpeechByVoiceIdStreamWithTimestampsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string voiceId,
            bool? enableLogging,
            int? optimizeStreamingLatency,
            global::ElevenLabs.TextToSpeechStreamingWithTimestampsV1TextToSpeechVoiceIdStreamWithTimestampsPostOutputFormat? outputFormat,
            string? xiApiKey,
            global::ElevenLabs.BodyTextToSpeechStreamingWithTimestampsV1TextToSpeechVoiceIdStreamWithTimestampsPost request);
        partial void ProcessCreateTextToSpeechByVoiceIdStreamWithTimestampsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateTextToSpeechByVoiceIdStreamWithTimestampsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Text To Speech Streaming With Timestamps<br/>
        /// Converts text into speech using a voice of your choice and returns a stream of JSONs containing audio as a base64 encoded string together with information on when which character was spoken.
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="enableLogging">
        /// When enable_logging is set to false zero retention mode will be used for the request. This will mean history features are unavailable for this request, including request stitching. Zero retention mode may only be used by enterprise customers.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="optimizeStreamingLatency">
        /// You can turn on latency optimizations at some cost of quality. The best possible final latency varies by model. Possible values:<br/>
        /// 0 - default mode (no latency optimizations)<br/>
        /// 1 - normal latency optimizations (about 50% of possible latency improvement of option 3)<br/>
        /// 2 - strong latency optimizations (about 75% of possible latency improvement of option 3)<br/>
        /// 3 - max latency optimizations<br/>
        /// 4 - max latency optimizations, but also with text normalizer turned off for even more latency savings (best latency, but can mispronounce eg numbers and dates).<br/>
        /// Defaults to None.
        /// </param>
        /// <param name="outputFormat">
        /// Output format of the generated audio. Formatted as codec_sample_rate_bitrate. So an mp3 with 22.05kHz sample rate at 32kbs is represented as mp3_22050_32. MP3 with 192kbps bitrate requires you to be subscribed to Creator tier or above. PCM with 44.1kHz sample rate requires you to be subscribed to Pro tier or above. Note that the μ-law format (sometimes written mu-law, often approximated as u-law) is commonly used for Twilio audio inputs.<br/>
        /// Default Value: mp3_44100_128
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::ElevenLabs.StreamingAudioChunkWithTimestampsResponseModel> CreateTextToSpeechByVoiceIdStreamWithTimestampsAsync(
            string voiceId,
            global::ElevenLabs.BodyTextToSpeechStreamingWithTimestampsV1TextToSpeechVoiceIdStreamWithTimestampsPost request,
            bool? enableLogging = default,
            int? optimizeStreamingLatency = default,
            global::ElevenLabs.TextToSpeechStreamingWithTimestampsV1TextToSpeechVoiceIdStreamWithTimestampsPostOutputFormat? outputFormat = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateTextToSpeechByVoiceIdStreamWithTimestampsArguments(
                httpClient: HttpClient,
                voiceId: ref voiceId,
                enableLogging: ref enableLogging,
                optimizeStreamingLatency: ref optimizeStreamingLatency,
                outputFormat: ref outputFormat,
                xiApiKey: ref xiApiKey,
                request: request);

            var __pathBuilder = new global::ElevenLabs.PathBuilder(
                path: $"/v1/text-to-speech/{voiceId}/stream/with-timestamps",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("enable_logging", enableLogging?.ToString()) 
                .AddOptionalParameter("optimize_streaming_latency", optimizeStreamingLatency?.ToString()) 
                .AddOptionalParameter("output_format", outputFormat?.ToValueString()) 
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

            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateTextToSpeechByVoiceIdStreamWithTimestampsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                voiceId: voiceId,
                enableLogging: enableLogging,
                optimizeStreamingLatency: optimizeStreamingLatency,
                outputFormat: outputFormat,
                xiApiKey: xiApiKey,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateTextToSpeechByVoiceIdStreamWithTimestampsResponse(
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
                        var __contentStream_422 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = await global::ElevenLabs.HTTPValidationError.FromJsonStreamAsync(__contentStream_422, JsonSerializerContext).ConfigureAwait(false);
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
                ProcessCreateTextToSpeechByVoiceIdStreamWithTimestampsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::ElevenLabs.StreamingAudioChunkWithTimestampsResponseModel.FromJson(__content, JsonSerializerContext) ??
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
                        await global::ElevenLabs.StreamingAudioChunkWithTimestampsResponseModel.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
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
            }
        }

        /// <summary>
        /// Text To Speech Streaming With Timestamps<br/>
        /// Converts text into speech using a voice of your choice and returns a stream of JSONs containing audio as a base64 encoded string together with information on when which character was spoken.
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="enableLogging">
        /// When enable_logging is set to false zero retention mode will be used for the request. This will mean history features are unavailable for this request, including request stitching. Zero retention mode may only be used by enterprise customers.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="optimizeStreamingLatency">
        /// You can turn on latency optimizations at some cost of quality. The best possible final latency varies by model. Possible values:<br/>
        /// 0 - default mode (no latency optimizations)<br/>
        /// 1 - normal latency optimizations (about 50% of possible latency improvement of option 3)<br/>
        /// 2 - strong latency optimizations (about 75% of possible latency improvement of option 3)<br/>
        /// 3 - max latency optimizations<br/>
        /// 4 - max latency optimizations, but also with text normalizer turned off for even more latency savings (best latency, but can mispronounce eg numbers and dates).<br/>
        /// Defaults to None.
        /// </param>
        /// <param name="outputFormat">
        /// Output format of the generated audio. Formatted as codec_sample_rate_bitrate. So an mp3 with 22.05kHz sample rate at 32kbs is represented as mp3_22050_32. MP3 with 192kbps bitrate requires you to be subscribed to Creator tier or above. PCM with 44.1kHz sample rate requires you to be subscribed to Pro tier or above. Note that the μ-law format (sometimes written mu-law, often approximated as u-law) is commonly used for Twilio audio inputs.<br/>
        /// Default Value: mp3_44100_128
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="text">
        /// The text that will get converted into speech.<br/>
        /// Example: This is a test for the API of ElevenLabs.
        /// </param>
        /// <param name="modelId">
        /// Identifier of the model that will be used, you can query them using GET /v1/models. The model needs to have support for text to speech, you can check this using the can_do_text_to_speech property.<br/>
        /// Default Value: eleven_multilingual_v2
        /// </param>
        /// <param name="languageCode">
        /// Language code (ISO 639-1) used to enforce a language for the model. Currently only Turbo v2.5 and Flash v2.5 support language enforcement. For other models, an error will be returned if language code is provided.
        /// </param>
        /// <param name="voiceSettings"></param>
        /// <param name="pronunciationDictionaryLocators">
        /// A list of pronunciation dictionary locators (id, version_id) to be applied to the text. They will be applied in order. You may have up to 3 locators per request<br/>
        /// Example: []
        /// </param>
        /// <param name="seed">
        /// If specified, our system will make a best effort to sample deterministically, such that repeated requests with the same seed and parameters should return the same result. Determinism is not guaranteed. Must be integer between 0 and 4294967295.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="previousText">
        /// The text that came before the text of the current request. Can be used to improve the speech's continuity when concatenating together multiple generations or to influence the speech's continuity in the current generation.<br/>
        /// Example: In the heart of a lush valley surrounded by towering mountains lies the quaint village of Willowbrook.
        /// </param>
        /// <param name="nextText">
        /// The text that comes after the text of the current request. Can be used to improve the speech's continuity when concatenating together multiple generations or to influence the speech's continuity in the current generation.<br/>
        /// Example: The Willowbrook Festival, held every spring, celebrates the blossoming of the wild bluebells that carpet the nearby forest floors, creating a breathtaking sea of blue under the canopy of fresh green leaves.
        /// </param>
        /// <param name="previousRequestIds">
        /// A list of request_id of the samples that were generated before this generation. Can be used to improve the speech's continuity when splitting up a large task into multiple requests. The results will be best when the same model is used across the generations. In case both previous_text and previous_request_ids is send, previous_text will be ignored. A maximum of 3 request_ids can be send.<br/>
        /// Example: [09bOJkdYVjKy2oOiiVtR, 0p2uKqOnZyce22SPZ9d5, 1KYvY8WZAKmcjCJ1mvVB]
        /// </param>
        /// <param name="nextRequestIds">
        /// A list of request_id of the samples that come after this generation. next_request_ids is especially useful for maintaining the speech's continuity when regenerating a sample that has had some audio quality issues. For example, if you have generated 3 speech clips, and you want to improve clip 2, passing the request id of clip 3 as a next_request_id (and that of clip 1 as a previous_request_id) will help maintain natural flow in the combined speech. The results will be best when the same model is used across the generations. In case both next_text and next_request_ids is send, next_text will be ignored. A maximum of 3 request_ids can be send.<br/>
        /// Example: [3tPgBrD1UdW3snUkGw1K, 4D1jAxiRFkolBNUGzXkU, 4c8Z4aWliVR2oipYRXhj]
        /// </param>
        /// <param name="applyTextNormalization">
        /// This parameter controls text normalization with three modes: 'auto', 'on', and 'off'. When set to 'auto', the system will automatically decide whether to apply text normalization (e.g., spelling out numbers). With 'on', text normalization will always be applied, while with 'off', it will be skipped. Cannot be turned on for 'eleven_turbo_v2_5' or 'eleven_flash_v2_5' models.<br/>
        /// Default Value: auto<br/>
        /// Example: true
        /// </param>
        /// <param name="applyLanguageTextNormalization">
        /// This parameter controls language text normalization. This helps with proper pronunciation of text in some supported languages. WARNING: This parameter can heavily increase the latency of the request. Currently only supported for Japanese.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::ElevenLabs.StreamingAudioChunkWithTimestampsResponseModel> CreateTextToSpeechByVoiceIdStreamWithTimestampsAsync(
            string voiceId,
            string text,
            bool? enableLogging = default,
            int? optimizeStreamingLatency = default,
            global::ElevenLabs.TextToSpeechStreamingWithTimestampsV1TextToSpeechVoiceIdStreamWithTimestampsPostOutputFormat? outputFormat = default,
            string? xiApiKey = default,
            string? modelId = default,
            string? languageCode = default,
            global::ElevenLabs.VoiceSettingsResponseModel? voiceSettings = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.PronunciationDictionaryVersionLocatorRequestModel>? pronunciationDictionaryLocators = default,
            int? seed = default,
            string? previousText = default,
            string? nextText = default,
            global::System.Collections.Generic.IList<string>? previousRequestIds = default,
            global::System.Collections.Generic.IList<string>? nextRequestIds = default,
            global::ElevenLabs.BodyTextToSpeechStreamingWithTimestampsV1TextToSpeechVoiceIdStreamWithTimestampsPostApplyTextNormalization? applyTextNormalization = default,
            bool? applyLanguageTextNormalization = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::ElevenLabs.BodyTextToSpeechStreamingWithTimestampsV1TextToSpeechVoiceIdStreamWithTimestampsPost
            {
                Text = text,
                ModelId = modelId,
                LanguageCode = languageCode,
                VoiceSettings = voiceSettings,
                PronunciationDictionaryLocators = pronunciationDictionaryLocators,
                Seed = seed,
                PreviousText = previousText,
                NextText = nextText,
                PreviousRequestIds = previousRequestIds,
                NextRequestIds = nextRequestIds,
                ApplyTextNormalization = applyTextNormalization,
                ApplyLanguageTextNormalization = applyLanguageTextNormalization,
            };

            return await CreateTextToSpeechByVoiceIdStreamWithTimestampsAsync(
                voiceId: voiceId,
                enableLogging: enableLogging,
                optimizeStreamingLatency: optimizeStreamingLatency,
                outputFormat: outputFormat,
                xiApiKey: xiApiKey,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}