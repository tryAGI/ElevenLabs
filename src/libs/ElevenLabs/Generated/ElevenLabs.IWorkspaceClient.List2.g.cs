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
    }
}