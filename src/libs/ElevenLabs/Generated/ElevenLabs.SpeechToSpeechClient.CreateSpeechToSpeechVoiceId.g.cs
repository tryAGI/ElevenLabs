
#nullable enable

namespace ElevenLabs
{
    public partial class SpeechToSpeechClient
    {
        partial void PrepareCreateSpeechToSpeechVoiceIdArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string voiceId,
            ref bool? enableLogging,
            ref int? optimizeStreamingLatency,
            ref string? outputFormat,
            ref string? xiApiKey,
            global::ElevenLabs.BodySpeechToSpeechV1SpeechToSpeechVoiceIdPost request);
        partial void PrepareCreateSpeechToSpeechVoiceIdRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string voiceId,
            bool? enableLogging,
            int? optimizeStreamingLatency,
            string? outputFormat,
            string? xiApiKey,
            global::ElevenLabs.BodySpeechToSpeechV1SpeechToSpeechVoiceIdPost request);
        partial void ProcessCreateSpeechToSpeechVoiceIdResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateSpeechToSpeechVoiceIdResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Speech To Speech<br/>
        /// Create speech by combining the content and emotion of the uploaded audio with a voice of your choice.
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.
        /// </param>
        /// <param name="enableLogging">
        /// When enable_logging is set to false full privacy mode will be used for the request. This will mean history features are unavailable for this request, including request stitching. Full privacy mode may only be used by enterprise customers.<br/>
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
        /// Output format of the generated audio. Must be one of:<br/>
        /// mp3_22050_32 - output format, mp3 with 22.05kHz sample rate at 32kbps.<br/>
        /// mp3_44100_32 - output format, mp3 with 44.1kHz sample rate at 32kbps.<br/>
        /// mp3_44100_64 - output format, mp3 with 44.1kHz sample rate at 64kbps.<br/>
        /// mp3_44100_96 - output format, mp3 with 44.1kHz sample rate at 96kbps.<br/>
        /// mp3_44100_128 - default output format, mp3 with 44.1kHz sample rate at 128kbps.<br/>
        /// mp3_44100_192 - output format, mp3 with 44.1kHz sample rate at 192kbps. Requires you to be subscribed to Creator tier or above.<br/>
        /// pcm_16000 - PCM format (S16LE) with 16kHz sample rate.<br/>
        /// pcm_22050 - PCM format (S16LE) with 22.05kHz sample rate.<br/>
        /// pcm_24000 - PCM format (S16LE) with 24kHz sample rate.<br/>
        /// pcm_44100 - PCM format (S16LE) with 44.1kHz sample rate. Requires you to be subscribed to Pro tier or above.<br/>
        /// ulaw_8000 - μ-law format (sometimes written mu-law, often approximated as u-law) with 8kHz sample rate. Note that this format is commonly used for Twilio audio inputs.<br/>
        /// Default Value: mp3_44100_128
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::ElevenLabs.HTTPValidationError> CreateSpeechToSpeechVoiceIdAsync(
            string voiceId,
            global::ElevenLabs.BodySpeechToSpeechV1SpeechToSpeechVoiceIdPost request,
            bool? enableLogging = true,
            int? optimizeStreamingLatency = default,
            string? outputFormat = "mp3_44100_128",
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateSpeechToSpeechVoiceIdArguments(
                httpClient: _httpClient,
                voiceId: ref voiceId,
                enableLogging: ref enableLogging,
                optimizeStreamingLatency: ref optimizeStreamingLatency,
                outputFormat: ref outputFormat,
                xiApiKey: ref xiApiKey,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/v1/speech-to-speech/{voiceId}",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("enable_logging", enableLogging?.ToString()) 
                .AddOptionalParameter("optimize_streaming_latency", optimizeStreamingLatency?.ToString()) 
                .AddOptionalParameter("output_format", outputFormat) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }

            if (xiApiKey != default)
            {
                httpRequest.Headers.TryAddWithoutValidation("xi-api-key", xiApiKey.ToString());
            }

            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{voiceId}"),
                name: "voice_id");
            if (enableLogging != true)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{enableLogging}"),
                    name: "enable_logging");
            } 
            if (optimizeStreamingLatency != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{optimizeStreamingLatency}"),
                    name: "optimize_streaming_latency");
            } 
            if (outputFormat != "mp3_44100_128")
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{outputFormat}"),
                    name: "output_format");
            } 
            if (xiApiKey != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{xiApiKey}"),
                    name: "xi-api-key");
            } 
            __httpRequestContent.Add(
                content: new global::System.Net.Http.ByteArrayContent(request.Audio ?? global::System.Array.Empty<byte>())
                {
                    Headers =
                    {
                        ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("multipart/form-data"),
                    },
                },
                name: "audio",
                fileName: request.Audioname ?? string.Empty);
            if (request.ModelId != "eleven_english_sts_v2")
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ModelId}"),
                    name: "model_id");
            } 
            if (request.VoiceSettings != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.VoiceSettings}"),
                    name: "voice_settings");
            } 
            if (request.Seed != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Seed}"),
                    name: "seed");
            }
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateSpeechToSpeechVoiceIdRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                voiceId: voiceId,
                enableLogging: enableLogging,
                optimizeStreamingLatency: optimizeStreamingLatency,
                outputFormat: outputFormat,
                xiApiKey: xiApiKey,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCreateSpeechToSpeechVoiceIdResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateSpeechToSpeechVoiceIdResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::ElevenLabs.HTTPValidationError.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Speech To Speech<br/>
        /// Create speech by combining the content and emotion of the uploaded audio with a voice of your choice.
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.
        /// </param>
        /// <param name="enableLogging">
        /// When enable_logging is set to false full privacy mode will be used for the request. This will mean history features are unavailable for this request, including request stitching. Full privacy mode may only be used by enterprise customers.<br/>
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
        /// Output format of the generated audio. Must be one of:<br/>
        /// mp3_22050_32 - output format, mp3 with 22.05kHz sample rate at 32kbps.<br/>
        /// mp3_44100_32 - output format, mp3 with 44.1kHz sample rate at 32kbps.<br/>
        /// mp3_44100_64 - output format, mp3 with 44.1kHz sample rate at 64kbps.<br/>
        /// mp3_44100_96 - output format, mp3 with 44.1kHz sample rate at 96kbps.<br/>
        /// mp3_44100_128 - default output format, mp3 with 44.1kHz sample rate at 128kbps.<br/>
        /// mp3_44100_192 - output format, mp3 with 44.1kHz sample rate at 192kbps. Requires you to be subscribed to Creator tier or above.<br/>
        /// pcm_16000 - PCM format (S16LE) with 16kHz sample rate.<br/>
        /// pcm_22050 - PCM format (S16LE) with 22.05kHz sample rate.<br/>
        /// pcm_24000 - PCM format (S16LE) with 24kHz sample rate.<br/>
        /// pcm_44100 - PCM format (S16LE) with 44.1kHz sample rate. Requires you to be subscribed to Pro tier or above.<br/>
        /// ulaw_8000 - μ-law format (sometimes written mu-law, often approximated as u-law) with 8kHz sample rate. Note that this format is commonly used for Twilio audio inputs.<br/>
        /// Default Value: mp3_44100_128
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="audio">
        /// The audio file which holds the content and emotion that will control the generated speech.
        /// </param>
        /// <param name="audioname">
        /// The audio file which holds the content and emotion that will control the generated speech.
        /// </param>
        /// <param name="modelId">
        /// Identifier of the model that will be used, you can query them using GET /v1/models. The model needs to have support for speech to speech, you can check this using the can_do_voice_conversion property.<br/>
        /// Default Value: eleven_english_sts_v2
        /// </param>
        /// <param name="voiceSettings">
        /// Voice settings overriding stored setttings for the given voice. They are applied only on the given request. Needs to be send as a JSON encoded string.
        /// </param>
        /// <param name="seed">
        /// If specified, our system will make a best effort to sample deterministically, such that repeated requests with the same seed and parameters should return the same result. Determinism is not guaranteed.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::ElevenLabs.HTTPValidationError> CreateSpeechToSpeechVoiceIdAsync(
            string voiceId,
            byte[] audio,
            string audioname,
            bool? enableLogging = true,
            int? optimizeStreamingLatency = default,
            string? outputFormat = "mp3_44100_128",
            string? xiApiKey = default,
            string? modelId = "eleven_english_sts_v2",
            string? voiceSettings = default,
            int? seed = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::ElevenLabs.BodySpeechToSpeechV1SpeechToSpeechVoiceIdPost
            {
                Audio = audio,
                Audioname = audioname,
                ModelId = modelId,
                VoiceSettings = voiceSettings,
                Seed = seed,
            };

            return await CreateSpeechToSpeechVoiceIdAsync(
                voiceId: voiceId,
                enableLogging: enableLogging,
                optimizeStreamingLatency: optimizeStreamingLatency,
                outputFormat: outputFormat,
                xiApiKey: xiApiKey,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}