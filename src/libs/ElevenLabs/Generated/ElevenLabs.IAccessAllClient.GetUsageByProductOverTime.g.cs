#nullable enable

namespace ElevenLabs
{
    public partial interface IAccessAllClient
    {
        /// <summary>
        /// Usage-By-Product-Over-Time<br/>
        /// Returns credit usage broken down by product type over time. Timestamps are Unix milliseconds. The response is a tabular structure with columns, column_types, column_units, and rows.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.WorkspaceAnalyticsQueryResponseModel> GetUsageByProductOverTimeAsync(

            global::ElevenLabs.BodyUsageByProductOverTimeV1WorkspaceAnalyticsQueryUsageByProductOverTimePost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Usage-By-Product-Over-Time<br/>
        /// Returns credit usage broken down by product type over time. Timestamps are Unix milliseconds. The response is a tabular structure with columns, column_types, column_units, and rows.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="intervalSeconds">
        /// Default Value: 60
        /// </param>
        /// <param name="groupBy"></param>
        /// <param name="filters"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.WorkspaceAnalyticsQueryResponseModel> GetUsageByProductOverTimeAsync(
            int startTime,
            int endTime,
            int? intervalSeconds = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.BodyUsageByProductOverTimeV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item>? groupBy = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.ColumnFilter>? filters = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}