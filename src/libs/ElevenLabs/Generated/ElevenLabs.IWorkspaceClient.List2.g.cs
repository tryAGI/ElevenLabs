#nullable enable

namespace ElevenLabs
{
    public partial interface IWorkspaceClient
    {
        /// <summary>
        /// Get Workspace Audit Logs<br/>
        /// Returns the audit log for the workspace. Requires enterprise tier and the audit_log_read permission.
        /// </summary>
        /// <param name="limit">
        /// Maximum number of entries per page<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="cursor">
        /// Cursor for the next page (from previous response)
        /// </param>
        /// <param name="timeFromUnixMs">
        /// Only include entries at or after this time (ms since epoch)
        /// </param>
        /// <param name="timeToUnixMs">
        /// Only include entries at or before this time (ms since epoch)
        /// </param>
        /// <param name="actorUid">
        /// Filter by actor user ID
        /// </param>
        /// <param name="className">
        /// Filter by OCSF event class name (e.g. Account Change)
        /// </param>
        /// <param name="activityName">
        /// Filter by audit activity name (e.g. Subscription Creation)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.WorkspaceAuditLogsPageResponse> List2Async(
            int? limit = default,
            string? cursor = default,
            int? timeFromUnixMs = default,
            int? timeToUnixMs = default,
            string? actorUid = default,
            string? className = default,
            string? activityName = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Workspace Audit Logs<br/>
        /// Returns the audit log for the workspace. Requires enterprise tier and the audit_log_read permission.
        /// </summary>
        /// <param name="limit">
        /// Maximum number of entries per page<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="cursor">
        /// Cursor for the next page (from previous response)
        /// </param>
        /// <param name="timeFromUnixMs">
        /// Only include entries at or after this time (ms since epoch)
        /// </param>
        /// <param name="timeToUnixMs">
        /// Only include entries at or before this time (ms since epoch)
        /// </param>
        /// <param name="actorUid">
        /// Filter by actor user ID
        /// </param>
        /// <param name="className">
        /// Filter by OCSF event class name (e.g. Account Change)
        /// </param>
        /// <param name="activityName">
        /// Filter by audit activity name (e.g. Subscription Creation)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.WorkspaceAuditLogsPageResponse>> List2AsResponseAsync(
            int? limit = default,
            string? cursor = default,
            int? timeFromUnixMs = default,
            int? timeToUnixMs = default,
            string? actorUid = default,
            string? className = default,
            string? activityName = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps List2Async as an IAsyncEnumerable&lt;global::ElevenLabs.WorkspaceAuditLogEntryResponse&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="limit">
        /// Maximum number of entries per page<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="timeFromUnixMs">
        /// Only include entries at or after this time (ms since epoch)
        /// </param>
        /// <param name="timeToUnixMs">
        /// Only include entries at or before this time (ms since epoch)
        /// </param>
        /// <param name="actorUid">
        /// Filter by actor user ID
        /// </param>
        /// <param name="className">
        /// Filter by OCSF event class name (e.g. Account Change)
        /// </param>
        /// <param name="activityName">
        /// Filter by audit activity name (e.g. Subscription Creation)
        /// </param> 
        /// <param name="cursor">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::ElevenLabs.WorkspaceAuditLogEntryResponse> List2AutoPagingAsync(
              int? limit = default,
            int? timeFromUnixMs = default,
            int? timeToUnixMs = default,
            string? actorUid = default,
            string? className = default,
            string? activityName = default,
            string? cursor = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}