
#nullable enable

namespace ElevenLabs
{
    public partial class SmbClient
    {


        private static readonly global::ElevenLabs.EndPointSecurityRequirement s_UpdateSecurityRequirement0 =
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
        private static readonly global::ElevenLabs.EndPointSecurityRequirement[] s_UpdateSecurityRequirements =
            new global::ElevenLabs.EndPointSecurityRequirement[]
            {                s_UpdateSecurityRequirement0,
            };
        partial void PrepareUpdateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string serviceId,
            ref string xiWorkspaceId,
            global::ElevenLabs.ReceptionUpdateServiceRequestPatch request);
        partial void PrepareUpdateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string serviceId,
            string xiWorkspaceId,
            global::ElevenLabs.ReceptionUpdateServiceRequestPatch request);
        partial void ProcessUpdateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Service<br/>
        /// Update an existing service. Only the fields sent are changed.
        /// </summary>
        /// <param name="serviceId">
        /// ID of the service. Returned when you create one; list them with `GET /v1/reception/services`.
        /// </param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::ElevenLabs.ReceptionServiceUpdateResponse> UpdateAsync(
            string serviceId,
            string xiWorkspaceId,

            global::ElevenLabs.ReceptionUpdateServiceRequestPatch request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await UpdateAsResponseAsync(
                serviceId: serviceId,
                xiWorkspaceId: xiWorkspaceId,

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Update Service<br/>
        /// Update an existing service. Only the fields sent are changed.
        /// </summary>
        /// <param name="serviceId">
        /// ID of the service. Returned when you create one; list them with `GET /v1/reception/services`.
        /// </param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.ReceptionServiceUpdateResponse>> UpdateAsResponseAsync(
            string serviceId,
            string xiWorkspaceId,

            global::ElevenLabs.ReceptionUpdateServiceRequestPatch request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var JsonSerializerContext = JsonSerializerContextProvider?.Value ??
                global::ElevenLabs.SourceGenerationContextOperation_C1C1009D3F37EC05.Default;
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUpdateArguments(
                httpClient: HttpClient,
                serviceId: ref serviceId,
                xiWorkspaceId: ref xiWorkspaceId,
                request: request);


            var __authorizations = global::ElevenLabs.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_UpdateSecurityRequirements,
                operationName: "UpdateAsync");

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
                                path: $"/v1/reception/services/{serviceId}",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::ElevenLabs.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Put,
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

                __httpRequest.Headers.TryAddWithoutValidation("xi-workspace-id", xiWorkspaceId.ToString());

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
                PrepareUpdateRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    serviceId: serviceId,
                    xiWorkspaceId: xiWorkspaceId,
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
                                operationId: "Update",
                                methodName: "UpdateAsync",
                                pathTemplate: "$\"/v1/reception/services/{serviceId}\"",
                                httpMethod: "PUT",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                                operationId: "Update",
                                methodName: "UpdateAsync",
                                pathTemplate: "$\"/v1/reception/services/{serviceId}\"",
                                httpMethod: "PUT",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                                operationId: "Update",
                                methodName: "UpdateAsync",
                                pathTemplate: "$\"/v1/reception/services/{serviceId}\"",
                                httpMethod: "PUT",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                ProcessUpdateResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::ElevenLabs.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::ElevenLabs.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Update",
                                methodName: "UpdateAsync",
                                pathTemplate: "$\"/v1/reception/services/{serviceId}\"",
                                httpMethod: "PUT",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                                operationId: "Update",
                                methodName: "UpdateAsync",
                                pathTemplate: "$\"/v1/reception/services/{serviceId}\"",
                                httpMethod: "PUT",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                                ProcessUpdateResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::ElevenLabs.ReceptionServiceUpdateResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.ReceptionServiceUpdateResponse>(
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

                                    var __value = await global::ElevenLabs.ReceptionServiceUpdateResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.ReceptionServiceUpdateResponse>(
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
        /// Update Service<br/>
        /// Update an existing service. Only the fields sent are changed.
        /// </summary>
        /// <param name="serviceId">
        /// ID of the service. Returned when you create one; list them with `GET /v1/reception/services`.
        /// </param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="pricingMode">
        /// 'fixed' (default): the item has a known price the agent can quote, and customers can book or order it directly. 'quote': the price depends on the job (renovation, catering, custom work), so no price or slot is offered; the agent collects the intake_questions and files a quote request instead. Takes effect only while quotes are enabled for the business. Group services cannot use 'quote'.<br/>
        /// Default Value: fixed
        /// </param>
        /// <param name="intakeQuestions">
        /// Questions the agent asks before booking or ordering this item. Required for a useful `pricing_mode='quote'` item -- without them a quote request arrives with nothing to price -- but also valid on fixed-price items that need extra detail (current hair color before a dye job, allergies before a treatment).
        /// </param>
        /// <param name="groups">
        /// Group memberships for this item. Each entry carries the group label and the item's 0-based rank within that group.
        /// </param>
        /// <param name="ungroupedRank">
        /// Display position among items with no group; `null` sorts last. Change it with the reorder endpoint.
        /// </param>
        /// <param name="name">
        /// Service name shown to customers and the receptionist.
        /// </param>
        /// <param name="description">
        /// Details about the service for customers and the receptionist; empty string means none.
        /// </param>
        /// <param name="variants">
        /// Bookable options for this service. Always non-empty; `variants[0]` is the default option shown when callers don't pick a specific variant. Each entry has its own duration and (optional) price, and uniqueness is keyed by duration.
        /// </param>
        /// <param name="kind">
        /// Classic = staff-delivered; rental = asset-based; group = multi-participant session.<br/>
        /// Default Value: classic
        /// </param>
        /// <param name="bufferMinutes">
        /// Turnover/cleanup time reserved after each booking. Applies to every service kind; default 0 means no buffer.
        /// </param>
        /// <param name="serviceLocation">
        /// Where the service is delivered. `business` = client visits the business location (default); `customer` = staff travels to the client. Only meaningful for `kind='classic'`.<br/>
        /// Default Value: business
        /// </param>
        /// <param name="addOns">
        /// Optional extras that can be added to a booking of this service.
        /// </param>
        /// <param name="maxParticipants">
        /// Capacity for `kind='group'`: how many seats a single session can sell across all registrations. Must be null for classic and rental services (those are always exclusive to one client per booking).
        /// </param>
        /// <param name="capacity">
        /// Not used to limit bookings; set `max_participants` on group services instead.
        /// </param>
        /// <param name="isActive">
        /// Whether the service is offered; inactive services can't be booked.
        /// </param>
        /// <param name="anyStaffMember">
        /// Whether any staff member can deliver the service. When false, only the staff in `staff_ids` can. Ignored for rentals.
        /// </param>
        /// <param name="staffIds">
        /// Staff assigned to this service; must be empty for kind='rental'.
        /// </param>
        /// <param name="assetIds">
        /// Assets, such as rooms or equipment, this service can be booked on.
        /// </param>
        /// <param name="advanceBookingMinutes">
        /// How far into the future customer-facing channels (public booking page, voice agent) may book this service. Applies to every kind.
        /// </param>
        /// <param name="locationIds">
        /// Locations where this service is offered; empty list means all locations.
        /// </param>
        /// <param name="displayOnBookingPage">
        /// Whether the service is listed on the public booking page.
        /// </param>
        /// <param name="travelMinutes">
        /// Travel time in minutes added before/after appointments for customer-location services. Blocks the staff member's calendar but is not visible to the customer. Ignored when `service_location='business'`.
        /// </param>
        /// <param name="travelBefore">
        /// Add travel time before the appointment (outbound trip).
        /// </param>
        /// <param name="travelAfter">
        /// Add travel time after the appointment (return trip).
        /// </param>
        /// <param name="promotions">
        /// Time-bound discounts applicable to this service or specific variants.
        /// </param>
        /// <param name="durationMinutes">
        /// Sets the first variant's duration. Ignored when `variants` is sent.
        /// </param>
        /// <param name="price">
        /// Sets the first variant's price. Ignored when `variants` is sent.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::ElevenLabs.ReceptionServiceUpdateResponse> UpdateAsync(
            string serviceId,
            string xiWorkspaceId,
            global::ElevenLabs.PricingMode? pricingMode = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionIntakeQuestion>? intakeQuestions = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionGroupMembership>? groups = default,
            int? ungroupedRank = default,
            string? name = default,
            string? description = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionServiceVariant>? variants = default,
            global::ElevenLabs.ReceptionServiceKind? kind = default,
            int? bufferMinutes = default,
            global::ElevenLabs.ServiceLocationType? serviceLocation = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionAddOn>? addOns = default,
            int? maxParticipants = default,
            int? capacity = default,
            bool? isActive = default,
            bool? anyStaffMember = default,
            global::System.Collections.Generic.IList<string>? staffIds = default,
            global::System.Collections.Generic.IList<string>? assetIds = default,
            int? advanceBookingMinutes = default,
            global::System.Collections.Generic.IList<string>? locationIds = default,
            bool? displayOnBookingPage = default,
            int? travelMinutes = default,
            bool? travelBefore = default,
            bool? travelAfter = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionServicePromotion>? promotions = default,
            int? durationMinutes = default,
            double? price = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::ElevenLabs.ReceptionUpdateServiceRequestPatch
            {
                PricingMode = pricingMode,
                IntakeQuestions = intakeQuestions,
                Groups = groups,
                UngroupedRank = ungroupedRank,
                Name = name,
                Description = description,
                Variants = variants,
                Kind = kind,
                BufferMinutes = bufferMinutes,
                ServiceLocation = serviceLocation,
                AddOns = addOns,
                MaxParticipants = maxParticipants,
                Capacity = capacity,
                IsActive = isActive,
                AnyStaffMember = anyStaffMember,
                StaffIds = staffIds,
                AssetIds = assetIds,
                AdvanceBookingMinutes = advanceBookingMinutes,
                LocationIds = locationIds,
                DisplayOnBookingPage = displayOnBookingPage,
                TravelMinutes = travelMinutes,
                TravelBefore = travelBefore,
                TravelAfter = travelAfter,
                Promotions = promotions,
                DurationMinutes = durationMinutes,
                Price = price,
            };

            return await UpdateAsync(
                serviceId: serviceId,
                xiWorkspaceId: xiWorkspaceId,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}