
#nullable enable

namespace ElevenLabs
{
    public partial class UsageClient
    {
        partial void PrepareGetUsageCharacterStatsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.DateTimeOffset startUnix,
            ref global::System.DateTimeOffset endUnix,
            ref bool? includeWorkspaceMetrics,
            ref global::ElevenLabs.BreakdownTypes? breakdownType,
            ref global::ElevenLabs.UsageAggregationInterval? aggregationInterval,
            ref global::ElevenLabs.MetricType? metric,
            ref string? xiApiKey);
        partial void PrepareGetUsageCharacterStatsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.DateTimeOffset startUnix,
            global::System.DateTimeOffset endUnix,
            bool? includeWorkspaceMetrics,
            global::ElevenLabs.BreakdownTypes? breakdownType,
            global::ElevenLabs.UsageAggregationInterval? aggregationInterval,
            global::ElevenLabs.MetricType? metric,
            string? xiApiKey);
        partial void ProcessGetUsageCharacterStatsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetUsageCharacterStatsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Characters Usage Metrics<br/>
        /// Returns the usage metrics for the current user or the entire workspace they are part of. The response provides a time axis based on the specified aggregation interval (default: day), with usage values for each interval along that axis. Usage is broken down by the selected breakdown type. For example, breakdown type "voice" will return the usage of each voice for each interval along the time axis.
        /// </summary>
        /// <param name="startUnix">
        /// UTC Unix timestamp for the start of the usage window, in milliseconds. To include the first day of the window, the timestamp should be at 00:00:00 of that day.<br/>
        /// Example: 1685574000
        /// </param>
        /// <param name="endUnix">
        /// UTC Unix timestamp for the end of the usage window, in milliseconds. To include the last day of the window, the timestamp should be at 23:59:59 of that day.<br/>
        /// Example: 1688165999
        /// </param>
        /// <param name="includeWorkspaceMetrics">
        /// Whether or not to include the statistics of the entire workspace.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="breakdownType">
        /// How to break down the information. Cannot be "user" or "api_key" if include_workspace_metrics is False.
        /// </param>
        /// <param name="aggregationInterval">
        /// The time interval over which to aggregate the usage data.
        /// </param>
        /// <param name="metric"></param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::ElevenLabs.UsageCharactersResponseModel> GetUsageCharacterStatsAsync(
            global::System.DateTimeOffset startUnix,
            global::System.DateTimeOffset endUnix,
            bool? includeWorkspaceMetrics = default,
            global::ElevenLabs.BreakdownTypes? breakdownType = default,
            global::ElevenLabs.UsageAggregationInterval? aggregationInterval = default,
            global::ElevenLabs.MetricType? metric = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetUsageCharacterStatsArguments(
                httpClient: HttpClient,
                startUnix: ref startUnix,
                endUnix: ref endUnix,
                includeWorkspaceMetrics: ref includeWorkspaceMetrics,
                breakdownType: ref breakdownType,
                aggregationInterval: ref aggregationInterval,
                metric: ref metric,
                xiApiKey: ref xiApiKey);

            var __pathBuilder = new PathBuilder(
                path: "/v1/usage/character-stats",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter("start_unix", startUnix.ToString()) 
                .AddRequiredParameter("end_unix", endUnix.ToString()) 
                .AddOptionalParameter("include_workspace_metrics", includeWorkspaceMetrics?.ToString()) 
                .AddOptionalParameter("breakdown_type", breakdownType?.ToValueString()) 
                .AddOptionalParameter("aggregation_interval", aggregationInterval?.ToValueString()) 
                .AddOptionalParameter("metric", metric?.ToValueString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
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


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareGetUsageCharacterStatsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                startUnix: startUnix,
                endUnix: endUnix,
                includeWorkspaceMetrics: includeWorkspaceMetrics,
                breakdownType: breakdownType,
                aggregationInterval: aggregationInterval,
                metric: metric,
                xiApiKey: xiApiKey);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetUsageCharacterStatsResponse(
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
                ProcessGetUsageCharacterStatsResponseContent(
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
                    global::ElevenLabs.UsageCharactersResponseModel.FromJson(__content, JsonSerializerContext) ??
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
                    await global::ElevenLabs.UsageCharactersResponseModel.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }
    }
}