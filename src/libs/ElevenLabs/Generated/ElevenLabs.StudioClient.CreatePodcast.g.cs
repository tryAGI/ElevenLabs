
#nullable enable

namespace ElevenLabs
{
    public partial class StudioClient
    {


        private static readonly global::ElevenLabs.EndPointSecurityRequirement s_CreatePodcastSecurityRequirement0 =
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
        private static readonly global::ElevenLabs.EndPointSecurityRequirement[] s_CreatePodcastSecurityRequirements =
            new global::ElevenLabs.EndPointSecurityRequirement[]
            {                s_CreatePodcastSecurityRequirement0,
            };
        partial void PrepareCreatePodcastArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? safetyIdentifier,
            global::ElevenLabs.BodyCreatePodcastV1StudioPodcastsPost request);
        partial void PrepareCreatePodcastRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? safetyIdentifier,
            global::ElevenLabs.BodyCreatePodcastV1StudioPodcastsPost request);
        partial void ProcessCreatePodcastResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreatePodcastResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Podcast<br/>
        /// Create and auto-convert a podcast project. Currently, the LLM cost is covered by us but you will still be charged for the audio generation. In the future, you will be charged for both the LLM and audio generation costs.
        /// </summary>
        /// <param name="safetyIdentifier">
        /// Used for moderation. Your workspace must be allowlisted to use this feature.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::ElevenLabs.PodcastProjectResponseModel> CreatePodcastAsync(

            global::ElevenLabs.BodyCreatePodcastV1StudioPodcastsPost request,
            string? safetyIdentifier = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await CreatePodcastAsResponseAsync(

                request: request,
                safetyIdentifier: safetyIdentifier,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Create Podcast<br/>
        /// Create and auto-convert a podcast project. Currently, the LLM cost is covered by us but you will still be charged for the audio generation. In the future, you will be charged for both the LLM and audio generation costs.
        /// </summary>
        /// <param name="safetyIdentifier">
        /// Used for moderation. Your workspace must be allowlisted to use this feature.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.PodcastProjectResponseModel>> CreatePodcastAsResponseAsync(

            global::ElevenLabs.BodyCreatePodcastV1StudioPodcastsPost request,
            string? safetyIdentifier = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreatePodcastArguments(
                httpClient: HttpClient,
                safetyIdentifier: ref safetyIdentifier,
                request: request);


            var __authorizations = global::ElevenLabs.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreatePodcastSecurityRequirements,
                operationName: "CreatePodcastAsync");

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
                                path: "/v1/studio/podcasts",
                                baseUri: HttpClient.BaseAddress);
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

            if (safetyIdentifier != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("safety-identifier", safetyIdentifier.ToString());
            }

                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::ElevenLabs.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreatePodcastRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    safetyIdentifier: safetyIdentifier,
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
                                operationId: "CreatePodcast",
                                methodName: "CreatePodcastAsync",
                                pathTemplate: "\"/v1/studio/podcasts\"",
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
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
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
                        var __retryDelay = global::ElevenLabs.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::ElevenLabs.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::ElevenLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreatePodcast",
                                methodName: "CreatePodcastAsync",
                                pathTemplate: "\"/v1/studio/podcasts\"",
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
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::ElevenLabs.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::ElevenLabs.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::ElevenLabs.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::ElevenLabs.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::ElevenLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreatePodcast",
                                methodName: "CreatePodcastAsync",
                                pathTemplate: "\"/v1/studio/podcasts\"",
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
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::ElevenLabs.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
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
                ProcessCreatePodcastResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::ElevenLabs.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::ElevenLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreatePodcast",
                                methodName: "CreatePodcastAsync",
                                pathTemplate: "\"/v1/studio/podcasts\"",
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
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::ElevenLabs.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::ElevenLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreatePodcast",
                                methodName: "CreatePodcastAsync",
                                pathTemplate: "\"/v1/studio/podcasts\"",
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
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
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
                                ProcessCreatePodcastResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::ElevenLabs.PodcastProjectResponseModel.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.PodcastProjectResponseModel>(
                                        statusCode: __response.StatusCode,
                                        headers: global::ElevenLabs.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
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

                                    var __value = await global::ElevenLabs.PodcastProjectResponseModel.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.PodcastProjectResponseModel>(
                                        statusCode: __response.StatusCode,
                                        headers: global::ElevenLabs.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
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
        /// Create Podcast<br/>
        /// Create and auto-convert a podcast project. Currently, the LLM cost is covered by us but you will still be charged for the audio generation. In the future, you will be charged for both the LLM and audio generation costs.
        /// </summary>
        /// <param name="safetyIdentifier">
        /// Used for moderation. Your workspace must be allowlisted to use this feature.
        /// </param>
        /// <param name="modelId">
        /// The ID of the model to be used for this Studio project, you can query GET /v1/models to list all available models.
        /// </param>
        /// <param name="mode">
        /// The type of podcast to generate. Can be 'conversation', an interaction between two voices, or 'bulletin', a monologue.
        /// </param>
        /// <param name="source">
        /// The source content for the Podcast.
        /// </param>
        /// <param name="qualityPreset">
        /// Output quality of the generated audio. Must be one of:<br/>
        /// 'standard' - standard output format, 128kbps with 44.1kHz sample rate.<br/>
        /// 'high' - high quality output format, 192kbps with 44.1kHz sample rate and major improvements on our side.<br/>
        /// 'ultra' - ultra quality output format, 192kbps with 44.1kHz sample rate and highest improvements on our side.<br/>
        /// 'ultra_lossless' - ultra quality output format, 705.6kbps with 44.1kHz sample rate and highest improvements on our side in a fully lossless format.<br/>
        /// Default Value: standard
        /// </param>
        /// <param name="durationScale">
        /// Duration of the generated podcast. Must be one of:<br/>
        /// short - produces podcasts shorter than 3 minutes.<br/>
        /// default - produces podcasts roughly between 3-7 minutes.<br/>
        /// long - produces podcasts longer than 7 minutes.<br/>
        /// Default Value: default
        /// </param>
        /// <param name="language">
        /// An optional language of the Studio project. Two-letter language code (ISO 639-1).
        /// </param>
        /// <param name="intro">
        /// The intro text that will always be added to the beginning of the podcast.
        /// </param>
        /// <param name="outro">
        /// The outro text that will always be added to the end of the podcast.
        /// </param>
        /// <param name="instructionsPrompt">
        /// Additional instructions prompt for the podcast generation used to adjust the podcast's style and tone.
        /// </param>
        /// <param name="highlights">
        /// A brief summary or highlights of the Studio project's content, providing key points or themes. This should be between 10 and 70 characters.
        /// </param>
        /// <param name="callbackUrl">
        ///     A url that will be called by our service when the Studio project is converted. Request will contain a json blob containing the status of the conversion<br/>
        ///     Messages:<br/>
        ///     1. When project was converted successfully:<br/>
        ///     {<br/>
        ///       type: "project_conversion_status",<br/>
        ///       event_timestamp: 1234567890,<br/>
        ///       data: {<br/>
        ///         request_id: "1234567890",<br/>
        ///         project_id: "21m00Tcm4TlvDq8ikWAM",<br/>
        ///         conversion_status: "success",<br/>
        ///         project_snapshot_id: "22m00Tcm4TlvDq8ikMAT",<br/>
        ///         error_details: None,<br/>
        ///       }<br/>
        ///     }<br/>
        ///     2. When project conversion failed:<br/>
        ///     {<br/>
        ///       type: "project_conversion_status",<br/>
        ///       event_timestamp: 1234567890,<br/>
        ///       data: {<br/>
        ///         request_id: "1234567890",<br/>
        ///         project_id: "21m00Tcm4TlvDq8ikWAM",<br/>
        ///         conversion_status: "error",<br/>
        ///         project_snapshot_id: None,<br/>
        ///         error_details: "Error details if conversion failed"<br/>
        ///       }<br/>
        ///     }<br/>
        ///     3. When chapter was converted successfully:<br/>
        ///     {<br/>
        ///       type: "chapter_conversion_status",<br/>
        ///       event_timestamp: 1234567890,<br/>
        ///       data: {<br/>
        ///         request_id: "1234567890",<br/>
        ///         project_id: "21m00Tcm4TlvDq8ikWAM",<br/>
        ///         chapter_id: "22m00Tcm4TlvDq8ikMAT",<br/>
        ///         conversion_status: "success",<br/>
        ///         chapter_snapshot_id: "23m00Tcm4TlvDq8ikMAV",<br/>
        ///         error_details: None,<br/>
        ///       }<br/>
        ///     }<br/>
        ///     4. When chapter conversion failed:<br/>
        ///     {<br/>
        ///       type: "chapter_conversion_status",<br/>
        ///       event_timestamp: 1234567890,<br/>
        ///       data: {<br/>
        ///         request_id: "1234567890",<br/>
        ///         project_id: "21m00Tcm4TlvDq8ikWAM",<br/>
        ///         chapter_id: "22m00Tcm4TlvDq8ikMAT",<br/>
        ///         conversion_status: "error",<br/>
        ///         chapter_snapshot_id: None,<br/>
        ///         error_details: "Error details if conversion failed"<br/>
        ///       }<br/>
        ///     }<br/>
        ///     
        /// </param>
        /// <param name="applyTextNormalization">
        ///     This parameter controls text normalization with four modes: 'auto', 'on', 'apply_english' and 'off'.<br/>
        ///     When set to 'auto', the system will automatically decide whether to apply text normalization<br/>
        ///     (e.g., spelling out numbers). With 'on', text normalization will always be applied, while<br/>
        ///     with 'off', it will be skipped. 'apply_english' is the same as 'on' but will assume that text is in English.<br/>
        ///     
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::ElevenLabs.PodcastProjectResponseModel> CreatePodcastAsync(
            string modelId,
            global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastConversationMode, global::ElevenLabs.PodcastBulletinMode> mode,
            global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource, global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.PodcastTextSource, global::ElevenLabs.PodcastURLSource>>> source,
            string? safetyIdentifier = default,
            global::ElevenLabs.QualityPresetType? qualityPreset = default,
            global::ElevenLabs.BodyCreatePodcastV1StudioPodcastsPostDurationScale? durationScale = default,
            string? language = default,
            string? intro = default,
            string? outro = default,
            string? instructionsPrompt = default,
            global::System.Collections.Generic.IList<string>? highlights = default,
            string? callbackUrl = default,
            global::ElevenLabs.BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization2? applyTextNormalization = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::ElevenLabs.BodyCreatePodcastV1StudioPodcastsPost
            {
                ModelId = modelId,
                Mode = mode,
                Source = source,
                QualityPreset = qualityPreset,
                DurationScale = durationScale,
                Language = language,
                Intro = intro,
                Outro = outro,
                InstructionsPrompt = instructionsPrompt,
                Highlights = highlights,
                CallbackUrl = callbackUrl,
                ApplyTextNormalization = applyTextNormalization,
            };

            return await CreatePodcastAsync(
                safetyIdentifier: safetyIdentifier,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}