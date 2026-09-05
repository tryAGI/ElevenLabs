
#nullable enable

namespace ElevenLabs
{
    public partial class DubbingClient
    {


        private static readonly global::ElevenLabs.EndPointSecurityRequirement s_CreateSecurityRequirement0 =
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
        private static readonly global::ElevenLabs.EndPointSecurityRequirement[] s_CreateSecurityRequirements =
            new global::ElevenLabs.EndPointSecurityRequirement[]
            {                s_CreateSecurityRequirement0,
            };
        partial void PrepareCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::ElevenLabs.BodyCreateDubbingProjectV1DubbingProjectPost request);
        partial void PrepareCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::ElevenLabs.BodyCreateDubbingProjectV1DubbingProjectPost request);
        partial void ProcessCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Dubbing Project<br/>
        /// Create a dubbing project from an uploaded file (`file`) or a source URL (`source_url`).<br/>
        /// Returns as soon as the project record exists, before the source has been fetched: the project starts `queued` and reaches `ready` once its source has been transcribed. Add a language target to it for each language you want, or pass `target_language` to queue the first one here.<br/>
        /// Creating a project incurs a minimum charge of one language: you are charged for at least one language's dubbing when the project is created, before any output exists. This charge prepays the first language target — the first target you add, or the one queued via `target_language`, consumes it — and each additional language is charged separately.<br/>
        /// Preparation can take minutes on a long source, so we recommend passing `webhook_ids` to be notified when the project turns `ready` or `failed`, rather than polling for it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::ElevenLabs.DubbingProjectResponse> CreateAsync(

            global::ElevenLabs.BodyCreateDubbingProjectV1DubbingProjectPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await CreateAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Create Dubbing Project<br/>
        /// Create a dubbing project from an uploaded file (`file`) or a source URL (`source_url`).<br/>
        /// Returns as soon as the project record exists, before the source has been fetched: the project starts `queued` and reaches `ready` once its source has been transcribed. Add a language target to it for each language you want, or pass `target_language` to queue the first one here.<br/>
        /// Creating a project incurs a minimum charge of one language: you are charged for at least one language's dubbing when the project is created, before any output exists. This charge prepays the first language target — the first target you add, or the one queued via `target_language`, consumes it — and each additional language is charged separately.<br/>
        /// Preparation can take minutes on a long source, so we recommend passing `webhook_ids` to be notified when the project turns `ready` or `failed`, rather than polling for it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.DubbingProjectResponse>> CreateAsResponseAsync(

            global::ElevenLabs.BodyCreateDubbingProjectV1DubbingProjectPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::ElevenLabs.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateSecurityRequirements,
                operationName: "CreateAsync");

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
                supportsRetry: false);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::ElevenLabs.PathBuilder(
                                path: "/v1/dubbing/project",
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

                            var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
                            if (request.File != default)
                            {

                                var __contentFile = new global::System.Net.Http.ByteArrayContent(request.File ?? global::System.Array.Empty<byte>());
                                __contentFile.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                    request.Filename is null
                                        ? "application/octet-stream"
                                        : (global::System.IO.Path.GetExtension(request.Filename) ?? string.Empty).ToLowerInvariant() switch
                                        {
                                            ".aac" => "audio/aac",
                                            ".flac" => "audio/flac",
                                            ".gif" => "image/gif",
                                            ".jpeg" => "image/jpeg",
                                            ".jpg" => "image/jpeg",
                                            ".json" => "application/json",
                                            ".m4a" => "audio/mp4",
                                            ".mp3" => "audio/mpeg",
                                            ".mp4" => "video/mp4",
                                            ".mpeg" => "audio/mpeg",
                                            ".mpga" => "audio/mpeg",
                                            ".oga" => "audio/ogg",
                                            ".ogg" => "audio/ogg",
                                            ".opus" => "audio/ogg",
                                            ".pdf" => "application/pdf",
                                            ".png" => "image/png",
                                            ".txt" => "text/plain",
                                            ".wav" => "audio/wav",
                                            ".weba" => "audio/webm",
                                            ".webm" => "video/webm",
                                            ".webp" => "image/webp",
                                            _ => "application/octet-stream",
                                        });
                                __httpRequestContent.Add(
                                    content: __contentFile,
                                    name: "\"file\"",
                                    fileName: request.Filename != null ? $"\"{request.Filename}\"" : string.Empty);
                                if (__contentFile.Headers.ContentDisposition != null)
                                {
                                    __contentFile.Headers.ContentDisposition.FileNameStar = null;
                                }

                            }
                            if (request.SourceUrl != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.SourceUrl ?? string.Empty),
                                    name: "\"source_url\"");

                            }
                            if (request.Reference != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.Reference ?? string.Empty),
                                    name: "\"reference\"");

                            }
                            if (request.SourceLanguage != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.SourceLanguage ?? string.Empty),
                                    name: "\"source_language\"");

                            }
                            if (request.ModelId != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.ModelId.ToString() ?? string.Empty),
                                    name: "\"model_id\"");

                            }
                            if (request.Keyterms != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(request.Keyterms!, x => x))}]"),
                                    name: "\"keyterms\"");

                            }
                            if (request.WebhookIds != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(request.WebhookIds!, x => x))}]"),
                                    name: "\"webhook_ids\"");

                            }
                            if (request.TargetLanguage != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.TargetLanguage ?? string.Empty),
                                    name: "\"target_language\"");

                            }
                            if (request.Transcript != default)
                            {

                                var __contentTranscript = new global::System.Net.Http.ByteArrayContent(request.Transcript ?? global::System.Array.Empty<byte>());
                                __contentTranscript.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                    request.Transcriptname is null
                                        ? "application/octet-stream"
                                        : (global::System.IO.Path.GetExtension(request.Transcriptname) ?? string.Empty).ToLowerInvariant() switch
                                        {
                                            ".aac" => "audio/aac",
                                            ".flac" => "audio/flac",
                                            ".gif" => "image/gif",
                                            ".jpeg" => "image/jpeg",
                                            ".jpg" => "image/jpeg",
                                            ".json" => "application/json",
                                            ".m4a" => "audio/mp4",
                                            ".mp3" => "audio/mpeg",
                                            ".mp4" => "video/mp4",
                                            ".mpeg" => "audio/mpeg",
                                            ".mpga" => "audio/mpeg",
                                            ".oga" => "audio/ogg",
                                            ".ogg" => "audio/ogg",
                                            ".opus" => "audio/ogg",
                                            ".pdf" => "application/pdf",
                                            ".png" => "image/png",
                                            ".txt" => "text/plain",
                                            ".wav" => "audio/wav",
                                            ".weba" => "audio/webm",
                                            ".webm" => "video/webm",
                                            ".webp" => "image/webp",
                                            _ => "application/octet-stream",
                                        });
                                __httpRequestContent.Add(
                                    content: __contentTranscript,
                                    name: "\"transcript\"",
                                    fileName: request.Transcriptname != null ? $"\"{request.Transcriptname}\"" : string.Empty);
                                if (__contentTranscript.Headers.ContentDisposition != null)
                                {
                                    __contentTranscript.Headers.ContentDisposition.FileNameStar = null;
                                }

                            }

                            __httpRequest.Content = __httpRequestContent;

                global::ElevenLabs.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreateRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
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
                                operationId: "Create",
                                methodName: "CreateAsync",
                                pathTemplate: "\"/v1/dubbing/project\"",
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
                                operationId: "Create",
                                methodName: "CreateAsync",
                                pathTemplate: "\"/v1/dubbing/project\"",
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
                                operationId: "Create",
                                methodName: "CreateAsync",
                                pathTemplate: "\"/v1/dubbing/project\"",
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
                ProcessCreateResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::ElevenLabs.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::ElevenLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Create",
                                methodName: "CreateAsync",
                                pathTemplate: "\"/v1/dubbing/project\"",
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
                                operationId: "Create",
                                methodName: "CreateAsync",
                                pathTemplate: "\"/v1/dubbing/project\"",
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


                                throw global::ElevenLabs.ApiException<global::ElevenLabs.HTTPValidationError>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_422,
                                    responseBody: __content_422,
                                    responseObject: __value_422,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
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
                                ProcessCreateResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::ElevenLabs.DubbingProjectResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.DubbingProjectResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::ElevenLabs.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::ElevenLabs.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
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

                                    var __value = await global::ElevenLabs.DubbingProjectResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.DubbingProjectResponse>(
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

                                    throw global::ElevenLabs.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
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
        /// Create Dubbing Project<br/>
        /// Create a dubbing project from an uploaded file (`file`) or a source URL (`source_url`).<br/>
        /// Returns as soon as the project record exists, before the source has been fetched: the project starts `queued` and reaches `ready` once its source has been transcribed. Add a language target to it for each language you want, or pass `target_language` to queue the first one here.<br/>
        /// Creating a project incurs a minimum charge of one language: you are charged for at least one language's dubbing when the project is created, before any output exists. This charge prepays the first language target — the first target you add, or the one queued via `target_language`, consumes it — and each additional language is charged separately.<br/>
        /// Preparation can take minutes on a long source, so we recommend passing `webhook_ids` to be notified when the project turns `ready` or `failed`, rather than polling for it.
        /// </summary>
        /// <param name="file">
        /// The source media file to dub: an audio or video file of at most 3 GiB. Provide this or `source_url`, not both.
        /// </param>
        /// <param name="filename">
        /// The source media file to dub: an audio or video file of at most 3 GiB. Provide this or `source_url`, not both.
        /// </param>
        /// <param name="sourceUrl">
        /// Public HTTP(S) URL the source media is fetched from server-side, subject to the same size and format limits as an upload. Provide this or `file`, not both.
        /// </param>
        /// <param name="reference">
        /// Optional free-form string (at most 500 characters) to identify the project on your end. Stored and echoed back verbatim; it does not affect the dub.
        /// </param>
        /// <param name="sourceLanguage">
        /// BCP-47 language tag of the source media; must be a language the transcription model supports. Any region or script subtag is ignored, since transcription is per-language. Omit to auto-detect.
        /// </param>
        /// <param name="modelId">
        /// Dubbing model (`dubbing_v1` or `dubbing_v2`) every language target of this project is dubbed with. Defaults to `dubbing_v2`. Fixed at create time — the source is prepared for this model, so neither the project nor an individual target can change it later.
        /// </param>
        /// <param name="keyterms">
        /// Key terms to bias transcription and translation toward (for example, product or brand names). At most 1,000 terms; each term at most 50 characters and 5 words; the characters `&lt;&gt;{}[]\` are not allowed. Terms are trimmed and deduplicated.
        /// </param>
        /// <param name="webhookIds">
        /// IDs of workspace webhooks to notify as this project progresses — the alternative to polling, and what we recommend. Each receives a `dubbing_project_ready` or `dubbing_project_failed` event for the project, and a `dubbing_language_completed` or `dubbing_language_failed` event for every language under it; `dubbing_language_completed` carries the output download URLs. At most 3 IDs, each already configured in your workspace — see [Webhooks](https://elevenlabs.io/docs/eleven-api/resources/webhooks) for how to create one and verify its signature. Delivery is best-effort and can repeat, so we recommend handling events idempotently.
        /// </param>
        /// <param name="targetLanguage">
        /// Optional shortcut: also create a language target in this BCP-47 language, queued to start once the project is ready — equivalent to creating the project and then creating one language target. Must be one of the [languages the dubbing model supports](https://elevenlabs.io/docs/help-center/product/dubbing/which-languages-are-supported-in-dubbing), and a region-qualified tag must be one of the supported dialects. This is the first language target, so it consumes the project's minimum charge rather than adding to it. Its ID is returned in `language_ids`.
        /// </param>
        /// <param name="transcript">
        /// Enterprise only. Optional JSON transcript to use instead of transcribing the source: a `{"segments": [...]}` document, at most 20,000 segments and 4 MiB. See [Bring your own transcript](https://elevenlabs.io/docs/eleven-api/guides/how-to/dubbing/bring-your-own-transcript) for the segment fields and their constraints. `source_language` is required whenever a transcript is provided. If any segment carries a `translation`, `target_language` is required and every segment must carry one; those translations seed the target created via `target_language`, which then skips machine translation.
        /// </param>
        /// <param name="transcriptname">
        /// Enterprise only. Optional JSON transcript to use instead of transcribing the source: a `{"segments": [...]}` document, at most 20,000 segments and 4 MiB. See [Bring your own transcript](https://elevenlabs.io/docs/eleven-api/guides/how-to/dubbing/bring-your-own-transcript) for the segment fields and their constraints. `source_language` is required whenever a transcript is provided. If any segment carries a `translation`, `target_language` is required and every segment must carry one; those translations seed the target created via `target_language`, which then skips machine translation.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::ElevenLabs.DubbingProjectResponse> CreateAsync(
            byte[]? file = default,
            string? filename = default,
            string? sourceUrl = default,
            string? reference = default,
            string? sourceLanguage = default,
            global::ElevenLabs.AnyOf<global::ElevenLabs.BodyCreateDubbingProjectV1DubbingProjectPostModelId?, string, object>? modelId = default,
            global::System.Collections.Generic.IList<string>? keyterms = default,
            global::System.Collections.Generic.IList<string>? webhookIds = default,
            string? targetLanguage = default,
            byte[]? transcript = default,
            string? transcriptname = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::ElevenLabs.BodyCreateDubbingProjectV1DubbingProjectPost
            {
                File = file,
                Filename = filename,
                SourceUrl = sourceUrl,
                Reference = reference,
                SourceLanguage = sourceLanguage,
                ModelId = modelId,
                Keyterms = keyterms,
                WebhookIds = webhookIds,
                TargetLanguage = targetLanguage,
                Transcript = transcript,
                Transcriptname = transcriptname,
            };

            return await CreateAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}