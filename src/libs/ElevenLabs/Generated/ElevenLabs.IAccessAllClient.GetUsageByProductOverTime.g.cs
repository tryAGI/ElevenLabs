#nullable enable

namespace ElevenLabs
{
    public partial interface IAccessAllClient
    {
        /// <summary>
        /// Get Workspace Usage<br/>
        /// Returns credit usage broken down by product type over time. The response is a tabular structure with columns, column_types, column_units, and rows.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.WorkspaceAnalyticsQueryResponseModel> GetUsageByProductOverTimeAsync(

            global::ElevenLabs.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Workspace Usage<br/>
        /// Returns credit usage broken down by product type over time. The response is a tabular structure with columns, column_types, column_units, and rows.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.WorkspaceAnalyticsQueryResponseModel>> GetUsageByProductOverTimeAsResponseAsync(

            global::ElevenLabs.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Workspace Usage<br/>
        /// Returns credit usage broken down by product type over time. The response is a tabular structure with columns, column_types, column_units, and rows.
        /// </summary>
        /// <param name="startTime">
        /// Start of the time range as a Unix timestamp in milliseconds. Must be at least 2020-01-01.
        /// </param>
        /// <param name="endTime">
        /// End of the time range as a Unix timestamp in milliseconds. Must be at least 2020-01-01.
        /// </param>
        /// <param name="intervalSeconds">
        /// Default Value: 60
        /// </param>
        /// <param name="groupBy"></param>
        /// <param name="filters"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.WorkspaceAnalyticsQueryResponseModel> GetUsageByProductOverTimeAsync(
            global::System.DateTimeOffset startTime,
            global::System.DateTimeOffset endTime,
            int? intervalSeconds = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item>? groupBy = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.ColumnFilter>? filters = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}