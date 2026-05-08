#nullable enable

namespace ElevenLabs
{
    public partial interface IAccessAllClient
    {
        /// <summary>
        /// List Api Requests<br/>
        /// Returns a list of API requests. Supports filtering by time range, column filters, and search terms. At least one of start_time or end_time must be provided. An optional sort parameter controls timestamp ordering. Results are ordered by timestamp. Descending if end_time is used, ascending if start_time is used. The response is a tabular structure with columns, column_types, column_units, and rows.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.WorkspaceAnalyticsQueryResponseModel> GetAsync(

            global::ElevenLabs.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Api Requests<br/>
        /// Returns a list of API requests. Supports filtering by time range, column filters, and search terms. At least one of start_time or end_time must be provided. An optional sort parameter controls timestamp ordering. Results are ordered by timestamp. Descending if end_time is used, ascending if start_time is used. The response is a tabular structure with columns, column_types, column_units, and rows.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.WorkspaceAnalyticsQueryResponseModel>> GetAsResponseAsync(

            global::ElevenLabs.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPost request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Api Requests<br/>
        /// Returns a list of API requests. Supports filtering by time range, column filters, and search terms. At least one of start_time or end_time must be provided. An optional sort parameter controls timestamp ordering. Results are ordered by timestamp. Descending if end_time is used, ascending if start_time is used. The response is a tabular structure with columns, column_types, column_units, and rows.
        /// </summary>
        /// <param name="startTime">
        /// Start of the time range as a Unix timestamp in milliseconds.
        /// </param>
        /// <param name="endTime">
        /// End of the time range as a Unix timestamp in milliseconds.
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="sort">
        /// Optional timestamp sort direction. If omitted, defaults to desc when end_time is provided, otherwise asc.
        /// </param>
        /// <param name="filters"></param>
        /// <param name="search"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.WorkspaceAnalyticsQueryResponseModel> GetAsync(
            long? startTime = default,
            long? endTime = default,
            int? limit = default,
            global::ElevenLabs.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort2? sort = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.ColumnFilter>? filters = default,
            string? search = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}